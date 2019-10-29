using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula10_Janelass
{
    public partial class Janela1 : Form
    {
        public Janela1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Janela2 F2 = new Janela2();
            F2.Show();
            this.Hide();
        }
    }
}
