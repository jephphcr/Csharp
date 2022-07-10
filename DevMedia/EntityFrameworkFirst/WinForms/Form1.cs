using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Domain;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private ProductDbContext context;
        public Form1()
        {
            InitializeComponent();

            context = new ProductDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja()
            {
                Name = "Loja teste devmedia",
                Description = "Essa é uma inserção para teste"
            };
            context.Lojas.Add(loja);
           
            Produto produto = new Produto()
            {
                Nome = "Produto teste devmedia",
                Valor = 20m,
                Loja = loja

               
            };
            context.Produtos.Add(produto);
            context.SaveChanges();
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loja loja = context.Lojas.Find(1);

            Produto novoProduto = new Produto()
            {
                Nome = "Novo produto",
                Valor = 100m,
                LojaId = loja.Id,
                Loja = loja
            };
            context.Produtos.Add(novoProduto);
            context.SaveChanges(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produto produto = context.Produtos.Find(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IEnumerable<Produto> produtosComecadosComA = 
                context.Produtos.Where(p => p.Nome.StartsWith("N"));

            IEnumerable<Produto> produtosDaLoja = 
                context.Produtos.Where(p => p.Loja.Id == 1);

            IEnumerable<Produto> produtosDaLoja2 =
                context.Lojas.Find(1).Produtos;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Loja loja = context.Lojas.Find(1);
            loja.Name = "Teste update devmedia";

            Produto produto = context.Produtos.Find(3);
            produto.Nome = "Teste update DevMedia";
            produto.Loja.Name = "Update via produto";

            loja.Produtos.ForEach(p => p.Valor += p.Valor * 0.1m);

            context.SaveChanges();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Loja loja = context.Lojas.Find(2);
            //context.Lojas.Remove(loja);

            Produto produto = context.Produtos.Find(2);
            context.Produtos.Remove(produto);

            context.SaveChanges();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto()
            {
                Id = 1,
                Nome = "Teste DevMedia EntityState",
                LojaId = 1
            };


            context.Entry(produto).State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
