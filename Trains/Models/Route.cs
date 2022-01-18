using System.Collections.Generic;
using System;

namespace Trains.Models
{
  public class Route
  {
    public List<Station> Stations { get; set; }

    public Route(List<Station> stations)
    {
      Stations = stations;
    }

    public static List<Route> FindRoutes(Station origin, Station destination)
    {
      //algorithm
      List<Route> allRoutes = new List<Route>();
      Stack<Station> toVisit = new Stack<Station>();
      Dictionary<Station, bool> visited = new Dictionary<Station, bool>();
      allRoutes = DFS(origin, destination, new List<Station>(), visited, allRoutes);
      return allRoutes;
    }

    public static List<Route> DFS(Station current, Station destination, List<Station> route, Dictionary<Station, bool> visited, List<Route> routes)
    {
      Console.WriteLine(current.Name);
      route.Add(current);
      visited.Add(current, true);
      if (current.StationId == destination.StationId)
      {
        routes.Add(new Route(route));
        return routes;
      }
      foreach (Track track in current.OriginTracks)
      {
        if (!visited.ContainsKey(track.Destination))
        {
          routes = DFS(track.Destination, destination, new List<Station>(route), visited, routes);
        }
      }
      return routes;
    }

    //    A
    //  B    C
    // D   
    //E  F

    //if destination: done
    //mark visited
    //add to route
    //go to each destination

    public static string RouteAsJson(/*args*/)
    {
      // convert list to json?
      return "foo";
    }
  }
}