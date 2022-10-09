using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            new Person() { Name = txtName.Text, CPF = mskCPF.Text, Email = txtEmail.Text, Phone = mskPhone.Text }.Save();
            //var person = new Person() { Name = txtName.Text, CPF = mskCPF.Text, Email = txtEmail.Text, Phone = mskPhone.Text };
            //person.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var person = new Person() { Name = txtName.Text, CPF = mskCPF.Text, Email = txtEmail.Text, Phone = mskPhone.Text };
            person.Save();
            MessageBox.Show("Cadastro concluido com sucesso, o seu ID é: " + person.Id);
        }

        private void frmPessoa_Load(object sender, EventArgs e)
        {
            dgtListaClientes.DataSource = Person.List();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            dgtListaClientes.DataSource = Person.List(txtSearch.Text);
        }

        private void dgtListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var person = (Person)dgtListaClientes.Rows[e.RowIndex].DataBoundItem;
            //var id = (Int32)dgtListaClientes.Rows[e.RowIndex].Cells[0].Value;
            //MessageBox.Show(person.Id.ToString());
            tabERP.SelectedTab = tabResgistration;
            txtEmail.Text = person.Email;
            txtName.Text = person.Name;
            mskCPF.Text = person.CPF;
            mskPhone.Text = person.Phone;
            txtId.Text = person.Id.ToString();
            dgtListaClientes.DataSource = Business.Adresses.List(txtId.Text);
            
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) txtId.Text = "0";
            var person = new Person() { Id = Convert.ToInt32(txtId.Text), Name = txtName.Text, CPF = mskCPF.Text, Email = txtEmail.Text, Phone = mskPhone.Text };
            person.Save();

            if (txtId.Text == "0")
            {
                MessageBox.Show("Cadastro concluido com sucesso, o seu ID é: " + person.Id);
            }
            else
            {
                MessageBox.Show("Dado atualizado");
            }
            
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            mskCPF.Text = string.Empty;
            mskPhone.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var person = (Person)dgtListaClientes.Rows[dgtListaClientes.SelectedCells[0].RowIndex].DataBoundItem;
            MessageBox.Show(person.Id.ToString());

            var confirmResult = MessageBox.Show("Confirma ?", "Exclusão", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                person.Excluir(person.Id);
                dgtListaClientes.DataSource = Person.List(txtSearch.Text);

            }

        }

        private void testeTab_Click(object sender, EventArgs e)
        {
            tabERP.SelectedTab = tabResgistration;
        }
    }
}
