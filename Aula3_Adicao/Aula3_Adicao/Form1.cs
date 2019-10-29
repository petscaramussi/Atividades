using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula3_Adicao
{

  
    public partial class Form1 : Form
    {

        Double num1, num2, resultado;

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

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            resultado = num1 + num2;
            label3.Text = resultado.ToString();
            
            
            
            
           

             }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            label3.Text = string.Empty;
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
   
    }
}
