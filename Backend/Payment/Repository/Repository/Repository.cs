using Domain;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Repository.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        public IEnumerable<TEntity> GetById(int id)
        {
            return null;
        }

        public bool Insert(TEntity obj)
        {
            Thread.Sleep(3000);
            return true;
        }

        public bool Update(TEntity obj)
        {
            Thread.Sleep(3000);
            return true;
        }
    }
}
