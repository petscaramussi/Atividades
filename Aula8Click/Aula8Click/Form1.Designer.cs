namespace Aula8Click
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
            this.components = new System.ComponentModel.Container();
            this.btnClick = new System.Windows.Forms.Button();
            this.lstClicks = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chkAutomatico = new System.Windows.Forms.CheckBox();
            this.tmrClick = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrfechar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(77, 60);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 33);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Clique";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lstClicks
            // 
            this.lstClicks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstClicks.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClicks.FormattingEnabled = true;
            this.lstClicks.ItemHeight = 17;
            this.lstClicks.Location = new System.Drawing.Point(254, 60);
            this.lstClicks.Name = "lstClicks";
            this.lstClicks.Size = new System.Drawing.Size(302, 325);
            this.lstClicks.TabIndex = 3;
            this.lstClicks.SelectedIndexChanged += new System.EventHandler(this.lstClicks_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(77, 124);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 33);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chkAutomatico
            // 
            this.chkAutomatico.AutoSize = true;
            this.chkAutomatico.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutomatico.Location = new System.Drawing.Point(52, 247);
            this.chkAutomatico.Name = "chkAutomatico";
            this.chkAutomatico.Size = new System.Drawing.Size(118, 21);
            this.chkAutomatico.TabIndex = 4;
            this.chkAutomatico.Text = "Automatico";
            this.chkAutomatico.UseVisualStyleBackColor = true;
            this.chkAutomatico.CheckedChanged += new System.EventHandler(this.chkAutomatico_CheckedChanged);
            // 
            // tmrClick
            // 
            this.tmrClick.Interval = 600;
            this.tmrClick.Tick += new System.EventHandler(this.tmrClick_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "O programa fechara em 10 segundos";
            this.label1.Visible = false;
            // 
            // tmrfechar
            // 
            this.tmrfechar.Interval = 1000;
            this.tmrfechar.Tick += new System.EventHandler(this.tmrfechar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkAutomatico);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lstClicks);
            this.Controls.Add(this.btnClick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.ListBox lstClicks;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckBox chkAutomatico;
        private System.Windows.Forms.Timer tmrClick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrfechar;
    }
}

