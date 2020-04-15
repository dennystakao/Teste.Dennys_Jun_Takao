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

            //p.AvaliacaoTecnica1();
            //p.SomaDeQuadrados();
            //p.AvaliacaoTecnica3();
            //p.AvaliacaoTecnica4();
            p.AvaliacaoTecnica5();

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

        private void AvaliacaoTecnica3()
        {
            //A sequência de Fibonacci é definida pela relação:
            //F n = F n - 1 + F n - 2 onde F 1 = 1 e F 2 = 1
            //Assim, os primeiros 12 elementos são:
            //F 1 = 1                       //F 7 = 13
            //F 2 = 1                       //F 8 = 21
            //F 3 = 2                       //F 9 = 34
            //F 4 = 3                       //F 10 = 55
            //F 5 = 5                       //F 11 = 89
            //F 6 = 8                       //F 12 = 144
            //Escreva uma função que retorna o primeiro elemento da sequência de Fibonacci com 5 dígitos.

            Console.WriteLine("Avaliação técnica 3");

            Console.WriteLine(_cr.AvaliacaoTecnica3(1, 1));
        }

        private void AvaliacaoTecnica4()
        {
            //Escrever uma função que recebe uma árvore e um id e retorna um vetor com os ids do caminho desde o nó raiz até o nó passado como parâmetro.

            Console.WriteLine("Avaliação técnica 4");

            Console.WriteLine("Digite um Nó (Número Inteiro):");
            Console.Write("[" + _cr.AvaliacaoTecnica4(Convert.ToInt32(Console.ReadLine())) + "]");

        }

        private void AvaliacaoTecnica5()
        {
            //Utilizando a função:
            //function acumular(combiner, nullValue, list)
            // {
            //     if (list.length == 0)
            //     {
            //         return nullValue;
            //     }
            //     var primeiro = list.removePrimeiro();
            //     return combiner(primeiro, acumular(combiner, nullValue, list));
            // }
            // Neste caso a função acumular deve ser utilizada.A variável “combiner” é um “ponteiro para função”. A implementação da função “combiner” faz parte da solução.
            string str = "";
            List<string> listaStr = new List<string>();

            Console.WriteLine("Avaliação técnica 5");

            while (str != "0")
            {
                Console.WriteLine("Digite uma palavra(Digite 0 para encerrar):");
                str = Console.ReadLine();
                if (str != "0")
                    listaStr.Add(str);
            }

           

            Console.WriteLine(_cr.AvaliacaoTecnica5(listaStr));
        }
        #endregion
    }
}
