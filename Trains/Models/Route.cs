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
      for (int i = 0; i < Stations.Count - 1; i++)
      {
        Track track = tracks.FirstOrDefault(track => track.OriginId == stations[i].StationId && track.DestinationId == stations[i + 1].StationId);
        TotalTravelTime += track.TravelTime;
        TotalFare += track.Fare;
      }
    }
  }
}