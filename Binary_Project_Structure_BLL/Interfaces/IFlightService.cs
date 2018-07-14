using Binary_Project_Structure_Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_BLL.Interfaces
{
    public interface IFlightService
    {
        List<FlightDto> GetAll();
        FlightDto GetById(int id);
        void Create(FlightDto entity);
        void Update(FlightDto entity);
        bool Delete(int id);
    }
}
