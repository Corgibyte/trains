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
  }
}