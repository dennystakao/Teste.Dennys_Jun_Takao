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

        public int AvaliacaoTecnica2(List<int> listaNum)
        {
            int total = 0;
            foreach (var item in listaNum)
                total = total + item * item;
            return total;
        }

        public int AvaliacaoTecnica3(int numA, int fibonacci)
        {
            if (fibonacci < 10000) return AvaliacaoTecnica3(fibonacci, fibonacci+ numA);
            else return fibonacci;
        }
    }
}
