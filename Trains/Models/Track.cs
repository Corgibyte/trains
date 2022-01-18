using System;

namespace Trains.Models
{
  public class Track
  {
    public int TrackId { get; set; }
    public int OriginId { get; set; }
    public int DestinationId { get; set; }
    public virtual Station Origin { get; set; }
    public virtual Station Destination { get; set; }
    public TimeSpan TravelTime { get; set; }
  }
}