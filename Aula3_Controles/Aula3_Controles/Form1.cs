using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula3_Controles
{
    public partial class Form1 : Form
    {
        string texto;
        public Form1()
        {
            
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void Bnt_copiar_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            label2.Text = texto;
            label2.ForeColor = Color.Red;
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //label2.Text="";
            label2.Text = string.Empty;
        }

        private void txt_mostrar_TextChanged(object sender, EventArgs e)
        {
           
            txt_mostrar.Text = texto;
        }

        


    }
}
