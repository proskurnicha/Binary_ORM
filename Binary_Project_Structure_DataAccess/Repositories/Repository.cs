using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Binary_Project_Structure_DataAccess.Interfaces;
namespace Binary_Project_Structure_DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        DataSource dataSource;

        public Repository()
        {
            dataSource = new DataSource();
        }

        public virtual List<TEntity> GetAll()
        {
            List<TEntity> query = dataSource.Set<TEntity>();

            return query.ToList();
        }

        public virtual TEntity GetById(Func<TEntity, bool> filter = null)
        {
            var query = dataSource.Set<TEntity>().Where(filter);
            if (query.Count() == 0)
                return null;

            return query.Where(filter).First();
        }

        public virtual void Create(TEntity entity)
        {
            dataSource.Set<TEntity>().Add(entity);
        }

        public virtual void Update(TEntity entity)
        {

        }

        public virtual bool Delete(Predicate<TEntity> prEntity)
        {
            TEntity entity = dataSource.Set<TEntity>().Find(prEntity);

            if (entity != null)
            {
                List<TEntity> entities = dataSource.Set<TEntity>();
                entities.Remove(entity);
                return true;
            }
            return false;
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

        public virtual Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
