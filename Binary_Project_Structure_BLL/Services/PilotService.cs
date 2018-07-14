using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_BLL.Interfaces;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_Shared.DTOs;

namespace Binary_Project_Structure_BLL.Services
{
    public class PilotService : Service, IPilotService
    {
        public List<PilotDto> GetAll()
        {
            return GetAll<Pilot, PilotDto>();
        }

        public PilotDto GetById(int id)
        {
            return GetById<Pilot, PilotDto>(x => x.Id == id);
        }

        public void Create(PilotDto entity)
        {
            Create<PilotDto, Pilot>(entity);
        }

        public void Update(PilotDto entity)
        {
            Update<PilotDto, Pilot>(entity);
        }

        bool IPilotService.Delete(int id)
        {
            return Delete<Pilot>(x => x.Id == id);
        }
    }
}
