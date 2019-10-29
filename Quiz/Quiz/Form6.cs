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
    public partial class Form6 : Form
    {
        int result1;
        public Form6(int result)
        {
            InitializeComponent();
            result1 = result;
        }



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Selecione uma alternativa", "Atenção");
            }
            else
            {
                if (radioButton1.Checked == true) { result1++; }
                Form7 form7 = new Form7(result1); 
                form7.Show();
                this.Hide();
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
