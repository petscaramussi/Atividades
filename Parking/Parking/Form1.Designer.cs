namespace Parking
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HoraEntrada = new System.Windows.Forms.TextBox();
            this.MinutoEntrada = new System.Windows.Forms.TextBox();
            this.HoraSaida = new System.Windows.Forms.TextBox();
            this.MinutoSaida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(18, 165);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(84, 27);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "Calcular\r\n";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraEntrada.Location = new System.Drawing.Point(196, 54);
            this.HoraEntrada.Multiline = true;
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.Size = new System.Drawing.Size(32, 27);
            this.HoraEntrada.TabIndex = 1;
            this.HoraEntrada.TextChanged += new System.EventHandler(this.HoraEntrada_TextChanged);
            this.HoraEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoraSaida_KeyPress);
            // 
            // MinutoEntrada
            // 
            this.MinutoEntrada.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutoEntrada.Location = new System.Drawing.Point(255, 54);
            this.MinutoEntrada.Multiline = true;
            this.MinutoEntrada.Name = "MinutoEntrada";
            this.MinutoEntrada.Size = new System.Drawing.Size(32, 27);
            this.MinutoEntrada.TabIndex = 2;
            this.MinutoEntrada.TextChanged += new System.EventHandler(this.MinutoEntrada_TextChanged);
            this.MinutoEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinutoSaida_KeyPress);
            // 
            // HoraSaida
            // 
            this.HoraSaida.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraSaida.Location = new System.Drawing.Point(196, 88);
            this.HoraSaida.Multiline = true;
            this.HoraSaida.Name = "HoraSaida";
            this.HoraSaida.Size = new System.Drawing.Size(32, 27);
            this.HoraSaida.TabIndex = 3;
            this.HoraSaida.TextChanged += new System.EventHandler(this.HoraSaida_TextChanged);
            this.HoraSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoraSaida_KeyPress);
            // 
            // MinutoSaida
            // 
            this.MinutoSaida.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutoSaida.Location = new System.Drawing.Point(255, 88);
            this.MinutoSaida.Multiline = true;
            this.MinutoSaida.Name = "MinutoSaida";
            this.MinutoSaida.Size = new System.Drawing.Size(32, 27);
            this.MinutoSaida.TabIndex = 4;
            this.MinutoSaida.TextChanged += new System.EventHandler(this.MinutoSaida_TextChanged);
            this.MinutoSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinutoSaida_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Horário de entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Horário de saída:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = ":";
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(167, 222);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(85, 34);
            this.valor.TabIndex = 13;
            this.valor.Text = "R$ 00,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total a pagar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinutoSaida);
            this.Controls.Add(this.HoraSaida);
            this.Controls.Add(this.MinutoEntrada);
            this.Controls.Add(this.HoraEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HoraEntrada;
        private System.Windows.Forms.TextBox MinutoEntrada;
        private System.Windows.Forms.TextBox HoraSaida;
        private System.Windows.Forms.TextBox MinutoSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

