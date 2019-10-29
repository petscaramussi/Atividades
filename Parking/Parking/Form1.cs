using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HoraEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinutoEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoraSaida_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinutoSaida_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            //tratamento de erro para caso o usuario deixe o campo em branco
            if (HoraEntrada.Text == "" || HoraSaida.Text == "" || MinutoEntrada.Text == "" || MinutoSaida.Text == "")
            {
                MessageBox.Show("Não deixe nenhum campo em branco.", "Atenção");
                HoraEntrada.Focus();
            }
            else
            {

                //variaveis do horario de entrada
                int horaE, minE, horaS, minS, horaF, minF, a, b;
                horaE = Convert.ToInt32(HoraEntrada.Text);
                minE = Convert.ToInt32(MinutoEntrada.Text);
                //variaveis do hoorario de saída
                horaS = Convert.ToInt32(HoraSaida.Text);
                minS = Convert.ToInt32(MinutoSaida.Text);
                //calculos
                horaF = horaS - horaE;
                minF = minS - minE;
                //condição para "juntar horas com minutos"
                if (minF < 0)
                {
                    a = horaF - 1;
                    label1.Text = Convert.ToString(a);
                    b = minF + 60;
                    label2.Text = Convert.ToString(b);
                }
                else
                {
                    //mostrar
                    label1.Text = Convert.ToString(horaF);
                    label2.Text = Convert.ToString(minF);
                }
                //valores dos pagamentos até 3 horas
                if (horaF == 0 && minF > 0 || horaF == 1 && minF == 0)
                {
                    valor.Text = "R$ 4,00";
                }
                if (horaF == 2 && minF == 0 || horaF == 1 && minF > 0)
                {
                    valor.Text = "R$ 8,00";
                }
                if (horaF == 3 && minF == 0 || horaF == 2 && minF > 0)
                {
                    valor.Text = "R$ 12,00";
                }

                //valores dos pagamentos para mais de 4 horas
                switch (horaF)
                {
                    case 4:
                        valor.Text = "R$ 13,00";
                        break;
                    case 5:
                        valor.Text = "R$ 14,00";
                        break;
                    case 6:
                        valor.Text = "R$ 15,00";
                        break;
                    case 7:
                        valor.Text = " R$ 16,00";
                        break;
                    case 8:
                        valor.Text = " R$ 17,00";
                        break;
                    case 9:
                        valor.Text = " R$ 18,00";
                        break;
                    case 10:
                        valor.Text = "R$ 19,00";
                        break;
                    case 11:
                        valor.Text = "R$ 20,00";
                        break;
                    case 12:
                        valor.Text = "R$ 21,00";
                        break;
                    case 13:
                        valor.Text = "R$ 22,00";
                        break;
                    case 14:
                        valor.Text = "R$ 23,00";
                        break;
                    case 15:
                        valor.Text = "R$ 24,00";
                        break;
                    case 16:
                        valor.Text = "R$ 25,00";
                        break;
                    case 17:
                        valor.Text = "R$ 26,00";
                        break;
                    case 18:
                        valor.Text = "R$ 27,00";
                        break;



                }
                if (horaF > 18)
                {
                    valor.Text = "ERRO, o estacioanmento só funciona das 5hrs as 23hrs";
                }
            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HoraSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void MinutoSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoraEntrada.Clear();
            HoraSaida.Clear();
            MinutoEntrada.Clear();
            MinutoSaida.Clear();
            valor.Text = "R$ 00,00";
            label1.Text = "00";
            label2.Text = "00";
            HoraEntrada.Focus();
          

        }
    }
}
