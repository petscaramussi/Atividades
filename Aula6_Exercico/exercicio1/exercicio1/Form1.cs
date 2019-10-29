using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exercicio1
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

        private void button1_Click(object sender, EventArgs e)
        {
            double idade;
            idade = Convert.ToDouble(txtIdade.Text);
            if (idade > 4 && idade < 11)
            {
                lblCategoria.Text = ("Infantil");
            }
            if (idade > 10 && idade < 18)
            {
                lblCategoria.Text = ("Juvenil");
            }
            if (idade > 17 && idade < 60)
            {
                lblCategoria.Text = ("Adulto");
            }
            if (idade >= 60)
            {
                lblCategoria.Text = ("Senior");
            }
            if (idade < 5)
            {
                lblCategoria.Text = ("Fora da Categoria");
            }

        }
    }
}
