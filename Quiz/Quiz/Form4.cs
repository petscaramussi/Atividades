using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form4 : Form
    {
        int result1;
        public Form4(int result)
        {
            InitializeComponent();
            result1 = result;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //tratamento de erro para caso o usuario n selecione nenhuma alternativa
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Selecione uma alternativa", "Atenção");
            }
            else
            {
                if(radioButton3.Checked == true) { result1++; }
                Form5 form5 = new Form5(result1);
                form5.Show();
                this.Hide();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
