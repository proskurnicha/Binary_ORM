using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Project_Structure_DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();

        TEntity GetById(Func<TEntity, bool> filter = null);

        void Create(TEntity entity);

        void Update(TEntity id);

        bool Delete(Predicate<TEntity> prEntity);
    }
}
