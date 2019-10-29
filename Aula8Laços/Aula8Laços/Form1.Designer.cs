namespace Aula8Laços
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstFor = new System.Windows.Forms.ListBox();
            this.lstWhile = new System.Windows.Forms.ListBox();
            this.lstDoWhile = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pgbDoWhile = new System.Windows.Forms.ProgressBar();
            this.pgbWhile = new System.Windows.Forms.ProgressBar();
            this.pgbFor = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOOPS";
            // 
            // lstFor
            // 
            this.lstFor.FormattingEnabled = true;
            this.lstFor.Location = new System.Drawing.Point(97, 160);
            this.lstFor.Name = "lstFor";
            this.lstFor.Size = new System.Drawing.Size(160, 225);
            this.lstFor.TabIndex = 1;
            // 
            // lstWhile
            // 
            this.lstWhile.FormattingEnabled = true;
            this.lstWhile.Location = new System.Drawing.Point(422, 160);
            this.lstWhile.Name = "lstWhile";
            this.lstWhile.Size = new System.Drawing.Size(160, 225);
            this.lstWhile.TabIndex = 2;
            // 
            // lstDoWhile
            // 
            this.lstDoWhile.FormattingEnabled = true;
            this.lstDoWhile.Location = new System.Drawing.Point(697, 160);
            this.lstDoWhile.Name = "lstDoWhile";
            this.lstDoWhile.Size = new System.Drawing.Size(160, 225);
            this.lstDoWhile.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(134, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "for";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(461, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "While";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(741, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Do While";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pgbDoWhile
            // 
            this.pgbDoWhile.Location = new System.Drawing.Point(700, 391);
            this.pgbDoWhile.Name = "pgbDoWhile";
            this.pgbDoWhile.Size = new System.Drawing.Size(157, 23);
            this.pgbDoWhile.TabIndex = 7;
            // 
            // pgbWhile
            // 
            this.pgbWhile.Location = new System.Drawing.Point(422, 391);
            this.pgbWhile.Name = "pgbWhile";
            this.pgbWhile.Size = new System.Drawing.Size(160, 23);
            this.pgbWhile.TabIndex = 8;
            // 
            // pgbFor
            // 
            this.pgbFor.Location = new System.Drawing.Point(97, 391);
            this.pgbFor.Name = "pgbFor";
            this.pgbFor.Size = new System.Drawing.Size(160, 23);
            this.pgbFor.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(927, 468);
            this.Controls.Add(this.pgbFor);
            this.Controls.Add(this.pgbWhile);
            this.Controls.Add(this.pgbDoWhile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDoWhile);
            this.Controls.Add(this.lstWhile);
            this.Controls.Add(this.lstFor);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFor;
        private System.Windows.Forms.ListBox lstWhile;
        private System.Windows.Forms.ListBox lstDoWhile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar pgbDoWhile;
        private System.Windows.Forms.ProgressBar pgbWhile;
        private System.Windows.Forms.ProgressBar pgbFor;
    }
}

