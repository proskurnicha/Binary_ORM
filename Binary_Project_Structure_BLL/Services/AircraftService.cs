using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_BLL.Interfaces;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_Shared.DTOs;

namespace Binary_Project_Structure_BLL.Services
{
    public class AircraftService : Service, IAircraftService
    {
        public List<AircraftDto> GetAll()
        {
            return GetAll<Aircraft, AircraftDto>();
        }

        public AircraftDto GetById(int id)
        {
            return GetById<Aircraft, AircraftDto>(x => x.Id == id);
        }

        public void Create(AircraftDto entity)
        {
            Create<AircraftDto, Aircraft>(entity);
        }

        public void Update(AircraftDto entity)
        {
            Update<AircraftDto, Aircraft>(entity);
        }

        bool IAircraftService.Delete(int id)
        {
            return Delete<Aircraft>(x => x.Id == id);
        }
    }
}
