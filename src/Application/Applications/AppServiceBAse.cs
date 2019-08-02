using Application.Interfaces;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Application.Applications
{

    public class AppServiceBase<TEntity> : IDisposable, InterfaceAppServiceBase<TEntity> where TEntity : class
    {
        private readonly InterfaceServiceBase<TEntity> _serviceBase;
        public AppServiceBase(InterfaceServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }


        public void Dispose()
        {
           _serviceBase.Dispose();
        }
    }
}
