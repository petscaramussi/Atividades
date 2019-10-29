using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desafio._001
{
    public partial class Form1 : Form
    {
        int prim, fim , encr, limp ;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            

            prim = Convert.ToInt32(textBox1.Text);
            fim = Convert.ToInt32(textBox2.Text);
            encr = Convert.ToInt32(textBox3.Text);

            pgbValor.Minimum = prim;
            limp = prim;
            pgbValor.Maximum = fim;
            pgbValor.Value = fim;
            while (prim <= fim)
            {
                listBox1.Items.Add(prim);
                listBox1.SelectedItem = prim;
                
                prim = prim + encr;
                
            }
         
            

        }

        private void pgbValor_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "1";
            textBox2.Text = "200";
            textBox3.Text = "1";
            pgbValor.Value = limp;

        }
    }
}
