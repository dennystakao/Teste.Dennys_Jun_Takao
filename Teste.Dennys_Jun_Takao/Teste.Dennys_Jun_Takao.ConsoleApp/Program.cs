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
            string nome, sobreNome;

            Console.WriteLine("Digite um Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite um SobreNome:");
            sobreNome = Console.ReadLine();

            p.AvaliacaoTecnica1(nome, sobreNome);

            Console.ReadKey();

        }

        #region Metodos a serem implementados
        private void AvaliacaoTecnica1(string nome, string sobreNome)
        {
            //Escreva uma função que imprima os números de 1 a 100 e, ao lado dos números múltiplos de 3 imprima “<Nome>”, ao lado dos múltiplos de 5 imprima “<SobreNome>” e ao lado dos múltiplos de 3 e 5 imprima "<Nome><SobreNome>"”.
            Console.WriteLine("Avaliação técnica 1");
            var numList = _cr.AvaliacaoTecnica1(nome, sobreNome);
            foreach (var item in numList)
                Console.WriteLine(item);
        }
        #endregion
    }
}
