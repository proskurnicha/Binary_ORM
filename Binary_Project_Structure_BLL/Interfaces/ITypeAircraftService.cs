using Binary_Project_Structure_Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_BLL.Interfaces
{
    public interface ITypeAircraftService
    {
        List<TypeAircraftDto> GetAll();
        TypeAircraftDto GetById(int id);
        void Create(TypeAircraftDto entity);
        void Update(TypeAircraftDto entity);
        bool Delete(int id);
    }
}
