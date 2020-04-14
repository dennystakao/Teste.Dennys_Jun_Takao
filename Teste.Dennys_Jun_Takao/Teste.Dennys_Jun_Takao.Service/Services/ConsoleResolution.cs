using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Dennys_Jun_Takao.Service.Services
{
    public class ConsoleResolution
    {
        public List<string> AvaliacaoTecnica1(string nome, string sobreNome)
        {
            List<string> retorno = new List<string>();

            for (int i = 1; i <= 100; i++)
                if (i % 3 == 0 && i % 5 == 0)
                    retorno.Add(i + nome + sobreNome);
                else
                    if (i % 3 == 0)
                    retorno.Add(i + nome);
                else
                    if (i % 5 == 0)
                    retorno.Add(i + sobreNome);
                else
                    retorno.Add(i.ToString());

            return retorno;
        }
    }
}
