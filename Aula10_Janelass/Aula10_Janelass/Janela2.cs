﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula10_Janelass
{
    public partial class Janela2 : Form
    {
        public Janela2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Janela1 J1 = new Janela1();
            J1.Show();
            this.Hide();
        }
    }
}
