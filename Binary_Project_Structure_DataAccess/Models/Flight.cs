using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_DataAccess.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public string DeparturePoint { get; set; }

        public TimeSpan DepartureTime { get; set; }

        public string ArrivalPoint { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        public List<Ticket> Tickets { get; set; }

        public List<int> TicketsId { get; set; }

    }
}
