using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula8Laços
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sequencia de 1 até 10 
            for (int i = 1; i < 11; i++) 
            {
                lstFor.Items.Add(i);
                lstFor.SelectedItem = i;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1 té 100(while)
            int cont = 1;
            while(cont <= 100){
                lstWhile.Items.Add(cont);
                lstWhile.SelectedItem = cont;
                cont++;
                

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1 té 1000
            int num = 1;
            pgbDoWhile.Minimum = 1;
            pgbDoWhile.Maximum = 1000;
            do
            {
                lstDoWhile.Items.Add(num);
                lstDoWhile.SelectedItem = num;
                pgbDoWhile.Value = num;
                num++;

            }
            while (num <= 1000);


        }
    }
}
