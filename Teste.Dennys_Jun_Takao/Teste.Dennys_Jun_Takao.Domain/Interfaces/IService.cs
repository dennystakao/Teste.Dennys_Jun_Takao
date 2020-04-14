using FluentValidation;
using System.Collections.Generic;
using Teste.Dennys_Jun_Takao.Domain.Entities;

namespace Teste.Dennys_Jun_Takao.Domain.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}
