using System;

namespace Teste.Dennys_Jun_Takao.Domain.Entities
{
    public class Arvore : BaseEntity
    {
        public Arvore[] Filhos { get; set; }

        public bool First()
        {
            throw new NotImplementedException();
        }
    }
}
