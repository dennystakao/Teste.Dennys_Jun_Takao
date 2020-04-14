using System.Collections.Generic;
using Teste.Dennys_Jun_Takao.Domain.Entities;

namespace Teste.Dennys_Jun_Takao.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}
