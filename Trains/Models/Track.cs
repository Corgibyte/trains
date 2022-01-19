using System;
using System.Text.Json.Serialization;

namespace Trains.Models
{
  public class Track
  {
    public int TrackId { get; set; }

    // [JsonIgnore]
    public int OriginId { get; set; }

    // [JsonIgnore]
    public int DestinationId { get; set; }

    public virtual Station Origin { get; set; }
    public virtual Station Destination { get; set; }
    public int TravelTime { get; set; }
    public double Fare { get; set; }
  }
}