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

        public Arvore GerarArvore()
        {
            var no9 = new Arvore { Id = 9 };
            var no13 = new Arvore { Id = 13, Filhos = GerarFilho(no9, null) };
            var no12 = new Arvore { Id = 12, Filhos = GerarFilho(null, no13) };
            var no2 = new Arvore { Id = 2, Filhos = GerarFilho(no12, null) };
            var no8 = new Arvore { Id = 8 };
            var no10 = new Arvore { Id = 10, Filhos = GerarFilho(no8, null) };
            var no4 = new Arvore { Id = 4, Filhos = GerarFilho(no10, no2) };
            var no5 = new Arvore { Id = 5 };
            var no3 = new Arvore { Id = 3 };
            var no6 = new Arvore { Id = 6 };
            var no11 = new Arvore { Id = 11, Filhos = GerarFilho(no6, no5) };
            var no7 = new Arvore { Id = 7, Filhos = GerarFilho(no3, no11) };
            var no1 = new Arvore { Id = 1, Filhos = GerarFilho(no4, no7) };
            return no1;
        }

        private Arvore[] GerarFilho(Arvore noEsquerdo, Arvore noDireito)
        {
            Arvore[] tree = new Arvore[2];
            tree[0] = noEsquerdo;
            tree[1] = noDireito;
            return tree;
        }
    }
}
