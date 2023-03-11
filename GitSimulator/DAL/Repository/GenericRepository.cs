using GitSimulator.DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        
        public DbSet<TEntity> _entities;
        public string _errorMessage = string.Empty;

        public GenericRepository(GitContext context)
        {
            
        }

        public GenericRepository(IUnitOfWork unitOfWork)
            : this(unitOfWork.Context)
        {
        }


        public void Create(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entities;
        }

        public TEntity GetById(int id)
        {
            return _entities.FirstOrDefault(e => e.Equals(id));
        }

        public void Update(TEntity entity)
        {
            _entities.Attach(entity);
            _entities.Entry(entity).State = EntityState.Modified;
        }

    }
}
