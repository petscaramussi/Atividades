using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSenha.Text == "" || txtUser.Text == "" || txtRepetirSenha.Text == "")
            {
                MessageBox.Show("Não deixe nenhum campo em branco", "Atenção");
            }
            else
            {
                if (txtSenha.Text == txtRepetirSenha.Text)
                {
                    Message.Text = "Registrado com sucesso";
                    Message.ForeColor = System.Drawing.Color.Green;
                    Message.Show();




                }
                else
                {
                    Message.Text = "Não foi possivel registrar";
                    Message.ForeColor = System.Drawing.Color.Red;
                    Message.Show();
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(txtUser.Text,txtSenha.Text);
            this.Hide();
            form.Show();
        }
        private void txtNome_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_OnValueChanged(object sender, EventArgs e)
        {
            txtSenha.isPassword = true;
        }

    

        private void txtRepetirSenha_OnValueChanged(object sender, EventArgs e)
        {
            txtRepetirSenha.isPassword = true;
        }
    }
}
