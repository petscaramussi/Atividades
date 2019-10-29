using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula4_condicao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void verificar_Click(object sender, EventArgs e)
        {
            int num;
            
            //tratamento de erros
            if (numero.Text == "")
            {
                resultado.Text = "Insira um valor";
            }
            else
            {
                //mostrar se é Positixo/Negativo

                num = int.Parse(numero.Text);
                
                if (num > 0)
                {
                    resultado.Text = "Positivo";
                    pictureBox1.Image = Properties.Resources.maoverde;
                }
                if (num < 0)
                {
                    resultado.Text = "Negativo";
                    pictureBox1.Image = Properties.Resources.maovermelha_286x300;
                }
                if (num == 0)
                {
                    resultado.Text = "Neutro (0)";
                }
            }
        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            numero.Text = string.Empty;
            resultado.Text = string.Empty;

            numero.Focus();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
