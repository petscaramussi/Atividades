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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sexo;
            string nome = textBox1.Text;
            if (radioButton1.Checked == true)
            {
                 sexo = "Bem Vindo Senhor ";
            }
            else 
            {
                 sexo = "Bem Vinda Senhora ";
            }

            frmSaudacao Saudacao = new frmSaudacao(nome, sexo);
            //Exibir a outra janela
            Saudacao.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
