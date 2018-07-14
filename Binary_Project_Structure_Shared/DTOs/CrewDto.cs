using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Binary_Project_Structure_Shared.DTOs
{
    public class CrewDto
    {
        [Required]
        [StringLength(3, MinimumLength = 6, ErrorMessage = "Unacceptable id")]
        public int Id { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 6, ErrorMessage = "Unacceptable flight id")]
        public int PilotId { get; set; }
        
        public List<int> StewardessesId { get; set; }
    }
}
