﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;



namespace Data
{
    public class ProductDbContext : DbContext
    {   
        
        public ProductDbContext() : base("Name=ProductDb")
        {
            Database.SetInitializer<ProductDbContext>(
                new CreateDatabaseIfNotExists<ProductDbContext>()
                );
            Database.Initialize(false);
            Database.Log = d => System.Diagnostics.Debug.WriteLine(d);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Loja> Lojas { get; set; }


    }
}
