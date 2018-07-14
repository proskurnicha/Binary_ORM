using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_DataAccess.Interfaces;
using System.Linq;

namespace Binary_Project_Structure_DataAccess.Repositories
{
    public class FlightRepository : Repository<Flight>
    {
        public override void Update(Flight entity)
        {
            Func<Flight, bool> filter = x => x.Id == entity.Id;
            Flight flight = base.GetById(filter);
            flight.ArrivalPoint = entity.ArrivalPoint;
            flight.ArrivalTime = entity.ArrivalTime;
            flight.DeparturePoint = entity.DeparturePoint;
            flight.DepartureTime = entity.DepartureTime;
            flight.Tickets = entity.Tickets;
        }
    }
}
