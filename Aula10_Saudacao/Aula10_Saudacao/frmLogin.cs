using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula10_Saudacao
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = textBox1.Text;
            senha = textBox2.Text;


          



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
