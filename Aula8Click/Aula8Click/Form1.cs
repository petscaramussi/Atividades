using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula8Click
{
    public partial class Form1 : Form
    {
        int click = 0;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnClick_Click(object sender, EventArgs e)
        {
            
            click++;
            //Adicionando um valor na ListBox

                
            if (click == 1)
            {
                //singular
                lstClicks.Items.Add(click + " Clique");
            }
                
            else 
            {
                //plural
                lstClicks.Items.Add(click + " Cliques"); 
            }

            lstClicks.SelectedIndex = click-1;
        }


        private void lstClicks_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstClicks.Items.Clear();
            click = 0;
        }

        private void tmrClick_Tick(object sender, EventArgs e)
        {


            click++;
            //Adicionando um valor na ListBox


            if (click == 1)
            {
                //singular
                lstClicks.Items.Add(click + " Clique");
            }

            else
            {
                //plural
                lstClicks.Items.Add(click + " Cliques");
            }

            lstClicks.SelectedIndex = click - 1;
        }

        private void chkAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutomatico.Checked == true)
            {
                tmrClick.Enabled = true;
            }
            if (chkAutomatico.Checked == false)
            {
                tmrClick.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("deseja fechar o programa?", "atenção", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                tmrfechar.Enabled = true;

            }
            //label1.Visible = true;
            //chkAutomatico.Checked = true;
        }
        int fechar = 10;

        private void tmrfechar_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;
            fechar--;
            if (fechar < 0)
            {
                this.Close();
            }
        }
    }
}
