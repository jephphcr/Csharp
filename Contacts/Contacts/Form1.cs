﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List 1.0. \nWritenn by: Jefferson", "About");
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // TODO: This line of code loads data into the 'contactDBDataSet.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.contactDBDataSet.Table);
=======
>>>>>>> ea52d9a320c5b07cdb507cbf21a2a1be730c655a
            // TODO: This line of code loads data into the 'contactDBDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactDBDataSet.People);

        }

        private void peopleGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
