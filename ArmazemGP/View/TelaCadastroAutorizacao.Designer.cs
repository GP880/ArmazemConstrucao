namespace ArmazemGP.View
{
    partial class TelaCadastroAutorizacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroAutorizacao));
            label1 = new Label();
            btNCriarGravar = new Button();
            label2 = new Label();
            label3 = new Label();
            ttbLogin = new TextBox();
            ttbSenha = new TextBox();
            btNExcluir = new Button();
            dgvAuto = new DataGridView();
            btNLimpar = new Button();
            lbAuto = new Label();
            lbAutRefePCarregarDgv = new Label();
            tabAutorizacao = new TabControl();
            tabCadastrar = new TabPage();
            tabRelatAutori = new TabPage();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pctSair = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAuto).BeginInit();
            tabAutorizacao.SuspendLayout();
            tabCadastrar.SuspendLayout();
            tabRelatAutori.SuspendLayout();
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
            label1.Location = new Point(417, 138);
            label1.Name = "label1";
            label1.Size = new Size(283, 34);
            label1.TabIndex = 0;
            label1.Text = "Criar Nova Autorização";
            // 
            // btNCriarGravar
            // 
            btNCriarGravar.Anchor = AnchorStyles.None;
            btNCriarGravar.BackColor = SystemColors.GradientInactiveCaption;
            btNCriarGravar.BackgroundImage = (Image)resources.GetObject("btNCriarGravar.BackgroundImage");
            btNCriarGravar.BackgroundImageLayout = ImageLayout.Stretch;
            btNCriarGravar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNCriarGravar.ForeColor = Color.Green;
            btNCriarGravar.Location = new Point(236, 204);
            btNCriarGravar.Name = "btNCriarGravar";
            btNCriarGravar.Size = new Size(75, 23);
            btNCriarGravar.TabIndex = 3;
            btNCriarGravar.Text = "Criar";
            btNCriarGravar.UseVisualStyleBackColor = false;
            btNCriarGravar.Click += btNCriarGravar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(60, 64);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(58, 128);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // ttbLogin
            // 
            ttbLogin.Anchor = AnchorStyles.None;
            ttbLogin.Location = new Point(58, 82);
            ttbLogin.Name = "ttbLogin";
            ttbLogin.PlaceholderText = "email@aqui.com";
            ttbLogin.Size = new Size(254, 23);
            ttbLogin.TabIndex = 1;
            ttbLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // ttbSenha
            // 
            ttbSenha.Anchor = AnchorStyles.None;
            ttbSenha.Location = new Point(58, 146);
            ttbSenha.Name = "ttbSenha";
            ttbSenha.PlaceholderText = "* * * * *";
            ttbSenha.Size = new Size(254, 23);
            ttbSenha.TabIndex = 2;
            ttbSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // btNExcluir
            // 
            btNExcluir.Anchor = AnchorStyles.None;
            btNExcluir.BackColor = SystemColors.GradientInactiveCaption;
            btNExcluir.BackgroundImage = (Image)resources.GetObject("btNExcluir.BackgroundImage");
            btNExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            btNExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNExcluir.ForeColor = Color.Red;
            btNExcluir.Location = new Point(58, 204);
            btNExcluir.Name = "btNExcluir";
            btNExcluir.Size = new Size(75, 23);
            btNExcluir.TabIndex = 5;
            btNExcluir.Text = "Excluir";
            btNExcluir.UseVisualStyleBackColor = false;
            btNExcluir.Click += btNExcluir_Click;
            // 
            // dgvAuto
            // 
            dgvAuto.Anchor = AnchorStyles.None;
            dgvAuto.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvAuto.BorderStyle = BorderStyle.Fixed3D;
            dgvAuto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuto.Location = new Point(0, 0);
            dgvAuto.Name = "dgvAuto";
            dgvAuto.ReadOnly = true;
            dgvAuto.RowTemplate.Height = 25;
            dgvAuto.Size = new Size(381, 303);
            dgvAuto.TabIndex = 7;
            dgvAuto.CellClick += dgvAuto_CellContentClick;
            dgvAuto.CellDoubleClick += dgvAuto_CellContentClick;
            // 
            // btNLimpar
            // 
            btNLimpar.Anchor = AnchorStyles.None;
            btNLimpar.BackColor = SystemColors.GradientInactiveCaption;
            btNLimpar.BackgroundImage = (Image)resources.GetObject("btNLimpar.BackgroundImage");
            btNLimpar.BackgroundImageLayout = ImageLayout.Stretch;
            btNLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNLimpar.ForeColor = Color.Blue;
            btNLimpar.Location = new Point(147, 204);
            btNLimpar.Name = "btNLimpar";
            btNLimpar.Size = new Size(75, 23);
            btNLimpar.TabIndex = 4;
            btNLimpar.Text = "Limpar";
            btNLimpar.UseVisualStyleBackColor = false;
            btNLimpar.Click += btNLimpar_Click;
            // 
            // lbAuto
            // 
            lbAuto.AutoSize = true;
            lbAuto.Location = new Point(285, 210);
            lbAuto.Name = "lbAuto";
            lbAuto.Size = new Size(0, 15);
            lbAuto.TabIndex = 10;
            // 
            // lbAutRefePCarregarDgv
            // 
            lbAutRefePCarregarDgv.AutoSize = true;
            lbAutRefePCarregarDgv.Location = new Point(624, 329);
            lbAutRefePCarregarDgv.Name = "lbAutRefePCarregarDgv";
            lbAutRefePCarregarDgv.Size = new Size(0, 15);
            lbAutRefePCarregarDgv.TabIndex = 12;
            // 
            // tabAutorizacao
            // 
            tabAutorizacao.Anchor = AnchorStyles.None;
            tabAutorizacao.Controls.Add(tabCadastrar);
            tabAutorizacao.Controls.Add(tabRelatAutori);
            tabAutorizacao.Location = new Point(353, 195);
            tabAutorizacao.Name = "tabAutorizacao";
            tabAutorizacao.SelectedIndex = 0;
            tabAutorizacao.Size = new Size(389, 331);
            tabAutorizacao.TabIndex = 13;
            // 
            // tabCadastrar
            // 
            tabCadastrar.BackgroundImage = (Image)resources.GetObject("tabCadastrar.BackgroundImage");
            tabCadastrar.BackgroundImageLayout = ImageLayout.Stretch;
            tabCadastrar.BorderStyle = BorderStyle.Fixed3D;
            tabCadastrar.Controls.Add(label2);
            tabCadastrar.Controls.Add(btNCriarGravar);
            tabCadastrar.Controls.Add(label3);
            tabCadastrar.Controls.Add(lbAuto);
            tabCadastrar.Controls.Add(btNLimpar);
            tabCadastrar.Controls.Add(ttbLogin);
            tabCadastrar.Controls.Add(ttbSenha);
            tabCadastrar.Controls.Add(btNExcluir);
            tabCadastrar.Location = new Point(4, 24);
            tabCadastrar.Name = "tabCadastrar";
            tabCadastrar.Padding = new Padding(3);
            tabCadastrar.Size = new Size(381, 303);
            tabCadastrar.TabIndex = 0;
            tabCadastrar.Text = "Cadastrar";
            tabCadastrar.UseVisualStyleBackColor = true;
            // 
            // tabRelatAutori
            // 
            tabRelatAutori.Controls.Add(dgvAuto);
            tabRelatAutori.Location = new Point(4, 24);
            tabRelatAutori.Name = "tabRelatAutori";
            tabRelatAutori.Padding = new Padding(3);
            tabRelatAutori.Size = new Size(381, 303);
            tabRelatAutori.TabIndex = 1;
            tabRelatAutori.Text = "Autorizações";
            tabRelatAutori.UseVisualStyleBackColor = true;
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
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(506, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
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
            // TelaCadastroAutorizacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1102, 619);
            Controls.Add(pctSair);
            Controls.Add(pictureBox2);
            Controls.Add(tabAutorizacao);
            Controls.Add(label1);
            Controls.Add(lbAutRefePCarregarDgv);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadastroAutorizacao";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "TelaCadastroAutorizacao";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvAuto).EndInit();
            tabAutorizacao.ResumeLayout(false);
            tabCadastrar.ResumeLayout(false);
            tabCadastrar.PerformLayout();
            tabRelatAutori.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btNCriarGravar;
        private Label label2;
        private Label label3;
        private TextBox ttbLogin;
        private TextBox ttbSenha;
        private Button btNExcluir;
        private DataGridView dgvAuto;
        private Button btnTransportar;
        private Button btNLimpar;
        private Label lbAuto;
        private Label lbAutRefePCarregarDgv;
        private TabControl tabAutorizacao;
        private TabPage tabCadastrar;
        private TabPage tabRelatAutori;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pctSair;
    }
}