using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trains.Models
{
  public class Station
  {
    public int StationId { get; set; }

    [Required]
    [StringLength(20)]
    public string Name { get; set; }

    [InverseProperty("Origin")]
    public virtual ICollection<Track> OriginTracks { get; set; }
    [InverseProperty("Destination")]
    public virtual ICollection<Track> DestinationTracks { get; set; }

    public Station()
    {
      OriginTracks = new HashSet<Track>();
      DestinationTracks = new HashSet<Track>();
    }
  }
}