using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_BLL.Interfaces;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_Shared.DTOs;

namespace Binary_Project_Structure_BLL.Services
{
    public class CrewService : Service, ICrewService
    {
        public List<CrewDto> GetAll()
        {
            return GetAll<Crew, CrewDto>();
        }

        public CrewDto GetById(int id)
        {
            return GetById<Crew, CrewDto>(x => x.Id == id);
        }

        public void Create(CrewDto entity)
        {
            Create<CrewDto, Crew>(entity);
        }

        public void Update(CrewDto entity)
        {
            Update<CrewDto, Crew>(entity);
        }

        bool ICrewService.Delete(int id)
        {
            return Delete<Crew>(x => x.Id == id);
        }
    }
}
