using Domain.Interfaces.Repositories;
using InfraData.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfraData.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, InterfaceRepositoryBase<TEntity> where TEntity : class
    {
        protected DbContextoGeral Db = new DbContextoGeral();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }
        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }


        public void Dispose()
        {
            Db.Dispose();
        }

    }
}
