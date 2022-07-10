using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace onetonEntityFramework
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        [ForeignKey("Brand")]
        public int IdBrand { get; set; }

        public virtual Brand Brand { get; set; }

    }
}
