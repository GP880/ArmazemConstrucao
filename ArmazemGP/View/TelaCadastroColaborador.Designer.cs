namespace ArmazemGP.View
{
    partial class TelaCadastroColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroColaborador));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ttbNome = new TextBox();
            ttbEmail = new TextBox();
            ttbSenha = new TextBox();
            ttbNivelAcesso = new TextBox();
            btNGravar = new Button();
            btNLimpar = new Button();
            btNExcluir = new Button();
            btNAlterar = new Button();
            lbIdColab = new Label();
            ttbCodColab = new TextBox();
            label6 = new Label();
            tabCadastroColab = new TabControl();
            tabCadColab = new TabPage();
            label10 = new Label();
            mktContato = new MaskedTextBox();
            pctOlhoSenha = new PictureBox();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            pctFotoColab = new PictureBox();
            btNCarregarFoto = new Button();
            tabRelatColab = new TabPage();
            dgvColab = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pctSair = new PictureBox();
            tabCadastroColab.SuspendLayout();
            tabCadColab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctOlhoSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFotoColab).BeginInit();
            tabRelatColab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctSair).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(421, 118);
            label1.Name = "label1";
            label1.Size = new Size(267, 34);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Colaborador";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(16, 162);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(17, 213);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(17, 266);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 3;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(307, 162);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 4;
            label5.Text = "Nível de Acesso";
            // 
            // ttbNome
            // 
            ttbNome.Anchor = AnchorStyles.None;
            ttbNome.Location = new Point(15, 180);
            ttbNome.Name = "ttbNome";
            ttbNome.PlaceholderText = "Nome Completo";
            ttbNome.Size = new Size(210, 23);
            ttbNome.TabIndex = 1;
            ttbNome.TextAlign = HorizontalAlignment.Center;
            // 
            // ttbEmail
            // 
            ttbEmail.Anchor = AnchorStyles.None;
            ttbEmail.Location = new Point(17, 231);
            ttbEmail.Name = "ttbEmail";
            ttbEmail.PlaceholderText = "email@aqui.com";
            ttbEmail.Size = new Size(208, 23);
            ttbEmail.TabIndex = 2;
            ttbEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // ttbSenha
            // 
            ttbSenha.Anchor = AnchorStyles.None;
            ttbSenha.Location = new Point(16, 284);
            ttbSenha.Name = "ttbSenha";
            ttbSenha.PlaceholderText = "* * * * *";
            ttbSenha.Size = new Size(210, 23);
            ttbSenha.TabIndex = 3;
            ttbSenha.TextAlign = HorizontalAlignment.Center;
            ttbSenha.UseSystemPasswordChar = true;
            // 
            // ttbNivelAcesso
            // 
            ttbNivelAcesso.Anchor = AnchorStyles.None;
            ttbNivelAcesso.Location = new Point(306, 180);
            ttbNivelAcesso.Name = "ttbNivelAcesso";
            ttbNivelAcesso.PlaceholderText = "1, 2 ou 3";
            ttbNivelAcesso.Size = new Size(93, 23);
            ttbNivelAcesso.TabIndex = 4;
            ttbNivelAcesso.TextAlign = HorizontalAlignment.Center;
            // 
            // btNGravar
            // 
            btNGravar.Anchor = AnchorStyles.None;
            btNGravar.BackColor = SystemColors.GradientInactiveCaption;
            btNGravar.BackgroundImage = (Image)resources.GetObject("btNGravar.BackgroundImage");
            btNGravar.BackgroundImageLayout = ImageLayout.Stretch;
            btNGravar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNGravar.ForeColor = Color.Green;
            btNGravar.Location = new Point(467, 295);
            btNGravar.Name = "btNGravar";
            btNGravar.Size = new Size(75, 23);
            btNGravar.TabIndex = 6;
            btNGravar.Text = "Gravar";
            btNGravar.UseVisualStyleBackColor = false;
            btNGravar.Click += btNGravar_Click;
            // 
            // btNLimpar
            // 
            btNLimpar.Anchor = AnchorStyles.None;
            btNLimpar.BackColor = SystemColors.GradientInactiveCaption;
            btNLimpar.BackgroundImage = (Image)resources.GetObject("btNLimpar.BackgroundImage");
            btNLimpar.BackgroundImageLayout = ImageLayout.Stretch;
            btNLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNLimpar.ForeColor = Color.DarkOrange;
            btNLimpar.Location = new Point(306, 336);
            btNLimpar.Name = "btNLimpar";
            btNLimpar.Size = new Size(75, 23);
            btNLimpar.TabIndex = 8;
            btNLimpar.Text = "Limpar";
            btNLimpar.UseVisualStyleBackColor = false;
            btNLimpar.Click += btNLimpar_Click;
            // 
            // btNExcluir
            // 
            btNExcluir.Anchor = AnchorStyles.None;
            btNExcluir.BackColor = SystemColors.GradientInactiveCaption;
            btNExcluir.BackgroundImage = (Image)resources.GetObject("btNExcluir.BackgroundImage");
            btNExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            btNExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNExcluir.ForeColor = Color.Red;
            btNExcluir.Location = new Point(465, 336);
            btNExcluir.Name = "btNExcluir";
            btNExcluir.Size = new Size(75, 23);
            btNExcluir.TabIndex = 9;
            btNExcluir.Text = "Excluir";
            btNExcluir.UseVisualStyleBackColor = false;
            btNExcluir.Click += btNExcluir_Click;
            // 
            // btNAlterar
            // 
            btNAlterar.Anchor = AnchorStyles.None;
            btNAlterar.BackColor = SystemColors.GradientInactiveCaption;
            btNAlterar.BackgroundImage = (Image)resources.GetObject("btNAlterar.BackgroundImage");
            btNAlterar.BackgroundImageLayout = ImageLayout.Stretch;
            btNAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNAlterar.ForeColor = Color.Blue;
            btNAlterar.Location = new Point(307, 295);
            btNAlterar.Name = "btNAlterar";
            btNAlterar.Size = new Size(75, 23);
            btNAlterar.TabIndex = 7;
            btNAlterar.Text = "Alterar";
            btNAlterar.UseVisualStyleBackColor = false;
            btNAlterar.Click += btNAlterar_Click;
            // 
            // lbIdColab
            // 
            lbIdColab.AutoSize = true;
            lbIdColab.Location = new Point(203, 185);
            lbIdColab.Name = "lbIdColab";
            lbIdColab.Size = new Size(0, 15);
            lbIdColab.TabIndex = 15;
            // 
            // ttbCodColab
            // 
            ttbCodColab.Anchor = AnchorStyles.None;
            ttbCodColab.Location = new Point(412, 180);
            ttbCodColab.Name = "ttbCodColab";
            ttbCodColab.PlaceholderText = "\"0\" zero P/ Novo";
            ttbCodColab.Size = new Size(128, 23);
            ttbCodColab.TabIndex = 5;
            ttbCodColab.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(412, 162);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 17;
            label6.Text = "Código Vendedor";
            // 
            // tabCadastroColab
            // 
            tabCadastroColab.Anchor = AnchorStyles.None;
            tabCadastroColab.Controls.Add(tabCadColab);
            tabCadastroColab.Controls.Add(tabRelatColab);
            tabCadastroColab.Location = new Point(263, 153);
            tabCadastroColab.Name = "tabCadastroColab";
            tabCadastroColab.SelectedIndex = 0;
            tabCadastroColab.Size = new Size(570, 416);
            tabCadastroColab.TabIndex = 18;
            // 
            // tabCadColab
            // 
            tabCadColab.BackgroundImage = (Image)resources.GetObject("tabCadColab.BackgroundImage");
            tabCadColab.BackgroundImageLayout = ImageLayout.Stretch;
            tabCadColab.BorderStyle = BorderStyle.Fixed3D;
            tabCadColab.Controls.Add(label10);
            tabCadColab.Controls.Add(mktContato);
            tabCadColab.Controls.Add(pctOlhoSenha);
            tabCadColab.Controls.Add(ttbNome);
            tabCadColab.Controls.Add(label2);
            tabCadColab.Controls.Add(label3);
            tabCadColab.Controls.Add(label4);
            tabCadColab.Controls.Add(ttbEmail);
            tabCadColab.Controls.Add(ttbSenha);
            tabCadColab.Controls.Add(pictureBox4);
            tabCadColab.Controls.Add(label9);
            tabCadColab.Controls.Add(label8);
            tabCadColab.Controls.Add(label7);
            tabCadColab.Controls.Add(label6);
            tabCadColab.Controls.Add(ttbCodColab);
            tabCadColab.Controls.Add(btNAlterar);
            tabCadColab.Controls.Add(btNExcluir);
            tabCadColab.Controls.Add(btNLimpar);
            tabCadColab.Controls.Add(label5);
            tabCadColab.Controls.Add(btNGravar);
            tabCadColab.Controls.Add(ttbNivelAcesso);
            tabCadColab.Controls.Add(pictureBox3);
            tabCadColab.Controls.Add(pctFotoColab);
            tabCadColab.Controls.Add(btNCarregarFoto);
            tabCadColab.Controls.Add(lbIdColab);
            tabCadColab.Location = new Point(4, 24);
            tabCadColab.Name = "tabCadColab";
            tabCadColab.Padding = new Padding(3);
            tabCadColab.Size = new Size(562, 388);
            tabCadColab.TabIndex = 0;
            tabCadColab.Text = "Cadastro";
            tabCadColab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = SystemColors.GradientInactiveCaption;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(17, 316);
            label10.Name = "label10";
            label10.Size = new Size(52, 17);
            label10.TabIndex = 29;
            label10.Text = "Contato";
            // 
            // mktContato
            // 
            mktContato.Location = new Point(17, 336);
            mktContato.Mask = "(00)00000-0000";
            mktContato.Name = "mktContato";
            mktContato.Size = new Size(208, 23);
            mktContato.TabIndex = 22;
            // 
            // pctOlhoSenha
            // 
            pctOlhoSenha.Anchor = AnchorStyles.None;
            pctOlhoSenha.BackColor = SystemColors.GradientInactiveCaption;
            pctOlhoSenha.BackgroundImageLayout = ImageLayout.Stretch;
            pctOlhoSenha.BorderStyle = BorderStyle.Fixed3D;
            pctOlhoSenha.Image = (Image)resources.GetObject("pctOlhoSenha.Image");
            pctOlhoSenha.Location = new Point(232, 285);
            pctOlhoSenha.Name = "pctOlhoSenha";
            pctOlhoSenha.Size = new Size(22, 20);
            pctOlhoSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            pctOlhoSenha.TabIndex = 25;
            pctOlhoSenha.TabStop = false;
            pctOlhoSenha.Click += pctOlhoSenha_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(6, 136);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(256, 234);
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientInactiveCaption;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(306, 259);
            label9.Name = "label9";
            label9.Size = new Size(206, 17);
            label9.TabIndex = 20;
            label9.Text = "Nível 3: acesso ao módulo de vendas.";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(306, 235);
            label8.Name = "label8";
            label8.Size = new Size(127, 17);
            label8.TabIndex = 19;
            label8.Text = "Nível 2: acesso parcial.";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(307, 211);
            label7.Name = "label7";
            label7.Size = new Size(116, 17);
            label7.TabIndex = 18;
            label7.Text = "Nível 1: acesso total.";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(297, 136);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(255, 234);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pctFotoColab
            // 
            pctFotoColab.Anchor = AnchorStyles.None;
            pctFotoColab.BackgroundImageLayout = ImageLayout.Stretch;
            pctFotoColab.BorderStyle = BorderStyle.Fixed3D;
            pctFotoColab.Image = (Image)resources.GetObject("pctFotoColab.Image");
            pctFotoColab.Location = new Point(91, 13);
            pctFotoColab.Name = "pctFotoColab";
            pctFotoColab.Size = new Size(84, 87);
            pctFotoColab.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFotoColab.TabIndex = 26;
            pctFotoColab.TabStop = false;
            // 
            // btNCarregarFoto
            // 
            btNCarregarFoto.Anchor = AnchorStyles.None;
            btNCarregarFoto.BackColor = SystemColors.GradientInactiveCaption;
            btNCarregarFoto.BackgroundImage = (Image)resources.GetObject("btNCarregarFoto.BackgroundImage");
            btNCarregarFoto.BackgroundImageLayout = ImageLayout.Stretch;
            btNCarregarFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNCarregarFoto.ForeColor = Color.Sienna;
            btNCarregarFoto.Location = new Point(91, 106);
            btNCarregarFoto.Name = "btNCarregarFoto";
            btNCarregarFoto.Size = new Size(84, 23);
            btNCarregarFoto.TabIndex = 24;
            btNCarregarFoto.Text = "Inserir Foto";
            btNCarregarFoto.UseVisualStyleBackColor = true;
            btNCarregarFoto.Click += btNCarregarFoto_Click;
            // 
            // tabRelatColab
            // 
            tabRelatColab.Controls.Add(dgvColab);
            tabRelatColab.Location = new Point(4, 24);
            tabRelatColab.Name = "tabRelatColab";
            tabRelatColab.Padding = new Padding(3);
            tabRelatColab.Size = new Size(562, 388);
            tabRelatColab.TabIndex = 1;
            tabRelatColab.Text = "Relatório";
            tabRelatColab.UseVisualStyleBackColor = true;
            // 
            // dgvColab
            // 
            dgvColab.Anchor = AnchorStyles.None;
            dgvColab.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvColab.BorderStyle = BorderStyle.Fixed3D;
            dgvColab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColab.Location = new Point(0, 0);
            dgvColab.Name = "dgvColab";
            dgvColab.ReadOnly = true;
            dgvColab.RowTemplate.Height = 25;
            dgvColab.Size = new Size(563, 388);
            dgvColab.TabIndex = 10;
            dgvColab.CellContentClick += dgvColab_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1102, 619);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(508, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pctSair
            // 
            pctSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pctSair.BorderStyle = BorderStyle.Fixed3D;
            pctSair.Image = (Image)resources.GetObject("pctSair.Image");
            pctSair.Location = new Point(1058, 578);
            pctSair.Name = "pctSair";
            pctSair.Size = new Size(32, 29);
            pctSair.SizeMode = PictureBoxSizeMode.StretchImage;
            pctSair.TabIndex = 52;
            pctSair.TabStop = false;
            pctSair.Click += pctSair_Click;
            // 
            // TelaCadastroColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 619);
            Controls.Add(pctSair);
            Controls.Add(pictureBox2);
            Controls.Add(tabCadastroColab);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadastroColaborador";
            Text = "TelaCadastroColaborador";
            WindowState = FormWindowState.Maximized;
            tabCadastroColab.ResumeLayout(false);
            tabCadColab.ResumeLayout(false);
            tabCadColab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctOlhoSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctFotoColab).EndInit();
            tabRelatColab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvColab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ttbNome;
        private TextBox ttbEmail;
        private TextBox ttbSenha;
        private TextBox ttbNivelAcesso;
        private Button btNGravar;
        private Button btNLimpar;
        private Button btNExcluir;
        private Button btNAlterar;
        private Label lbIdColab;
        private TextBox ttbCodColab;
        private Label label6;
        private TabControl tabCadastroColab;
        private TabPage tabCadColab;
        private TabPage tabRelatColab;
        private DataGridView dgvColab;
        private Label label9;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btNCarregarFoto;
        private PictureBox pctOlhoSenha;
        private PictureBox pctFotoColab;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label10;
        private MaskedTextBox mktContato;
        private PictureBox pctSair;
    }
}