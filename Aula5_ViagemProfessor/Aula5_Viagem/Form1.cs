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

        private void frmViagem_Load(object sender, EventArgs e)
        {
            // Diminuir a Largura do Form ao carregar
            this.Size = new Size(650, 500);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            chkCondicao.Checked = false;
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            // Carregar imagem se Masculino
            if (radMasculino.Checked == true)
            {
                pctSexo.Image = Properties.Resources.masculino;
            }

            //Se o usuário não selecionar o sexo
            if (radMasculino.Checked == false && radFeminino.Checked == false)
            {
                //Caixa de mensagem
                MessageBox.Show("Selecione o sexo.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                //Carregar imagem se Feminino
                if (radFeminino.Checked == true)
                {
                    pctSexo.Image = Properties.Resources.feminino;
                }
                //Verificar a Idade
                if (idade < 18)
                {
                    chkCondicao.Visible = true;
                    this.Size = new Size(650, 500);
                }
                else
                {
                    chkCondicao.Visible = false;
                    this.Size = new Size(1000, 500);
                }
            }
        }

        private void chkCondicao_CheckedChanged(object sender, EventArgs e)
        {
            //Condição para Menore de Idade
            if (chkCondicao.Checked == true)
            {
                this.Size = new Size(1000, 500);
            }
            else
            {
                this.Size = new Size(650, 500);
            }
        }

        private void radAviao_CheckedChanged(object sender, EventArgs e)
        {
            //Aéreo
            pctTransporte.Image = Properties.Resources.Avião_747;
        }

        private void radOnibus_CheckedChanged(object sender, EventArgs e)
        {
            //Aquático
            pctTransporte.Image = Properties.Resources.multabarco;
        }

        private void radNavio_CheckedChanged(object sender, EventArgs e)
        {
            //Terrestre
            pctTransporte.Image = Properties.Resources.montaria;
        }

       
    }
}
