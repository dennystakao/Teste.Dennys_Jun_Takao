using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Teste.Dennys_Jun_Takao.Domain.Entities;

namespace Teste.Dennys_Jun_Takao.Service.Validators
{
    public class ConsoleValidation
    {
        private string retorno;

        internal void VerificarNos(ref Arvore no, Arvore a, int n)
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

        internal string Acumular(List<string> listaStr)
        {
            retorno = "";

            Combinar(listaStr);

            return retorno;
        }

        private void Combinar(List<string> listaStr)
        {
            var arrayList = listaStr.ToArray();
            string palavra = arrayList[0];

            if (!string.IsNullOrEmpty(palavra))
                retorno = retorno + (string.IsNullOrEmpty(retorno) ? palavra : " | " + palavra);

            arrayList = arrayList.Skip(1).ToArray();

            listaStr = arrayList.ToList();

            if (listaStr.Count > 0)
                Combinar(listaStr);
        }
    }
}
