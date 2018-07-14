using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_Shared.DTOs;

namespace Binary_Project_Structure_BLL.Interfaces
{
    public interface IServiceCommon
    {
        List<TEntityDto> GetAll<TEntity, TEntityDto>() where TEntity : class;
        TEntityDto GetById<TEntity, TEntityDto>(Func<TEntity, bool> filter = null) where TEntity : class;
        void Update<TEntityDto, TEntity>(TEntityDto entityDto) where TEntity : class;
        void Create<TEntityDto, TEntity>(TEntityDto entityDto) where TEntity : class;
        bool Delete<TEntity>(Predicate<TEntity> prEntity) where TEntity : class;
    }
}
