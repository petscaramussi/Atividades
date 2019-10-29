namespace Aula4_condicao
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.verificar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.limpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(3, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(269, 129);
            this.title.TabIndex = 0;
            this.title.Text = "Digite um numero:\r\n\r\n\r\n";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(278, 46);
            this.numero.Multiline = true;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(29, 27);
            this.numero.TabIndex = 0;
            this.numero.TextChanged += new System.EventHandler(this.numero_TextChanged);
            // 
            // verificar
            // 
            this.verificar.BackColor = System.Drawing.Color.Blue;
            this.verificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verificar.Location = new System.Drawing.Point(197, 101);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(91, 32);
            this.verificar.TabIndex = 2;
            this.verificar.Text = "Verificar";
            this.verificar.UseVisualStyleBackColor = false;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultado.Location = new System.Drawing.Point(129, 165);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 39);
            this.resultado.TabIndex = 3;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.GreenYellow;
            this.limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.limpar.Location = new System.Drawing.Point(294, 101);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(86, 32);
            this.limpar.TabIndex = 4;
            this.limpar.Text = "Limpar\r\n";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(448, 238);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.verificar);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

