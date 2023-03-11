using GitSimulator.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.DAL.UnitOfWork
{
    internal class UnitOfWork : IUnitOfWork
    {
        public IRepoRepository RepoRepository { get; }

        private readonly GitContext _context;
        private IDbContextTransaction _transaction;
        private bool _disposed;
        private readonly string _errorMessage = string.Empty;

        public UnitOfWork(GitContext context, IRepoRepository repoRepository)
        {
            _context = context;
            RepoRepository = repoRepository;
        }

        public GitContext Context
        {
            get { return _context; }
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void CreateTransaction()
        {
            _transaction = Context.Database.BeginTransaction();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }

        public void Save()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception($"{_errorMessage} {dbEx}");
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
                Context.Dispose();
            _disposed = true;
        }
    }
}
