using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
    [HttpGet("AllRoutesBetween")]
    public ActionResult AllRoutesBetween(int origin, int destination, string sortMethod)
    {
      if (origin == 0 || destination == 0)
      {
        return BadRequest(new { Message = "Request must include origin and destination" });
      }

      if (_db.Stations.Any(station => station.StationId == origin) == false || _db.Stations.Any(station => station.StationId == destination) == false)
      {
        return NotFound(new { Message = "origin or destination station does not exist" });
      }

      List<Station> stations = _db.Stations.ToList();
      List<Track> tracks = _db.Tracks.ToList();
      RouteFinder routeFinder = new RouteFinder(stations, tracks);
      IQueryable<Route> allRoutes = routeFinder.GetAllRoutes(origin, destination).AsQueryable();

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

    //GET api/routes/
    [HttpGet("AllDestinationsFrom")]
    public ActionResult AllDestinationsFrom(int origin)
    {
      Station originStation = _db.Stations.FirstOrDefault(station => station.StationId == origin);
      if (originStation == null)
      {
        return NotFound(new { Message = "Origin station does not exist" });
      }
      List<Station> stations = _db.Stations.ToList();
      List<Track> tracks = _db.Tracks.ToList();
      RouteFinder routeFinder = new RouteFinder(stations, tracks);
      List<Route> allRoutes = routeFinder.GetFastestRoutes(origin);
      return new JsonResult(allRoutes.AsQueryable().OrderBy(route => route.TotalTravelTime));
    }
  }
}