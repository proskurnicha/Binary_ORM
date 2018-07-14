using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Binary_Project_Structure_Shared.DTOs
{
    public class DepartureDto
    {
        [Required]
        [StringLength(3, MinimumLength = 6, ErrorMessage = "Unacceptable id")]
        public int Id { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 6, ErrorMessage = "Unacceptable flight id")]
        public int FlightId { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 6, ErrorMessage = "Unacceptable crew id")]
        public int CrewId { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 6, ErrorMessage = "Unacceptable aircraft id")]
        public int AircraftId { get; set; }
    }
}
