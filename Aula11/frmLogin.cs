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
            //Instância
            FrmCadastro cadastro = new FrmCadastro();
            //condição para que o loguin de certo
            if (textBox1.Text == ) 
            {
                label4.Text = "cadastrado com sucesso...";
            }
            
            
            


       


          



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
