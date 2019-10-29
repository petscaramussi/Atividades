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
    public partial class FrmCadastro : Form
    {
        
        public FrmCadastro()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
    
            string senha, rsenha;
            senha = txtSenha.Text;
            rsenha = text.Text;
            if (senha == rsenha)
            {
                msg.Text = "Cadastrado com sucesso";
            }else
            {
                msg.Text = "ERRO na senha";

            }
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();






        }



        private void msg_Click(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
