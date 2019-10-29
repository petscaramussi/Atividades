using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula15_GridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpar(){
            cmbTipo.Text = "selecione";
            txtValor.Clear();
            pictureBox1.Image = Properties.Resources.foto;
            foto = false;

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Adicionar produto na Gridview

            String nome, tipo;
            double valor;
          


            nome = txtNome.Text;
            tipo = cmbTipo.Text; //combobox
            valor = double.Parse(txtValor.Text);


            //Adicionar produto na Grid View

            dataGridView1.Rows.Add(nome, tipo, valor, foto);

         

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        bool foto = false;
        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (opfFoto.ShowDialog() == DialogResult.OK) {
                //carreghar foto
                pictureBox1.Image = Image.FromFile(opfFoto.FileName);

            
            }



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //excluir produto selecionado

            try { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
            catch { MessageBox.Show("Selecione uma linha de dados para excluir..."); }

            
        }

        private void lblContador_Click(object sender, EventArgs e)
        {
            
            


            
            }

        }



    }
}
