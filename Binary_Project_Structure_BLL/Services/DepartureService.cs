using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_BLL.Interfaces;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_Shared.DTOs;

namespace Binary_Project_Structure_BLL.Services
{
    public class DepartureService : Service, IDepartureService
    {
        public List<DepartureDto> GetAll()
        {
            return GetAll<Departure, DepartureDto>();
        }

        public DepartureDto GetById(int id)
        {
            return GetById<Departure, DepartureDto>(x => x.Id == id);
        }

        public void Create(DepartureDto entity)
        {
            Create<DepartureDto, Departure>(entity);
        }

        public void Update(DepartureDto entity)
        {
            Update<DepartureDto, Departure>(entity);
        }

        bool IDepartureService.Delete(int id)
        {
            return Delete<Departure>(x => x.Id == id);
        }
    }
}
