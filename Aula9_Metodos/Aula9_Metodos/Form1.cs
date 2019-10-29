using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula9_Metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region meu metodos

        private void somar()
        {
            int n1, n2, result;
            n1 = Convert.ToInt16(txtValor1.Text);
            n2 = Convert.ToInt16(txtValor2.Text);
            result = n1 + n2;
            MessageBox.Show(n1 + "+" + n2 + "=" + result);



        }
        private void multiplicar(int fator1, int fator2) 
        {
            int produto;
            fator1 = int.Parse(txtValor1.Text);
            fator2 = int.Parse(txtValor2.Text);
            produto = fator1 * fator2;
            MessageBox.Show(fator1 + "*" + fator2 +  "=" + produto );


        }
        private void pitagoras() 
        {
            int num1, num2, hip, num1E, num2E;
            double soma;
            num1 = Convert.ToInt16(txtValor1.Text);
            num2 = Convert.ToInt16(txtValor2.Text);
            num1E = num1 * num1;
            num2E = num2 * num2;
            soma = num1E + num2E;
            MessageBox.Show(""+ Math.Sqrt(soma));
            
        }
        private void baskara() 
        {

        }

        private void forca()
       {
           int f, m, a;
           m = Convert.ToInt16(txtValor1.Text);
           a = Convert.ToInt16(txtValor2.Text);
           f = m * a;




       }
        
        #endregion


        // instancia do metodo somar
        private void btnSomar_Click(object sender, EventArgs e)
        {
            somar();
        }

        // instancia do metodo multiplicar
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int f1 = int.Parse(txtValor1.Text), f2 = int.Parse(txtValor2.Text);
            multiplicar(f1, f2);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pitagoras();
        
        }

        private void btnForca_Click(object sender, EventArgs e)
        {
            double m, a;
            m = double.Parse(txtValor1.Text);
            a = double.Parse(txtValor2.Text);

            //instanciando o método da classe Forca.cs
            Forca f1 = new Forca();
            f1.forcar(m,a);

            MessageBox.Show(" f "+" = "+  f1.f);

         


            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked = true) 
            {
                btnMultiplicar.Hide();
                btnForca.Hide();
                bntpitagoras.Hide();

            }
            if (radioButton2.Checked = true)
            {
                btnSomar.Hide();
                btnForca.Hide();
                bntpitagoras.Hide();
            }
            if(radioButton3.Checked = true)
            {
                btnSomar.Hide();
                btnForca.Hide();
                btnMultiplicar.Hide();
            }
            if(radioButton4.Checked = true)
            {
                btnSomar.Hide();
                btnMultiplicar.Hide();
                bntpitagoras.Hide();
                
            }



        }
        
    }
}
