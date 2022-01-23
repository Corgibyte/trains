using System;
using System.Collections.Generic;
using System.Linq;
using Trains.Models;

public class RouteFinder
{

  private IQueryable<Station> _stations;
  private List<Track> _tracks;
  private Dictionary<int, List<int>> _tracksAsAdj;

  public RouteFinder(List<Station> stations, List<Track> tracks)
  {
    _stations = stations.AsQueryable();
    _tracks = tracks;
    _tracksAsAdj = new Dictionary<int, List<int>>();

    foreach (Station station in stations)
    {
      _tracksAsAdj.Add(station.StationId, new List<int>());
    }

    foreach (Track track in tracks)
    {
      this.AddEdge(track.OriginId, track.DestinationId);
    }
  }

  private void AddEdge(int origin, int destination)
  {
    _tracksAsAdj[origin].Add(destination);
  }

  private List<List<int>> DFS(int origin, int destination)
  {
    List<int> route = new List<int>();

    return Recurse(new List<List<int>>(), origin, destination, route);
  }

  private List<List<int>> Recurse(List<List<int>> routes, int current, int destination, List<int> route)
  {
    route.Add(current);

    if (current == destination)
    {
      routes.Add(route);
      return routes;
    }

    List<int> adjacent = _tracksAsAdj[current];
    foreach (int n in adjacent)
    {
      if (!route.Contains(n))
      {
        routes = Recurse(routes, n, destination, new List<int>(route));
      }
    }
    return routes;
  }

  public List<Route> GetAllRoutes(int origin, int destination)
  {
    return ToRoutes(DFS(origin, destination));
  }

  private List<Route> ToRoutes(List<List<int>> routes)
  {
    //Convert list of list ints to list of routes
    List<Route> routeList = new List<Route>();
    foreach (List<int> intList in routes)
    {
      List<Station> stationList = new List<Station>();
      foreach (int stationId in intList)
      {
        stationList.Add(_stations.FirstOrDefault(station => station.StationId == stationId));
      }
      routeList.Add(new Route(stationList, _tracks.AsQueryable()));
    }
    return routeList;
  }

  //! -----------------------
  public List<Route> GetFastestRoutes(int origin)
  {
    Dictionary<int, int> distances = new Dictionary<int, int>();
    Dictionary<int, int> previous = new Dictionary<int, int>();
    distances.Add(origin, 0);
    Dictionary<int, int> queue = new Dictionary<int, int>();
    foreach (Station station in _stations)
    {
      if (station.StationId != origin)
      {
        distances.Add(station.StationId, int.MaxValue - 1);
        previous.Add(station.StationId, 0);
      }
      queue.Add(station.StationId, distances[station.StationId]);
    }
    while (queue.Count > 0)
    {
      int current = PriorityRemove(queue);
      foreach (int neighbor in _tracksAsAdj[current])
      {
        if (queue.ContainsKey(neighbor))
        {
          int neighborDistance = _tracks.FirstOrDefault(track => track.OriginId == current && track.DestinationId == neighbor).TravelTime;
          int altDistance = distances[current] + neighborDistance;
          if (altDistance < distances[neighbor])
          {
            distances[neighbor] = altDistance;
            previous[neighbor] = current;
          }
        }
      }
    }
    return PreviousToRoutes(previous, origin);
  }

  private int PriorityRemove(Dictionary<int, int> queue)
  {
    int minId = 0;
    int minValue = int.MaxValue;
    foreach (KeyValuePair<int, int> pair in queue)
    {
      if (pair.Value < minValue)
      {
        minId = pair.Key;
        minValue = pair.Value;
      }
    }
    queue.Remove(minId);
    return minId;
  }

  private List<Route> PreviousToRoutes(Dictionary<int, int> previous, int origin)
  {
    List<Route> routes = new List<Route>();
    foreach (KeyValuePair<int, int> kvp in previous)
    {
      Route route = new Route(GetStationsRecursive(new Stack<Station>(), previous, origin, kvp.Key), _tracks.AsQueryable());
      routes.Add(route);
    }
    return routes;
  }

  private Stack<Station> GetStationsRecursive(Stack<Station> stations, Dictionary<int, int> previous, int origin, int currentStation)
  {
    stations.Push(_stations.FirstOrDefault(station => station.StationId == currentStation));
    if (currentStation == origin)
    {
      return stations;
    }
    else
    {
      return GetStationsRecursive(stations, previous, origin, previous[currentStation]);
    }
  }
}
