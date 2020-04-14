﻿using System;
using System.Collections.Generic;
using FluentValidation;
using Teste.Dennys_Jun_Takao.Domain.Entities;
using Teste.Dennys_Jun_Takao.Domain.Interfaces;
using Teste.Dennys_Jun_Takao.Domain.Repository;

namespace Teste.Dennys_Jun_Takao.Service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        private BaseRepository<T> repository = new BaseRepository<T>();

        public T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Insert(obj);
            return obj;
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("ID não pode ser 0 (zero).");

            repository.Delete(id);
        }

        public IList<T> Get() => repository.Select();

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("ID não pode ser 0 (zero).");

            return repository.Select(id);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não encontrados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
