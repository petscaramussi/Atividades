using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variaveis
           double l1, l2, l3;
            l1 = Convert.ToDouble(textBox1.Text);
            l2 = Convert.ToDouble(textBox2.Text);
            l3 = Convert.ToDouble(textBox3.Text);

            //equilatero
            if (l1 == l2 && l3 == l1 && l2 == l3   ) 
            {
                label4.Text = "triangulo equilátero";
                pictureBox1.Image = Properties.Resources.equilatero;
            }
            //isoceles
            if(l1 == l3 && l2 != l3 || l1 != l2 && l3 == l2 || l1 != l3 && l2 == l1 )
            {
                label4.Text = "triangulo isoceles";
                pictureBox1.Image = Properties.Resources.isoceles;
            }
            //escaleno
            if(l1 != l2 && l3 != l1 && l2 != l3)
            {
                label4.Text = "triangulo escaleno";
                pictureBox1.Image = Properties.Resources.escaleno;
            }

            //forecolor = mudar cor
            //focus() = colocar foco na textbox


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        
    }
}
