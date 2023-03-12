using GitSimulator.DAL.Repository;
using GitSimulator.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<Team> TeamRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
    }
}
