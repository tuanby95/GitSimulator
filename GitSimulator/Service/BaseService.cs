﻿using GitSimulator.DAL.Repository;
using GitSimulator.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSimulator.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private IUnitOfWork _unitOfWork;
        private IGenericRepository<TEntity> _repository;

        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _repository.Create(entity);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
