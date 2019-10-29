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
    public partial class frmSaudacao : Form
    {
        string nome;
        string sexo;
        public frmSaudacao(string n, string s)
        {
            sexo = s;
            nome = n;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInicio Inicio = new frmInicio();
            //voltar para a tela Inicio
            Inicio.Show();
            this.Hide();
        }

        private void frmSaudacao_Load(object sender, EventArgs e)
        {
            label1.Text = nome;
            label2.Text = sexo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer realmente fechar o programa?", "fechando o programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }






    }
}
