using System;
using System.Collections.Generic;
using System.Linq;
using Trains.Models;

public class RouteFinder
{

  private IQueryable<Station> _stations;
  private List<Track> _tracks;
  private Dictionary<int, List<int>> _tracksAsAdj;
  private List<List<int>> _routes = new List<List<int>>();

  public RouteFinder(int origin, int destination, List<Station> stations, List<Track> tracks)
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

    this.DFS(origin, destination);
  }

  private void AddEdge(int origin, int destination)
  {
    _tracksAsAdj[origin].Add(destination);
  }

  public void DFS(int origin, int destination)
  {
    List<int> route = new List<int>();

    Recurse(origin, destination, route);
  }

  private void Recurse(int current, int destination, List<int> route)
  {
    route.Add(current);

    if (current == destination)
    {
      _routes.Add(route);
      return;
    }

    List<int> adjacent = _tracksAsAdj[current];
    foreach (int n in adjacent)
    {
      if (!route.Contains(n))
      {
        Recurse(n, destination, new List<int>(route));
      }
    }
  }

  public void TestThisBS()
  {
    foreach (List<int> route in _routes)
    {
      Console.WriteLine("Here is a route: ");
      foreach (int station in route)
      {
        Console.Write("station #{0}, ", station);
      }
    }
  }

  public List<Route> ToRoutes()
  {
    //Convert list of list ints to list of routes
    List<Route> routeList = new List<Route>();
    foreach (List<int> intList in _routes)
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
}
