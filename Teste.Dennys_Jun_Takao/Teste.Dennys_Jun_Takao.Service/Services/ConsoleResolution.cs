using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Dennys_Jun_Takao.Domain.Entities;
using Teste.Dennys_Jun_Takao.Domain.Repository;
using Teste.Dennys_Jun_Takao.Service.Validators;

namespace Teste.Dennys_Jun_Takao.Service.Services
{
    public class ConsoleResolution
    {
        BaseRepository<Arvore> _baseArvore = new BaseRepository<Arvore>();
        ConsoleValidation _cv = new ConsoleValidation();

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
            if (fibonacci < 10000) return AvaliacaoTecnica3(fibonacci, fibonacci + numA);
            else return fibonacci;
        }

        public string AvaliacaoTecnica4(int noParametro)
        {
            Arvore a = _baseArvore.GerarArvore();
            int noAtual = 0;
            int[] intArr = new int[0];
            int count = 0;
            Arvore no = new Arvore();

            while (noAtual != a.Id && a.Id != noParametro && noParametro > 0)
            {
                Array.Resize(ref intArr, intArr.Length + 1);
                intArr[count] = noParametro;
                count++;
                _cv.VerificarNos(ref no, a, noParametro);
                noParametro = no.Id;
                noAtual = no.Id;
            }

            if (noParametro == 0)
                return "";

            Array.Resize(ref intArr, intArr.Length + 1);
            intArr[count] = a.Id;
            Array.Reverse(intArr);
            return string.Join(",", intArr);
        }

        public int AvaliacaoTecnica6(string palavraTriangulo)
        {
            int somaPalavra = 0, numero = 1;
            int numeroTrangulo = (numero * (numero + 1)) / 2;
            char[] characters = palavraTriangulo.ToCharArray();

            foreach (char oneChar in characters)
                somaPalavra += ((int)char.ToUpper(oneChar)) - 64;

            while (somaPalavra > numeroTrangulo)
            {
                numero++;
                numeroTrangulo = (numero * (numero + 1)) / 2;
            }

            if (somaPalavra == numeroTrangulo)
                return numero;

            return -1;
        }
    }
}
