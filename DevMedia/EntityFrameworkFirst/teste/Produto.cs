﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Produto")]
    public class Produto
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(8000)]
        public string Descricao { get; set; }
        [Range(-99999999999999.99,99999999999999.99)]
        [Required]
        public decimal Valor { get; set; }

        [ForeignKey("Loja")]
        public int LojaId { get; set; }

        public virtual Loja Loja { get; set; }
    }
}
