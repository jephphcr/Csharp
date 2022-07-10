using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onetonEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            LojaContext db = new LojaContext();

            db.Products.ToList().ForEach(p => Console.WriteLine(p));
            
            
            
            //Product p = new Product()
            //{
            //    Name = "Refrigerator",
            //    IdBrand = 1,
            //};

            //db.Products.Add(p);
            //db.SaveChanges();
        }
    }
}
