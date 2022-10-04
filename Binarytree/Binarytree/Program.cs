using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binarytree
{
    public class Program
    {
        public static int calc;
        public static int height;
        static void Main(string[] args)
        {
            Console.WriteLine("\"Insert the number of roots!");
            
            
                Console.WriteLine($"The height of the binary tree is {GetHeight(height)}");
                Console.ReadLine();

        }

        static int GetHeight(int root)
        {
            root = Convert.ToInt32(Console.ReadLine());
            calc = (int)Math.Pow(2,root - 1);
            return calc;
            
        }


    }
}
