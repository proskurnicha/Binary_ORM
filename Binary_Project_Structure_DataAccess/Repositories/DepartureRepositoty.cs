using Binary_Project_Structure_DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_DataAccess.Repositories;

namespace Binary_Project_Structure_DataAccess.Repositories
{
    public class DepartureRepositoty : Repository<Departure>
    {
        public override void Update(Departure entity)
        {
            Func<Departure, bool> filter = x => x.Id == entity.Id;
            Departure departure = base.GetById(filter);
            departure.AircraftId = entity.AircraftId;
            departure.Aircraft  = context.SetAsync< Aircraft>().Result.Find(x => x.Id == entity.AircraftId);
            departure.CrewId = entity.CrewId;
            departure.Crew = context.SetAsync<Crew>().Result.Find(x => x.Id == entity.CrewId);
            departure.DepartureTime = entity.DepartureTime;
            departure.FlightId = entity.FlightId;
            departure.Flight = context.SetAsync<Flight>().Result.Find(x => x.Id == entity.FlightId);
        }
    }
}
