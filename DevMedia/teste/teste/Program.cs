using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0;
            decimal b = 2.1;
            Console.WriteLine(a + (double)b);
            Console.WriteLine((decimal)a + b);
            Console.ReadKey();
        }
    }
}
