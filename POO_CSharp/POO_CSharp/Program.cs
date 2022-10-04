using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Physical user = new Physical("Jeff");
            //Console.WriteLine(user.CustomizedName());
            //Physical.Save(user);

            //new Physical("Jefferson").Save();
            //new Physical("Jeff").Save();
            //new Physical("Rocha").Save();

            //Physical.Save(user);

            //Physical.All();

            //var list = Physical.All();

            //foreach(var names in list)
            //{
            //    Console.WriteLine(names.Name);
            //}

            Feline cat = new Feline();
            try
            {
                cat.Walk();
            }
            catch (AnimalException e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            cat.Run();
            cat.Walk();




        }
    }
}
