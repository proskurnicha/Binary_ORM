using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Binary_Project_Structure_Shared.DTOs
{
    public class AircraftDto
    {
        public int Id { get; set; }

        public string AircraftName { get; set; }

        public int TypeAircraftId { get; set; }

        public DateTime DateRelease { get; set; }

        public TimeSpan Lifetime { get; set; }
    }
}
