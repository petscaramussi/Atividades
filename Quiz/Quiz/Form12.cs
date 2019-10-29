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
    public partial class Form12 : Form
    {
        int result1;
        public Form12(int result)
        {
            InitializeComponent();
            result1 = result;
            label1.Text = result1.ToString();
            switch (result1)
            {
                case 1:
                    bntprogress.Value = 10;
                        break;
                case 2:
                    bntprogress.Value = 20;
                    break;
                case 3:
                    bntprogress.Value = 30;
                    break;
                case 4:
                    bntprogress.Value = 40;
                    break;
                case 5:
                    bntprogress.Value = 50;
                    break;
                case 6:
                    bntprogress.Value = 60;
                    break;
                case 7:
                    bntprogress.Value = 70;
                    break;
                case 8:
                    bntprogress.Value = 80;
                    break;
                case 9:
                    bntprogress.Value = 90;
                    break;
                case 10:
                    bntprogress.Value = 100;
                    break;

            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
