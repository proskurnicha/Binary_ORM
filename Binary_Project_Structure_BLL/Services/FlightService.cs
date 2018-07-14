using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_BLL.Interfaces;
using Binary_Project_Structure_DataAccess.Interfaces;
using Binary_Project_Structure_Shared.DTOs;
using Binary_Project_Structure_DataAccess.Models;
using AutoMapper;
using Ninject;
using Binary_Project_Structure_DataAccess.UnitOfWork;

namespace Binary_Project_Structure_BLL.Services
{
    public class FlightService : Service, IFlightService 
    {
        public List<FlightDto> GetAll()
        {
            return GetAll<Flight, FlightDto>();
        }

        public FlightDto GetById(int id)
        {
            return GetById<Flight, FlightDto>(x => x.Id == id);
        }

        public void Create(FlightDto entity)
        {
            Create<FlightDto, Flight>(entity);
        }

        public void Update(FlightDto entity)
        {
            Update<FlightDto, Flight>(entity);
        }
        
        bool IFlightService.Delete(int id)
        {
            return Delete<Flight>(x => x.Id == id);
        }
    }
}
