using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_programming
{
    internal class Program
    {

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;


            
        private static void AVGTests()
        {
            Console.WriteLine("Input the number of tests:");
            int nTests = int.Parse(Console.ReadLine());
            List<double> notes = new List<double>();
            for(int i = 1; i <= nTests; i++)
            {
                Console.WriteLine("Insert the " + i+"ª " + "note\n");
                notes.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine(notes.Average());
        }

        private static void Menu()
        {
            while (true)
            {


                string mensagem = "Olá usuário, bem vindo ao programa, utilizando programação funcional" +
                    "\nFunctional programming.\n" +
                    "\nDigite uma das opções abaixo:\n" +
                    "\n      0 - Sair do programa" +
                    "\n      1 - Para ler arquivos" +
                    "\n      2 - Para executar a tabuada" +
                    "\n      3 - Calcular media de alunos";

                Console.WriteLine(mensagem);



                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {

                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("\nRead file selected");
                    Console.ReadLine();
                    break;
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("\nTable math selected");
                    Console.WriteLine("\n Digite o número que deseja na tabuada:");
                    int number = int.Parse(Console.ReadLine());
                    Console.ReadLine();
                    break;
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("\nAVG Value selected");

                    AVGTests();
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid option");
                    Console.ReadLine();
                    break;
                }

            }
        }

        static void Main(string[] args)
        {
            Menu();
            
        }
    }
}
