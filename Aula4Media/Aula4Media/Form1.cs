using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula4Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrequencia_TextChanged(object sender, EventArgs e)
        {

        }
        private void status_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, freq, media;
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            freq = Convert.ToDouble(txtFrequencia.Text);
            media = (nota1 + nota2) / 2;
            if (media >= 7 && freq >= 75) {
                status.Text = ("aprovado");
                }
            else if (media <= 5 || freq < 75)
            {
                status.Text = ("reprovado");
            }
            else
            {
                status.Text = ("recuperação");
            
            }
             

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

    }
}
