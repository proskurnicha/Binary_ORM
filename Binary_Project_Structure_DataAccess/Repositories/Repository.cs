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
        protected DatabaseContext context;

        public DatabaseContext Context
        {
            get
            {
                return context;
            }
            private set
            {
                context = value;
            }
        }

        public Repository()
        {
            context = new DatabaseContext();
        }

        public virtual List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(Func<TEntity, bool> filter = null)
        {
            var query = context.Set<TEntity>().Where(filter);
            if (query.Count() == 0)
                return null;

            return query.Where(filter).First();
        }

        public virtual void Create(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public virtual void Update(TEntity entity)
        {

        }

        public virtual bool Delete(Predicate<TEntity> prEntity)
        {
            TEntity entity = context.Set<TEntity>().Find(prEntity);

            if (entity != null)
            {
                List<TEntity> entities = context.Set<TEntity>().ToList();
                entities.Remove(entity);
                return true;
            }
            return false;
        }
    }
}
