using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Binary_Project_Structure_Shared.DTOs
{
    public class AircraftDto
    {
        [Required]
        [StringLength(3, MinimumLength = 6)]
        public int Id { get; set; }

        [Required]
        public string AircraftName { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 6)]
        public int TypeAircraftId { get; set; }

        [Required]
        public DateTime DateRelease { get; set; }

        [Required]
        public TimeSpan Lifetime { get; set; }
    }
}
