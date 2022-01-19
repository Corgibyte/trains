using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Trains.Models;

namespace Trains.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TracksController : ControllerBase
  {
    private readonly TrainsContext _db;

    public TracksController(TrainsContext db)
    {
      _db = db;
    }

    //GET api/tracks
    [HttpGet]
    public async Task<ActionResult> Get(int origin, int destination)
    {
      IQueryable<Track> query = _db.Tracks.AsQueryable();

      if (origin != 0)
      {
        query = query.Where(track => track.OriginId == origin);
      }

      if (destination != 0)
      {
        query = query.Where(track => track.DestinationId == destination);
      }
      List<Track> tracks = await query
        .Include(track => track.Origin)
        .Include(track => track.Destination)
        .OrderBy(track => track.TravelTime)
        .ToListAsync();
      return new JsonResult(tracks);
    }

    [HttpPost]
    public async Task<ActionResult<Track>> Post(Track track)
    {
      if (!_db.Tracks.Any(t => t.DestinationId == track.DestinationId && t.OriginId == track.OriginId))
      {
        _db.Tracks.Add(track);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTrack), new { id = track.TrackId }, track);
      }
      else
      {
        return BadRequest(new { Message = "Track already exists between that origin and destination" });
      }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Track>> GetTrack(int id)
    {
      Track track = await _db.Tracks.Include(track => track.Origin).Include(track => track.Destination).FirstOrDefaultAsync(track => track.TrackId == id);

      if (track == null)
      {
        return NotFound();
      }
      return track;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Track track)
    {
      if (id != track.TrackId)
      {
        return BadRequest(new { Message = "TrackId must match id in endpoint URL" });
      }
      _db.Entry(track).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!_db.Tracks.Any(track => track.TrackId == id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTrack(int id)
    {
      Track track = await _db.Tracks.FindAsync(id);
      if (track == null)
      {
        return NotFound();
      }
      _db.Tracks.Remove(track);
      await _db.SaveChangesAsync();
      return NoContent();
    }
  }
}