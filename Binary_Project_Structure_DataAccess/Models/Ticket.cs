using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_DataAccess.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public int FlightId { get; set; }

        public Flight Flight { get; set; }
    }
}
