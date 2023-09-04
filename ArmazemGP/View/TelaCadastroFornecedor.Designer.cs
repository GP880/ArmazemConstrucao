namespace ArmazemGP.View
{
    partial class TelaCadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroFornecedor));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ttbNomeFornec = new TextBox();
            ttbEmail = new TextBox();
            label5 = new Label();
            ttbNomeFan = new TextBox();
            label6 = new Label();
            ttbRazS = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btNGravar = new Button();
            btNLimpar = new Button();
            btNExcluir = new Button();
            btNAlterar = new Button();
            dgvFornec = new DataGridView();
            lbIdFornec = new Label();
            tabCadastroFonec = new TabControl();
            tabFornec = new TabPage();
            mktContatoPessoal = new MaskedTextBox();
            btNProximo = new Button();
            tabEmpresa = new TabPage();
            mktFixo = new MaskedTextBox();
            mktCNPJ = new MaskedTextBox();
            tabPage3 = new TabPage();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pctSair = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvFornec).BeginInit();
            tabCadastroFonec.SuspendLayout();
            tabFornec.SuspendLayout();
            tabEmpresa.SuspendLayout();
            tabPage3.SuspendLayout();
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
            label1.Location = new Point(468, 159);
            label1.Name = "label1";
            label1.Size = new Size(117, 34);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(121, 76);
            label2.Name = "label2";
            label2.Size = new Size(137, 17);
            label2.TabIndex = 1;
            label2.Text = "Nome do Representante";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(121, 126);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(121, 176);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 3;
            label4.Text = "Contato";
            // 
            // ttbNomeFornec
            // 
            ttbNomeFornec.Anchor = AnchorStyles.None;
            ttbNomeFornec.Location = new Point(121, 96);
            ttbNomeFornec.Name = "ttbNomeFornec";
            ttbNomeFornec.Size = new Size(222, 23);
            ttbNomeFornec.TabIndex = 1;
            // 
            // ttbEmail
            // 
            ttbEmail.Anchor = AnchorStyles.None;
            ttbEmail.Location = new Point(121, 144);
            ttbEmail.Name = "ttbEmail";
            ttbEmail.Size = new Size(222, 23);
            ttbEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(43, 62);
            label5.Name = "label5";
            label5.Size = new Size(152, 17);
            label5.TabIndex = 7;
            label5.Text = "Nome Fantasia da Empresa";
            // 
            // ttbNomeFan
            // 
            ttbNomeFan.Anchor = AnchorStyles.None;
            ttbNomeFan.Location = new Point(43, 80);
            ttbNomeFan.Name = "ttbNomeFan";
            ttbNomeFan.Size = new Size(222, 23);
            ttbNomeFan.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(43, 111);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 9;
            label6.Text = "Razão Social";
            // 
            // ttbRazS
            // 
            ttbRazS.Anchor = AnchorStyles.None;
            ttbRazS.Location = new Point(43, 129);
            ttbRazS.Name = "ttbRazS";
            ttbRazS.Size = new Size(222, 23);
            ttbRazS.TabIndex = 6;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(43, 164);
            label7.Name = "label7";
            label7.Size = new Size(36, 17);
            label7.TabIndex = 11;
            label7.Text = "CNPJ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(43, 216);
            label8.Name = "label8";
            label8.Size = new Size(52, 17);
            label8.TabIndex = 13;
            label8.Text = "Contato";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(121, 25);
            label9.Name = "label9";
            label9.Size = new Size(146, 34);
            label9.TabIndex = 15;
            label9.Text = "Fornecedor";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(43, 12);
            label10.Name = "label10";
            label10.Size = new Size(113, 34);
            label10.TabIndex = 16;
            label10.Text = "Empresa";
            // 
            // btNGravar
            // 
            btNGravar.Anchor = AnchorStyles.None;
            btNGravar.BackColor = SystemColors.GradientInactiveCaption;
            btNGravar.BackgroundImage = (Image)resources.GetObject("btNGravar.BackgroundImage");
            btNGravar.BackgroundImageLayout = ImageLayout.Stretch;
            btNGravar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNGravar.ForeColor = Color.Green;
            btNGravar.Location = new Point(378, 193);
            btNGravar.Name = "btNGravar";
            btNGravar.Size = new Size(75, 23);
            btNGravar.TabIndex = 9;
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
            btNLimpar.Location = new Point(285, 193);
            btNLimpar.Name = "btNLimpar";
            btNLimpar.Size = new Size(75, 23);
            btNLimpar.TabIndex = 11;
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
            btNExcluir.Location = new Point(378, 234);
            btNExcluir.Name = "btNExcluir";
            btNExcluir.Size = new Size(75, 23);
            btNExcluir.TabIndex = 12;
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
            btNAlterar.Location = new Point(285, 234);
            btNAlterar.Name = "btNAlterar";
            btNAlterar.Size = new Size(75, 23);
            btNAlterar.TabIndex = 10;
            btNAlterar.Text = "Alterar";
            btNAlterar.UseVisualStyleBackColor = false;
            btNAlterar.Click += btNAlterar_Click;
            // 
            // dgvFornec
            // 
            dgvFornec.Anchor = AnchorStyles.None;
            dgvFornec.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvFornec.BorderStyle = BorderStyle.Fixed3D;
            dgvFornec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornec.Location = new Point(0, 0);
            dgvFornec.Name = "dgvFornec";
            dgvFornec.ReadOnly = true;
            dgvFornec.RowTemplate.Height = 25;
            dgvFornec.Size = new Size(480, 267);
            dgvFornec.TabIndex = 13;
            dgvFornec.CellContentClick += dgvFornec_CellContentClick;
            // 
            // lbIdFornec
            // 
            lbIdFornec.AutoSize = true;
            lbIdFornec.Location = new Point(318, 199);
            lbIdFornec.Name = "lbIdFornec";
            lbIdFornec.Size = new Size(0, 15);
            lbIdFornec.TabIndex = 24;
            // 
            // tabCadastroFonec
            // 
            tabCadastroFonec.Anchor = AnchorStyles.None;
            tabCadastroFonec.Controls.Add(tabFornec);
            tabCadastroFonec.Controls.Add(tabEmpresa);
            tabCadastroFonec.Controls.Add(tabPage3);
            tabCadastroFonec.Location = new Point(290, 208);
            tabCadastroFonec.Name = "tabCadastroFonec";
            tabCadastroFonec.SelectedIndex = 0;
            tabCadastroFonec.Size = new Size(488, 295);
            tabCadastroFonec.TabIndex = 25;
            // 
            // tabFornec
            // 
            tabFornec.BackColor = SystemColors.GradientInactiveCaption;
            tabFornec.BackgroundImageLayout = ImageLayout.Stretch;
            tabFornec.BorderStyle = BorderStyle.Fixed3D;
            tabFornec.Controls.Add(mktContatoPessoal);
            tabFornec.Controls.Add(btNProximo);
            tabFornec.Controls.Add(label9);
            tabFornec.Controls.Add(label2);
            tabFornec.Controls.Add(label3);
            tabFornec.Controls.Add(label4);
            tabFornec.Controls.Add(ttbNomeFornec);
            tabFornec.Controls.Add(ttbEmail);
            tabFornec.Location = new Point(4, 24);
            tabFornec.Name = "tabFornec";
            tabFornec.Padding = new Padding(3);
            tabFornec.Size = new Size(480, 267);
            tabFornec.TabIndex = 0;
            tabFornec.Text = "Fornecedor";
            // 
            // mktContatoPessoal
            // 
            mktContatoPessoal.Anchor = AnchorStyles.None;
            mktContatoPessoal.Location = new Point(121, 194);
            mktContatoPessoal.Mask = "(00)00000-0000";
            mktContatoPessoal.Name = "mktContatoPessoal";
            mktContatoPessoal.Size = new Size(222, 23);
            mktContatoPessoal.TabIndex = 26;
            // 
            // btNProximo
            // 
            btNProximo.Anchor = AnchorStyles.None;
            btNProximo.BackgroundImage = (Image)resources.GetObject("btNProximo.BackgroundImage");
            btNProximo.BackgroundImageLayout = ImageLayout.Stretch;
            btNProximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNProximo.ForeColor = Color.Blue;
            btNProximo.Location = new Point(204, 223);
            btNProximo.Name = "btNProximo";
            btNProximo.Size = new Size(75, 23);
            btNProximo.TabIndex = 4;
            btNProximo.Text = "Próximo";
            btNProximo.UseVisualStyleBackColor = true;
            btNProximo.Click += btNProximo_Click;
            // 
            // tabEmpresa
            // 
            tabEmpresa.BackColor = SystemColors.GradientInactiveCaption;
            tabEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
            tabEmpresa.BorderStyle = BorderStyle.Fixed3D;
            tabEmpresa.Controls.Add(mktFixo);
            tabEmpresa.Controls.Add(mktCNPJ);
            tabEmpresa.Controls.Add(btNLimpar);
            tabEmpresa.Controls.Add(label10);
            tabEmpresa.Controls.Add(label5);
            tabEmpresa.Controls.Add(ttbNomeFan);
            tabEmpresa.Controls.Add(label6);
            tabEmpresa.Controls.Add(btNGravar);
            tabEmpresa.Controls.Add(ttbRazS);
            tabEmpresa.Controls.Add(label8);
            tabEmpresa.Controls.Add(btNAlterar);
            tabEmpresa.Controls.Add(label7);
            tabEmpresa.Controls.Add(btNExcluir);
            tabEmpresa.Controls.Add(lbIdFornec);
            tabEmpresa.Location = new Point(4, 24);
            tabEmpresa.Name = "tabEmpresa";
            tabEmpresa.Padding = new Padding(3);
            tabEmpresa.Size = new Size(480, 267);
            tabEmpresa.TabIndex = 1;
            tabEmpresa.Text = "Empresa";
            // 
            // mktFixo
            // 
            mktFixo.Anchor = AnchorStyles.None;
            mktFixo.Location = new Point(43, 234);
            mktFixo.Mask = "(00)0000-0000";
            mktFixo.Name = "mktFixo";
            mktFixo.Size = new Size(222, 23);
            mktFixo.TabIndex = 27;
            // 
            // mktCNPJ
            // 
            mktCNPJ.Anchor = AnchorStyles.None;
            mktCNPJ.Location = new Point(43, 184);
            mktCNPJ.Mask = "00,000,000,0000-00";
            mktCNPJ.Name = "mktCNPJ";
            mktCNPJ.Size = new Size(222, 23);
            mktCNPJ.TabIndex = 25;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvFornec);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(480, 267);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Relatório";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1086, 580);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(476, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // pctSair
            // 
            pctSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pctSair.BorderStyle = BorderStyle.Fixed3D;
            pctSair.Image = (Image)resources.GetObject("pctSair.Image");
            pctSair.Location = new Point(1042, 539);
            pctSair.Name = "pctSair";
            pctSair.Size = new Size(32, 29);
            pctSair.SizeMode = PictureBoxSizeMode.StretchImage;
            pctSair.TabIndex = 52;
            pctSair.TabStop = false;
            pctSair.Click += pctSair_Click;
            // 
            // TelaCadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 580);
            Controls.Add(pctSair);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(tabCadastroFonec);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadastroFornecedor";
            Text = "TelaCadastroFornecedor";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvFornec).EndInit();
            tabCadastroFonec.ResumeLayout(false);
            tabFornec.ResumeLayout(false);
            tabFornec.PerformLayout();
            tabEmpresa.ResumeLayout(false);
            tabEmpresa.PerformLayout();
            tabPage3.ResumeLayout(false);
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
        private TextBox ttbNomeFornec;
        private TextBox ttbEmail;
        private Label label5;
        private TextBox ttbNomeFan;
        private Label label6;
        private TextBox ttbRazS;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btNGravar;
        private Button btNLimpar;
        private Button btNExcluir;
        private Button btNAlterar;
        private DataGridView dgvFornec;
        private Label lbIdFornec;
        private TabControl tabCadastroFonec;
        private TabPage tabFornec;
        private TabPage tabEmpresa;
        private TabPage tabPage3;
        private Button btNProximo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MaskedTextBox mktCNPJ;
        private MaskedTextBox mktContatoPessoal;
        private MaskedTextBox mktFixo;
        private PictureBox pctSair;
    }
}