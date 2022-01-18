using Microsoft.EntityFrameworkCore;
using System;

namespace Trains.Models
{
  public class TrainsContext : DbContext
  {
    public DbSet<Station> Stations { get; set; }
    public DbSet<Track> Tracks { get; set; }

    public TrainsContext(DbContextOptions<TrainsContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Station>()
        .HasData(
          new Station { StationId = 1, Name = "Vancouver" },
          new Station { StationId = 2, Name = "Calgary" },
          new Station { StationId = 3, Name = "Winnipeg" },
          new Station { StationId = 4, Name = "Seattle" },
          new Station { StationId = 5, Name = "Helena" }
        );

      builder.Entity<Track>()
        .HasData(
          // Vancouver - Calgary
          new Track { TrackId = 1, OriginId = 1, DestinationId = 2, TravelTime = new TimeSpan(3, 0, 0) },
          new Track { TrackId = 2, OriginId = 2, DestinationId = 1, TravelTime = new TimeSpan(3, 0, 0) },
          // Vancouver - Seattle
          new Track { TrackId = 3, OriginId = 1, DestinationId = 4, TravelTime = new TimeSpan(1, 0, 0) },
          new Track { TrackId = 4, OriginId = 4, DestinationId = 1, TravelTime = new TimeSpan(1, 0, 0) },
          // Seattle - Calgary
          new Track { TrackId = 5, OriginId = 2, DestinationId = 4, TravelTime = new TimeSpan(4, 0, 0) },
          new Track { TrackId = 6, OriginId = 4, DestinationId = 2, TravelTime = new TimeSpan(4, 0, 0) },
          // Calgary - Winnipeg
          new Track { TrackId = 7, OriginId = 2, DestinationId = 3, TravelTime = new TimeSpan(6, 0, 0) },
          new Track { TrackId = 8, OriginId = 3, DestinationId = 2, TravelTime = new TimeSpan(6, 0, 0) },
          // Calgary - Helena
          new Track { TrackId = 9, OriginId = 2, DestinationId = 5, TravelTime = new TimeSpan(4, 0, 0) },
          new Track { TrackId = 10, OriginId = 5, DestinationId = 2, TravelTime = new TimeSpan(4, 0, 0) },
          // Winnipeg - Helena
          new Track { TrackId = 11, OriginId = 3, DestinationId = 5, TravelTime = new TimeSpan(4, 0, 0) },
          new Track { TrackId = 12, OriginId = 5, DestinationId = 3, TravelTime = new TimeSpan(4, 0, 0) },
          // Seattle - Helena
          new Track { TrackId = 13, OriginId = 5, DestinationId = 4, TravelTime = new TimeSpan(6, 0, 0) },
          new Track { TrackId = 14, OriginId = 4, DestinationId = 5, TravelTime = new TimeSpan(6, 0, 0) }
        );
    }
  }
}