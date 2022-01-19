using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
    public ActionResult Get(int origin, int destination, string sortMethod)
    {
      List<Station> stations = _db.Stations.ToList();
      List<Track> tracks = _db.Tracks.ToList();
      RouteFinder routes = new RouteFinder(origin, destination, stations, tracks);
      IQueryable<Route> allRoutes = routes.ToRoutes().AsQueryable();

      switch (sortMethod)
      {
        case null:
          allRoutes = allRoutes.OrderBy(route => route.TotalTravelTime);
          break;
        case "time":
          allRoutes = allRoutes.OrderBy(route => route.TotalTravelTime);
          break;
        case "fare":
          allRoutes = allRoutes.OrderBy(route => route.TotalFare);
          break;
      }

      return new JsonResult(allRoutes.ToList());
    }
  }
}