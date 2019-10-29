namespace Quiz
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MsgLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bntLogar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageLogin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgLogin
            // 
            this.MsgLogin.AutoSize = true;
            this.MsgLogin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLogin.Location = new System.Drawing.Point(28, 253);
            this.MsgLogin.Name = "MsgLogin";
            this.MsgLogin.Size = new System.Drawing.Size(18, 28);
            this.MsgLogin.TabIndex = 6;
            this.MsgLogin.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 457);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 229);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quiz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // PLogin
            // 
            this.PLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PLogin.ForeColor = System.Drawing.Color.White;
            this.PLogin.HintForeColor = System.Drawing.Color.White;
            this.PLogin.HintText = "";
            this.PLogin.isPassword = false;
            this.PLogin.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.PLogin.LineIdleColor = System.Drawing.Color.White;
            this.PLogin.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.PLogin.LineThickness = 3;
            this.PLogin.Location = new System.Drawing.Point(436, 112);
            this.PLogin.Margin = new System.Windows.Forms.Padding(4);
            this.PLogin.Name = "PLogin";
            this.PLogin.Size = new System.Drawing.Size(270, 44);
            this.PLogin.TabIndex = 5;
            this.PLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PLogin.OnValueChanged += new System.EventHandler(this.PLogin_OnValueChanged);
            // 
            // PSenha
            // 
            this.PSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PSenha.ForeColor = System.Drawing.Color.White;
            this.PSenha.HintForeColor = System.Drawing.Color.White;
            this.PSenha.HintText = "";
            this.PSenha.isPassword = true;
            this.PSenha.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.PSenha.LineIdleColor = System.Drawing.Color.White;
            this.PSenha.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.PSenha.LineThickness = 3;
            this.PSenha.Location = new System.Drawing.Point(436, 199);
            this.PSenha.Margin = new System.Windows.Forms.Padding(4);
            this.PSenha.Name = "PSenha";
            this.PSenha.Size = new System.Drawing.Size(270, 44);
            this.PSenha.TabIndex = 9;
            this.PSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PSenha.OnValueChanged += new System.EventHandler(this.PSenha_OnValueChanged);
            // 
            // bntLogar
            // 
            this.bntLogar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bntLogar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bntLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntLogar.BorderRadius = 0;
            this.bntLogar.ButtonText = "Iniciar";
            this.bntLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLogar.DisabledColor = System.Drawing.Color.Gray;
            this.bntLogar.Iconcolor = System.Drawing.Color.Transparent;
            this.bntLogar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntLogar.Iconimage")));
            this.bntLogar.Iconimage_right = null;
            this.bntLogar.Iconimage_right_Selected = null;
            this.bntLogar.Iconimage_Selected = null;
            this.bntLogar.IconMarginLeft = 0;
            this.bntLogar.IconMarginRight = 0;
            this.bntLogar.IconRightVisible = true;
            this.bntLogar.IconRightZoom = 0D;
            this.bntLogar.IconVisible = true;
            this.bntLogar.IconZoom = 90D;
            this.bntLogar.IsTab = false;
            this.bntLogar.Location = new System.Drawing.Point(575, 284);
            this.bntLogar.Name = "bntLogar";
            this.bntLogar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bntLogar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bntLogar.OnHoverTextColor = System.Drawing.Color.White;
            this.bntLogar.selected = false;
            this.bntLogar.Size = new System.Drawing.Size(131, 48);
            this.bntLogar.TabIndex = 10;
            this.bntLogar.Text = "Iniciar";
            this.bntLogar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLogar.Textcolor = System.Drawing.Color.White;
            this.bntLogar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLogar.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bntRegistrar
            // 
            this.bntRegistrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bntRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bntRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntRegistrar.BorderRadius = 0;
            this.bntRegistrar.ButtonText = "Registrar";
            this.bntRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntRegistrar.DisabledColor = System.Drawing.Color.Gray;
            this.bntRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.bntRegistrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bntRegistrar.Iconimage")));
            this.bntRegistrar.Iconimage_right = null;
            this.bntRegistrar.Iconimage_right_Selected = null;
            this.bntRegistrar.Iconimage_Selected = null;
            this.bntRegistrar.IconMarginLeft = 0;
            this.bntRegistrar.IconMarginRight = 0;
            this.bntRegistrar.IconRightVisible = true;
            this.bntRegistrar.IconRightZoom = 0D;
            this.bntRegistrar.IconVisible = true;
            this.bntRegistrar.IconZoom = 90D;
            this.bntRegistrar.IsTab = false;
            this.bntRegistrar.Location = new System.Drawing.Point(436, 284);
            this.bntRegistrar.Name = "bntRegistrar";
            this.bntRegistrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bntRegistrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bntRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.bntRegistrar.selected = false;
            this.bntRegistrar.Size = new System.Drawing.Size(133, 48);
            this.bntRegistrar.TabIndex = 11;
            this.bntRegistrar.Text = "Registrar";
            this.bntRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntRegistrar.Textcolor = System.Drawing.Color.White;
            this.bntRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRegistrar.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(432, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senha";
            // 
            // MessageLogin
            // 
            this.MessageLogin.AutoSize = true;
            this.MessageLogin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLogin.ForeColor = System.Drawing.Color.LimeGreen;
            this.MessageLogin.Location = new System.Drawing.Point(485, 359);
            this.MessageLogin.Name = "MessageLogin";
            this.MessageLogin.Size = new System.Drawing.Size(153, 19);
            this.MessageLogin.TabIndex = 14;
            this.MessageLogin.Text = "Logado com sucesso";
            this.MessageLogin.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(751, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(783, 418);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MessageLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntRegistrar);
            this.Controls.Add(this.bntLogar);
            this.Controls.Add(this.PSenha);
            this.Controls.Add(this.PLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MsgLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MsgLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PSenha;
        private Bunifu.Framework.UI.BunifuFlatButton bntLogar;
        private Bunifu.Framework.UI.BunifuFlatButton bntRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MessageLogin;
        private System.Windows.Forms.Label label7;
    }
}