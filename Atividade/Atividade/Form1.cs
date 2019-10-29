using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //tratamento de erro, para caso o usuario deixe o campo em branco
                if (txtNum1.Text == "" || txttNum2.Text == "")
                {
                    MessageBox.Show("preencha os campos", "Atenção");
                    if (txtNum1.Text == "")
                    { txtNum1.Focus(); }
                    else if (txttNum2.Text == "") { txttNum2.Focus(); }

                }
                else
                {
                    //variaveis
                    double num1, num2, MR, SR, VR, DR;
                    num1 = Convert.ToDouble(txtNum1.Text);
                    num2 = Convert.ToDouble(txttNum2.Text);


                    //adição
                    if (radioButton1.Checked == true)
                    {
                        pictureBox1.Image = Properties.Resources._;
                        MR = num1 + num2;
                        MessageBox.Show(num1 + " + " + num2 + " = " + MR);
                    }
                    //subtração
                    if (radioButton2.Checked == true)
                    {
                        pictureBox1.Image = Properties.Resources.m;
                        SR = num1 - num2;
                        MessageBox.Show(num1 + " - " + num2 + " = " + SR);
                    }
                    //multiplicação
                    if (radioButton3.Checked == true)
                    {
                        pictureBox1.Image = Properties.Resources.xx;
                        VR = num1 * num2;
                        MessageBox.Show(num1 + " * " + num2 + " = " + VR);
                    }
                    //divisão
                    if (radioButton4.Checked == true)
                    {
                        //tratamento de erro, para caso o usuario faça divisão por "0"
                        if (num2 == 0) { MessageBox.Show("não é possivel dividir por 0"); }
                        else
                        {
                            pictureBox1.Image = Properties.Resources.d;
                            DR = num1 / num2;
                            MessageBox.Show(num1 + " / " + num2 + " = " + DR.ToString("f2"));
                        }
                    }








                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            //limpar
            txtNum1.Clear();
            txttNum2.Clear();
            pictureBox1.Image = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;


            txtNum1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txttNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

       
    }
}
