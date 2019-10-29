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
    public partial class Form10 : Form
    {
        int result1;
        public Form10(int result)
        {
            InitializeComponent();
            result1 = result;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Selecione uma alternativa", "Atenção");
            }
            else
            {
                if(radioButton4.Checked == true) { result1++; }
                Form11 form11 = new Form11(result1);  
                form11.Show();
                this.Hide();
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
