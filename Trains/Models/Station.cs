using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Trains.Models
{
  public class Station
  {
    public int StationId { get; set; }

    [Required]
    [StringLength(20)]
    public string Name { get; set; }

    [InverseProperty("Origin"), JsonIgnore]
    public virtual ICollection<Track> OriginTracks { get; set; }

    [InverseProperty("Destination"), JsonIgnore]
    public virtual ICollection<Track> DestinationTracks { get; set; }

    public Station()
    {
      OriginTracks = new HashSet<Track>();
      DestinationTracks = new HashSet<Track>();
    }
  }
}