namespace Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRepetirSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Registrarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Logar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Message = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(409, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(409, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(409, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(409, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Repetir senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "  ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 457);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quiz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 230);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(765, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.HintForeColor = System.Drawing.Color.White;
            this.txtNome.HintText = "";
            this.txtNome.isPassword = false;
            this.txtNome.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtNome.LineIdleColor = System.Drawing.Color.White;
            this.txtNome.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtNome.LineThickness = 3;
            this.txtNome.Location = new System.Drawing.Point(413, 70);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 37);
            this.txtNome.TabIndex = 13;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.OnValueChanged += new System.EventHandler(this.txtNome_OnValueChanged);
            // 
            // txtUser
            // 
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.HintForeColor = System.Drawing.Color.White;
            this.txtUser.HintText = "";
            this.txtUser.isPassword = false;
            this.txtUser.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtUser.LineIdleColor = System.Drawing.Color.White;
            this.txtUser.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtUser.LineThickness = 3;
            this.txtUser.Location = new System.Drawing.Point(413, 146);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(296, 37);
            this.txtUser.TabIndex = 14;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.OnValueChanged += new System.EventHandler(this.txtUser_OnValueChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.HintForeColor = System.Drawing.Color.White;
            this.txtSenha.HintText = "";
            this.txtSenha.isPassword = true;
            this.txtSenha.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtSenha.LineIdleColor = System.Drawing.Color.White;
            this.txtSenha.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtSenha.LineThickness = 3;
            this.txtSenha.Location = new System.Drawing.Point(413, 227);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(296, 37);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.OnValueChanged += new System.EventHandler(this.txtSenha_OnValueChanged);
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepetirSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRepetirSenha.ForeColor = System.Drawing.Color.White;
            this.txtRepetirSenha.HintForeColor = System.Drawing.Color.White;
            this.txtRepetirSenha.HintText = "";
            this.txtRepetirSenha.isPassword = true;
            this.txtRepetirSenha.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtRepetirSenha.LineIdleColor = System.Drawing.Color.White;
            this.txtRepetirSenha.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtRepetirSenha.LineThickness = 3;
            this.txtRepetirSenha.Location = new System.Drawing.Point(413, 305);
            this.txtRepetirSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.Size = new System.Drawing.Size(296, 37);
            this.txtRepetirSenha.TabIndex = 16;
            this.txtRepetirSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepetirSenha.OnValueChanged += new System.EventHandler(this.txtRepetirSenha_OnValueChanged);
            // 
            // Registrarbtn
            // 
            this.Registrarbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Registrarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Registrarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Registrarbtn.BorderRadius = 0;
            this.Registrarbtn.ButtonText = "Registrar";
            this.Registrarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrarbtn.DisabledColor = System.Drawing.Color.Gray;
            this.Registrarbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Registrarbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Registrarbtn.Iconimage")));
            this.Registrarbtn.Iconimage_right = null;
            this.Registrarbtn.Iconimage_right_Selected = null;
            this.Registrarbtn.Iconimage_Selected = null;
            this.Registrarbtn.IconMarginLeft = 0;
            this.Registrarbtn.IconMarginRight = 0;
            this.Registrarbtn.IconRightVisible = true;
            this.Registrarbtn.IconRightZoom = 0D;
            this.Registrarbtn.IconVisible = true;
            this.Registrarbtn.IconZoom = 90D;
            this.Registrarbtn.IsTab = false;
            this.Registrarbtn.Location = new System.Drawing.Point(560, 369);
            this.Registrarbtn.Name = "Registrarbtn";
            this.Registrarbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Registrarbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Registrarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Registrarbtn.selected = false;
            this.Registrarbtn.Size = new System.Drawing.Size(149, 39);
            this.Registrarbtn.TabIndex = 17;
            this.Registrarbtn.Text = "Registrar";
            this.Registrarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registrarbtn.Textcolor = System.Drawing.Color.White;
            this.Registrarbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Logar
            // 
            this.Logar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Logar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Logar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logar.BorderRadius = 0;
            this.Logar.ButtonText = "Logar";
            this.Logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logar.DisabledColor = System.Drawing.Color.Gray;
            this.Logar.Iconcolor = System.Drawing.Color.Transparent;
            this.Logar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Logar.Iconimage")));
            this.Logar.Iconimage_right = null;
            this.Logar.Iconimage_right_Selected = null;
            this.Logar.Iconimage_Selected = null;
            this.Logar.IconMarginLeft = 0;
            this.Logar.IconMarginRight = 0;
            this.Logar.IconRightVisible = true;
            this.Logar.IconRightZoom = 0D;
            this.Logar.IconVisible = true;
            this.Logar.IconZoom = 90D;
            this.Logar.IsTab = false;
            this.Logar.Location = new System.Drawing.Point(413, 369);
            this.Logar.Name = "Logar";
            this.Logar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.Logar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.Logar.OnHoverTextColor = System.Drawing.Color.White;
            this.Logar.selected = false;
            this.Logar.Size = new System.Drawing.Size(141, 39);
            this.Logar.TabIndex = 18;
            this.Logar.Text = "Logar";
            this.Logar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logar.Textcolor = System.Drawing.Color.White;
            this.Logar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logar.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.Lime;
            this.Message.Location = new System.Drawing.Point(458, 424);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(217, 24);
            this.Message.TabIndex = 19;
            this.Message.Text = "Registrado com sucesso";
            this.Message.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(799, 457);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Logar);
            this.Controls.Add(this.Registrarbtn);
            this.Controls.Add(this.txtRepetirSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNome;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRepetirSenha;
        private Bunifu.Framework.UI.BunifuFlatButton Registrarbtn;
        private Bunifu.Framework.UI.BunifuFlatButton Logar;
        private Bunifu.Framework.UI.BunifuCustomLabel Message;
    }
}

