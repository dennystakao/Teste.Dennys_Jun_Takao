using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Dennys_Jun_Takao.Service.Services;

namespace Teste.Dennys_Jun_Takao.ConsoleApp
{
    class Program
    {
        public Program()
        {
        }

        ConsoleResolution _cr = new ConsoleResolution();

        static void Main(string[] args)
        {
            Program p = new Program();

            p.AvaliacaoTecnica1();
            p.SomaDeQuadrados();

            Console.ReadKey();
        }

        #region Metodos a serem implementados
        private void AvaliacaoTecnica1()
        {
            //Escreva uma função que imprima os números de 1 a 100 e, ao lado dos números múltiplos de 3 imprima “<Nome>”, ao lado dos múltiplos de 5 imprima “<SobreNome>” e ao lado dos múltiplos de 3 e 5 imprima "<Nome><SobreNome>"”.
            string nome, sobreNome;

            Console.WriteLine("Avaliação técnica 1");

            Console.WriteLine("Digite um Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite um SobreNome:");
            sobreNome = Console.ReadLine();

            var numList = _cr.AvaliacaoTecnica1(nome, sobreNome);
            foreach (var item in numList)
                Console.WriteLine(item);
        }

        //private void AvaliacaoTecnica2()
        private void SomaDeQuadrados()
        {
            //Implemente a função somaDeQuadrados que retorna a soma de quadrados de uma lista.
            //EXEMPLO:
            //somaDeQuadrados([1, 2, 3, 4, 5])
            //retorna o número 55.
            int num = 1;
            List<int> listaNum = new List<int>();

            Console.WriteLine("Avaliação técnica 2");

            while (num != 0)
            {
                Console.WriteLine("Digite um Numero inteiro (Digite 0 para calcular):");
                num = Convert.ToInt32(Console.ReadLine());
                listaNum.Add(num);
            }

            Console.WriteLine(_cr.AvaliacaoTecnica2(listaNum));
        }
        #endregion
    }
}
