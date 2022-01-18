using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Trains.Models;

namespace Trains.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RoutesController : ControllerBase
  {
    private readonly TrainsContext _db;

    public RoutesController(TrainsContext db)
    {
      _db = db;
    }

    //GET api/routes?origin=x&destination=y
    [HttpGet]
    public async Task<ActionResult<string>> Get(int origin, int destination)
    {
      Track target = await _db.Tracks.FirstOrDefaultAsync(track => track.OriginId == origin && track.DestinationId == destination);
      if (target != null)
      {
        return target.TravelTime.ToString();
      }
      else
      {
        //try algorithm        
        Station originStation = await _db.Stations
          .Include(station => station.OriginTracks)
          .ThenInclude(track => track.Destination)
          .FirstOrDefaultAsync(station => station.StationId == origin);
        Station destinationStation = await _db.Stations.FirstOrDefaultAsync(station => station.StationId == destination);
        return JsonSerializer.Serialize(Route.FindRoutes(originStation, destinationStation));
      }
    }
  }
}