using System;
using System.Collections.Generic;
using System.Linq;

namespace Trains.Models
{
  public class Route
  {
    public List<Station> Stations { get; set; }
    public int TotalTravelTime { get; set; }
    public double TotalFare { get; set; }

    public Route(List<Station> stations, IQueryable<Track> tracks)
    {
      Stations = stations;
      TotalTravelTime = 0;
      (TotalTravelTime, TotalFare) = GetTotalTravelTimeAndFare(tracks);
    }

    public Route(Stack<Station> stations, IQueryable<Track> tracks)
    {
      List<Station> list = new List<Station>();
      while (stations.Count > 0)
      {
        Station next = stations.Pop();
        list.Add(next);
      }
      Stations = list;
      (TotalTravelTime, TotalFare) = GetTotalTravelTimeAndFare(tracks);
    }

    private (int, double) GetTotalTravelTimeAndFare(IQueryable<Track> tracks)
    {
      int travelTime = 0;
      double fare = 0;
      for (int i = 0; i < Stations.Count - 1; i++)
      {
        Track track = tracks.FirstOrDefault(track => track.OriginId == Stations[i].StationId && track.DestinationId == Stations[i + 1].StationId);
        travelTime += track.TravelTime;
        fare += track.Fare;
      }
      return (travelTime, fare);
    }
  }
}