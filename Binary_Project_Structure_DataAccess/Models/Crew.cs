using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_DataAccess.Models
{
    public class Crew
    {
        public int Id { get; set; }

        public int PilotId { get; set; }

        public Pilot Pilot { get; set; }

        public List<Stewardess> Stewardesses { get; set; }

        public List<int> StewardessesId { get; set; }

    }
}
