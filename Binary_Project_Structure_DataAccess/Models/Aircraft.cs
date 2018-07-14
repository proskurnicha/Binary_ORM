using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_DataAccess.Models
{
    public class Aircraft
    {
        public int Id { get; set; }

        public string AircraftName { get; set; }

        public int TypeAircraftId { get; set; }

        public TypeAircraft TypeAircraft { get; set; }

        public DateTime DateRelease { get; set; }

        public TimeSpan Lifetime { get; set; }
    }
}
