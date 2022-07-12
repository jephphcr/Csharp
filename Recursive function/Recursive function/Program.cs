using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Recursive_function
{
    class Program
    {
        private static void ReadFile(int numberFile)
        {
            string  filePath = @"C:\Arquivos\arq" + numberFile + ".txt";

            if (File.Exists(filePath)) 
            {
                using (StreamReader file = File.OpenText(filePath))
                {
                    string row;
                    while ((row = file.ReadLine()) != null)
                    {
                        Console.WriteLine(row);

                    }
                }
            }

            string filePath2 = @"C:\Arquivos\arq" + (numberFile + 1) + ".txt";
            if (File.Exists(filePath2))
            {
                Console.WriteLine("\n====================================================================================================\n");
                ReadFile(numberFile + 1);
            }
            
            
                
        }
        static void Main(string[] args)
        {
            ReadFile(1);
            
            Console.ReadKey();
        }
    }
}
