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
  }
}