using Binary_Project_Structure_Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_BLL.Interfaces
{
    public interface ICrewService
    {
        List<CrewDto> GetAll();
        CrewDto GetById(int id);
        void Create(CrewDto entity);
        void Update(CrewDto entity);
        bool Delete(int id);
    }
}
