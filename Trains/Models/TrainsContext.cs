using Microsoft.EntityFrameworkCore;

namespace Trains.Models
{
  public class TrainsContext : DbContext
  {
    public DbSet<Station> Stations { get; set; }
    public DbSet<Track> Tracks { get; set; }

    public TrainsContext(DbContextOptions<TrainsContext> options) : base(options)
    {
    }
  }
}