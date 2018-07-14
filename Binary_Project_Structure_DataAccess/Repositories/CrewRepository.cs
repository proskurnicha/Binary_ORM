using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_DataAccess.Repositories;

namespace Binary_Project_Structure_DataAccess.Repositories
{
    public class CrewRepository : Repository<Crew>
    {
        public override void Update(Crew entity)
        {
            Func<Crew, bool> filter = x => x.Id == entity.Id;
            Crew crew = base.GetById(filter);
            crew.PilotId = entity.PilotId;
            crew.Pilot = DataSource.Pilots.Find(x => x.Id == entity.PilotId);
            crew.Stewardesses = entity.Stewardesses;
        }
    }
}
