using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace onetonEntityFramework
{
    public class LojaContext : DbContext
    {
        public LojaContext() : base("Name=StoreDb")
        {
            Database.SetInitializer<LojaContext>(
                new CreateDatabaseIfNotExists<LojaContext>()
                );
            Database.Initialize(false);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
