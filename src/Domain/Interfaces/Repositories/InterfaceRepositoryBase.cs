using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface InterfaceRepositoryBase<TEntity> where TEntity : class
    {
        //CRUD padrão
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Dispose();
    }
}
