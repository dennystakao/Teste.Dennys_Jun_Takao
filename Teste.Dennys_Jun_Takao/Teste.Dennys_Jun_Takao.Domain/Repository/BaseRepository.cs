using System;
using System.Collections.Generic;
using System.Linq;
using Teste.Dennys_Jun_Takao.Domain.Entities;
using Teste.Dennys_Jun_Takao.Domain.Interfaces;

namespace Teste.Dennys_Jun_Takao.Domain.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> Select()
        {
            throw new NotImplementedException();
        }

        public T Select(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
