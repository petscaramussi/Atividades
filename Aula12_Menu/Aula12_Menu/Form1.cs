using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula12_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //abrir uma arquivo de texto
        private void Menu_Abrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        //mudar a fonte
        private void toolFonte_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }


        //salvar como uma arquivo de texto
        private void Menu_Salvar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo de Texto|*.txt";
            saveFileDialog1.Title = "Salve Seu Arquivo de Texto";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        //DATA no radapé
        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        //alterar a cor do texto
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }

        }
        //botão de sair
        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //sublinhar texto
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            nome_fonte = richTextBox1.Font.Name;
            tamanho_fonte = richTextBox1.Font.Size;
            richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);


        }

        //colcoar o texto em italico
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            nome_fonte = richTextBox1.Font.Name;
            tamanho_fonte = richTextBox1.Font.Size;

            richTextBox1.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
          

        }










    }
}

