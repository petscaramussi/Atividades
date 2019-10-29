namespace Aula5_Viagem
{
    partial class frmViagem
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
            this.pctSexo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCondicao = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbTransporte = new System.Windows.Forms.GroupBox();
            this.pctTransporte = new System.Windows.Forms.PictureBox();
            this.radNavio = new System.Windows.Forms.RadioButton();
            this.radOnibus = new System.Windows.Forms.RadioButton();
            this.radAviao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctSexo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbTransporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTransporte)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSexo
            // 
            this.pctSexo.Location = new System.Drawing.Point(361, 181);
            this.pctSexo.Name = "pctSexo";
            this.pctSexo.Size = new System.Drawing.Size(174, 123);
            this.pctSexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSexo.TabIndex = 0;
            this.pctSexo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCondicao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdade);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radFeminino);
            this.groupBox1.Controls.Add(this.radMasculino);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.pctSexo);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boa Viagem Turismo";
            // 
            // chkCondicao
            // 
            this.chkCondicao.AutoSize = true;
            this.chkCondicao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCondicao.Location = new System.Drawing.Point(29, 336);
            this.chkCondicao.Name = "chkCondicao";
            this.chkCondicao.Size = new System.Drawing.Size(472, 52);
            this.chkCondicao.TabIndex = 6;
            this.chkCondicao.Text = "Concordo com as condições para menores \r\nde idade.";
            this.chkCondicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkCondicao.UseVisualStyleBackColor = true;
            this.chkCondicao.Visible = false;
            this.chkCondicao.CheckedChanged += new System.EventHandler(this.chkCondicao_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(142, 181);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(96, 48);
            this.txtIdade.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(142, 239);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(189, 65);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sexo";
            // 
            // radFeminino
            // 
            this.radFeminino.AutoSize = true;
            this.radFeminino.Location = new System.Drawing.Point(349, 130);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(186, 45);
            this.radFeminino.TabIndex = 2;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(142, 130);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(201, 45);
            this.radMasculino.TabIndex = 1;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(393, 48);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "José";
            // 
            // gpbTransporte
            // 
            this.gpbTransporte.Controls.Add(this.pctTransporte);
            this.gpbTransporte.Controls.Add(this.radNavio);
            this.gpbTransporte.Controls.Add(this.radOnibus);
            this.gpbTransporte.Controls.Add(this.radAviao);
            this.gpbTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTransporte.Location = new System.Drawing.Point(634, 30);
            this.gpbTransporte.Name = "gpbTransporte";
            this.gpbTransporte.Size = new System.Drawing.Size(341, 411);
            this.gpbTransporte.TabIndex = 2;
            this.gpbTransporte.TabStop = false;
            this.gpbTransporte.Text = "Transporte";
            // 
            // pctTransporte
            // 
            this.pctTransporte.Location = new System.Drawing.Point(50, 218);
            this.pctTransporte.Name = "pctTransporte";
            this.pctTransporte.Size = new System.Drawing.Size(259, 170);
            this.pctTransporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTransporte.TabIndex = 3;
            this.pctTransporte.TabStop = false;
            // 
            // radNavio
            // 
            this.radNavio.AutoSize = true;
            this.radNavio.Location = new System.Drawing.Point(16, 162);
            this.radNavio.Name = "radNavio";
            this.radNavio.Size = new System.Drawing.Size(152, 35);
            this.radNavio.TabIndex = 2;
            this.radNavio.TabStop = true;
            this.radNavio.Text = "Terrestre";
            this.radNavio.UseVisualStyleBackColor = true;
            this.radNavio.CheckedChanged += new System.EventHandler(this.radNavio_CheckedChanged);
            // 
            // radOnibus
            // 
            this.radOnibus.AutoSize = true;
            this.radOnibus.Location = new System.Drawing.Point(16, 111);
            this.radOnibus.Name = "radOnibus";
            this.radOnibus.Size = new System.Drawing.Size(146, 35);
            this.radOnibus.TabIndex = 1;
            this.radOnibus.TabStop = true;
            this.radOnibus.Text = "Aquático";
            this.radOnibus.UseVisualStyleBackColor = true;
            this.radOnibus.CheckedChanged += new System.EventHandler(this.radOnibus_CheckedChanged);
            // 
            // radAviao
            // 
            this.radAviao.AutoSize = true;
            this.radAviao.Location = new System.Drawing.Point(16, 60);
            this.radAviao.Name = "radAviao";
            this.radAviao.Size = new System.Drawing.Size(109, 35);
            this.radAviao.TabIndex = 0;
            this.radAviao.Text = "Aéreo";
            this.radAviao.UseVisualStyleBackColor = true;
            this.radAviao.CheckedChanged += new System.EventHandler(this.radAviao_CheckedChanged);
            // 
            // frmViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.gpbTransporte);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmViagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viagem";
            this.Load += new System.EventHandler(this.frmViagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSexo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbTransporte.ResumeLayout(false);
            this.gpbTransporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTransporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radFeminino;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox chkCondicao;
        private System.Windows.Forms.GroupBox gpbTransporte;
        private System.Windows.Forms.RadioButton radNavio;
        private System.Windows.Forms.RadioButton radOnibus;
        private System.Windows.Forms.RadioButton radAviao;
        private System.Windows.Forms.PictureBox pctTransporte;
    }
}

