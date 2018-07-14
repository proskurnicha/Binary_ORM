using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Binary_Project_Structure_Shared.DTOs
{
    public class FlightDto
    {
        [Required]
        [StringLength(3, MinimumLength = 6, ErrorMessage = "Unacceptable id")]
        public int Id { get; set; }

        [Required]
        public string DeparturePoint { get; set; }

        [Required]
        public TimeSpan DepartureTime { get; set; }

        [Required]
        public string ArrivalPoint { get; set; }

        [Required]
        public TimeSpan ArrivalTime { get; set; }

        public List<int> TicketsId { get; set; }
    }
}
