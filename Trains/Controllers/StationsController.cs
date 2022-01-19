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
  public class StationsController : ControllerBase
  {
    private readonly TrainsContext _db;

    public StationsController(TrainsContext db)
    {
      _db = db;
    }

    //GET api/stations
    [HttpGet]
    public async Task<ActionResult> Get()
    {
      List<Station> stations = await _db.Stations.OrderBy(station => station.Name).ToListAsync();
      return new JsonResult(stations);
    }

    [HttpPost]
    public async Task<ActionResult<Station>> Post(Station station)
    {
      _db.Stations.Add(station);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = station.StationId }, station);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Station station)
    {
      if (id != station.StationId)
      {
        return BadRequest();
      }

      _db.Entry(station).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!StationExists(id))
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

    private bool StationExists(int id)
    {
      return _db.Stations.Any(e => e.StationId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStation(int id)
    {
      var station = await _db.Stations.FindAsync(id);
      if (station == null)
      {
        return NotFound();
      }

      _db.Stations.Remove(station);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}