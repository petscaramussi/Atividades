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
    public partial class Form2 : Form
    {
        public string login;
        public string senha;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string l, string s)
        {
            InitializeComponent();
            login = l;
            senha = s;

        }


        



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void PLogin_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void PSenha_OnValueChanged(object sender, EventArgs e)
        {
            PSenha.isPassword = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (PLogin.Text == "" || PSenha.Text == "")
            {
                MessageBox.Show("Não deixe nenhum campo em branco", "Atenção");
            }
            if (PLogin.Text == login && PSenha.Text == senha)
            {
                MessageLogin.Text = "Logado com sucesso ";
                MessageLogin.ForeColor = System.Drawing.Color.Green;
                MessageLogin.Show();
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
            }
            else
            {
                MessageLogin.Text = "Erro ao logar";
                MessageLogin.ForeColor = System.Drawing.Color.Red;
                MessageLogin.Show();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
