using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Dennys_Jun_Takao.Domain.Entities;

namespace Teste.Dennys_Jun_Takao.Service.Validators
{
    public class ConsoleValidation
    {
        public void VerificarNos(ref Arvore no, Arvore a, int n)
        {
            if (a.Id == n)
                return;
            else
            if (a.Filhos != null)
            {
                if ((a.Filhos[0] != null && a.Filhos[0].Id == n) || (a.Filhos[1] != null && a.Filhos[1].Id == n))
                {
                    no = a;
                }
                else
                {
                    if (a.Filhos[0] != null)
                    {
                        VerificarNos(ref no, a.Filhos[0], n);
                    }
                    if (a.Filhos[1] != null)
                    {
                        VerificarNos(ref no, a.Filhos[1], n);
                    }
                }
            }
        }
    }
}
