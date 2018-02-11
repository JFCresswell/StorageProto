using System;
using System.Collections.Generic;
using System.Text;

namespace StorageBin.Core.Interfaces
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        TEntity GetById(TKey id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
