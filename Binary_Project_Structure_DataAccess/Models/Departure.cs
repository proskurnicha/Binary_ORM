using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_DataAccess.Models
{
    public class Departure
    {
        public int Id { get; set; }

        public int FlightId { get; set; }

        public Flight Flight { get; set; }

        public DateTime DepartureTime { get; set; }

        public int CrewId { get; set; }

        public Crew Crew { get; set; }

        public int AircraftId { get; set; }

        public Aircraft Aircraft { get; set; }
    }
}
