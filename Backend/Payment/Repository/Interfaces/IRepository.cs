using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        bool Insert(TEntity obj);
        bool Update(TEntity obj);
        IEnumerable<TEntity> GetById(int id);
    }
}
