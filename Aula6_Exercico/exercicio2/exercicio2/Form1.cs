using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            int n1, n2, n3;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            n3 = Convert.ToInt32(textBox3.Text);
            
            if (n1 > n2 && n1 > n3) 
            {
                label6.Text = Convert.ToString(n1);
                if (n2 < n3) { label7.Text = Convert.ToString(n2); } else { label7.Text = Convert.ToString(n3); }
            }

            if (n2 > n1 && n2 > n3) 
            {
                label6.Text = Convert.ToString(n2);
                if (n1 < n3) { label7.Text = Convert.ToString(n1); } else { label7.Text = Convert.ToString(n3); }
            }

            if (n3 > n1 && n3 > n2)
            {
                label6.Text = Convert.ToString(n3);
                if (n2 < n1) { label7.Text = Convert.ToString(n2); } else { label7.Text = Convert.ToString(n1); }
            }

            if (n1 == n2 && n1 < n3)
            {
                label6.Text = Convert.ToString(n3);
                label7.Text = Convert.ToString(n2);
            }
            if(n1 == n2 && n3 < n1)
            {
                label6.Text = Convert.ToString(n2);
                label7.Text = Convert.ToString(n3);
            }

            if (n1 == n3 && n1 < n2)
            {
                label6.Text = Convert.ToString(n2);
                label7.Text = Convert.ToString(n1);
            }
            if (n1 == n3 && n2 < n1) 
            {
                label6.Text = Convert.ToString(n1);
                label7.Text = Convert.ToString(n2);
            }

            if (n2 == n3 && n2 < n1)
            {
                label6.Text = Convert.ToString(n1);
                label7.Text = Convert.ToString(n2);
            }

            if (n2 == n3 && n1 < n2) 
            {
                label6.Text = Convert.ToString(n2);
                label7.Text = Convert.ToString(n1);
            }

            if (n1 == n2 && n2 == n3) 
            {
                label6.Text = Convert.ToString(n2);
                label7.Text = Convert.ToString(n1);
            }
            
       

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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
