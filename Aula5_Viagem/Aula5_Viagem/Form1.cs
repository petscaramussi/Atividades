using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula5_Viagem
{
    public partial class frmViagem : Form
    {
        public frmViagem()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            int idade = int.Parse(textBox2.Text);

            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Selecione o sexo", " Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

            if (radioButton1.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.Masculino;
            }
            if(radioButton2.Checked == true){
                pictureBox1.Image = Properties.Resources.Feminino;
            }
            if (idade < 18) 
            {
                checkBox1.Visible = true;

            }
            
            this.Size = new Size(900, 425);
        }

        private void frmViagem_Load(object sender, EventArgs e)
        {

        }


        private void aviao_CheckedChanged(object sender, EventArgs e)
        {
            pic2.Image = Properties.Resources.plane;
        }

        private void carro_CheckedChanged(object sender, EventArgs e)
        {
            pic2.Image = Properties.Resources.car;
        }

        private void barco_CheckedChanged(object sender, EventArgs e)
        {
            pic2.Image = Properties.Resources.ship;
        }

        private void pic2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?", "encerrando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    









    
    }
}
