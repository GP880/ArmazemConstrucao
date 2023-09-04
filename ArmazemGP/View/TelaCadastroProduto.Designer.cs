namespace ArmazemGP.View
{
    partial class TelaCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroProduto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ttbNomeProd = new TextBox();
            ttbCodProd = new TextBox();
            btNGravar = new Button();
            btNAlterar = new Button();
            btNExcluir = new Button();
            ttbPreco = new TextBox();
            dgvProd = new DataGridView();
            btNTransport = new Button();
            btNLimpar = new Button();
            label6 = new Label();
            lbIdProd = new Label();
            ttbNomeFanta = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pctFotoProd = new PictureBox();
            btNFotoProd = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            pctSair = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctFotoProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            label1.Location = new Point(244, 72);
            label1.Name = "label1";
            label1.Size = new Size(264, 34);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(253, 272);
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
            label3.Location = new Point(253, 376);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 2;
            label3.Text = "Código";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(412, 376);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 3;
            label4.Text = "Preço";
            // 
            // ttbNomeProd
            // 
            ttbNomeProd.Anchor = AnchorStyles.None;
            ttbNomeProd.Location = new Point(253, 290);
            ttbNomeProd.Name = "ttbNomeProd";
            ttbNomeProd.Size = new Size(246, 23);
            ttbNomeProd.TabIndex = 6;
            // 
            // ttbCodProd
            // 
            ttbCodProd.Anchor = AnchorStyles.None;
            ttbCodProd.Location = new Point(253, 394);
            ttbCodProd.Name = "ttbCodProd";
            ttbCodProd.Size = new Size(153, 23);
            ttbCodProd.TabIndex = 7;
            // 
            // btNGravar
            // 
            btNGravar.Anchor = AnchorStyles.None;
            btNGravar.BackColor = SystemColors.GradientInactiveCaption;
            btNGravar.BackgroundImage = (Image)resources.GetObject("btNGravar.BackgroundImage");
            btNGravar.BackgroundImageLayout = ImageLayout.Stretch;
            btNGravar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNGravar.ForeColor = Color.Green;
            btNGravar.Location = new Point(424, 458);
            btNGravar.Name = "btNGravar";
            btNGravar.Size = new Size(75, 23);
            btNGravar.TabIndex = 12;
            btNGravar.Text = "Gravar";
            btNGravar.UseVisualStyleBackColor = false;
            btNGravar.Click += btNGravar_Click;
            // 
            // btNAlterar
            // 
            btNAlterar.Anchor = AnchorStyles.None;
            btNAlterar.BackColor = SystemColors.GradientInactiveCaption;
            btNAlterar.BackgroundImage = (Image)resources.GetObject("btNAlterar.BackgroundImage");
            btNAlterar.BackgroundImageLayout = ImageLayout.Stretch;
            btNAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNAlterar.ForeColor = Color.Blue;
            btNAlterar.Location = new Point(253, 458);
            btNAlterar.Name = "btNAlterar";
            btNAlterar.Size = new Size(75, 23);
            btNAlterar.TabIndex = 13;
            btNAlterar.Text = "Alterar";
            btNAlterar.UseVisualStyleBackColor = false;
            btNAlterar.Click += btNAlterar_Click;
            // 
            // btNExcluir
            // 
            btNExcluir.Anchor = AnchorStyles.None;
            btNExcluir.BackColor = SystemColors.GradientInactiveCaption;
            btNExcluir.BackgroundImage = (Image)resources.GetObject("btNExcluir.BackgroundImage");
            btNExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            btNExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNExcluir.ForeColor = Color.Red;
            btNExcluir.Location = new Point(424, 487);
            btNExcluir.Name = "btNExcluir";
            btNExcluir.Size = new Size(75, 23);
            btNExcluir.TabIndex = 14;
            btNExcluir.Text = "Excluir";
            btNExcluir.UseVisualStyleBackColor = false;
            btNExcluir.Click += btNExcluir_Click;
            // 
            // ttbPreco
            // 
            ttbPreco.Anchor = AnchorStyles.None;
            ttbPreco.Location = new Point(412, 394);
            ttbPreco.Name = "ttbPreco";
            ttbPreco.Size = new Size(87, 23);
            ttbPreco.TabIndex = 15;
            // 
            // dgvProd
            // 
            dgvProd.Anchor = AnchorStyles.None;
            dgvProd.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvProd.BorderStyle = BorderStyle.Fixed3D;
            dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProd.Location = new Point(540, 262);
            dgvProd.Name = "dgvProd";
            dgvProd.ReadOnly = true;
            dgvProd.RowTemplate.Height = 25;
            dgvProd.Size = new Size(364, 257);
            dgvProd.TabIndex = 18;
            // 
            // btNTransport
            // 
            btNTransport.Anchor = AnchorStyles.None;
            btNTransport.BackColor = SystemColors.GradientInactiveCaption;
            btNTransport.BackgroundImage = (Image)resources.GetObject("btNTransport.BackgroundImage");
            btNTransport.BackgroundImageLayout = ImageLayout.Stretch;
            btNTransport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNTransport.ForeColor = Color.Blue;
            btNTransport.Location = new Point(666, 233);
            btNTransport.Name = "btNTransport";
            btNTransport.Size = new Size(113, 23);
            btNTransport.TabIndex = 19;
            btNTransport.Text = "Transportar";
            btNTransport.UseVisualStyleBackColor = false;
            btNTransport.Click += btNTransport_Click;
            // 
            // btNLimpar
            // 
            btNLimpar.Anchor = AnchorStyles.None;
            btNLimpar.BackColor = SystemColors.GradientInactiveCaption;
            btNLimpar.BackgroundImage = (Image)resources.GetObject("btNLimpar.BackgroundImage");
            btNLimpar.BackgroundImageLayout = ImageLayout.Stretch;
            btNLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNLimpar.ForeColor = Color.DarkOrange;
            btNLimpar.Location = new Point(253, 487);
            btNLimpar.Name = "btNLimpar";
            btNLimpar.Size = new Size(75, 23);
            btNLimpar.TabIndex = 20;
            btNLimpar.Text = "Limpar";
            btNLimpar.UseVisualStyleBackColor = false;
            btNLimpar.Click += btNLimpar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(255, 426);
            label6.Name = "label6";
            label6.Size = new Size(244, 17);
            label6.TabIndex = 21;
            label6.Text = "Para Alterar ou Excluir Clique em Transportar";
            // 
            // lbIdProd
            // 
            lbIdProd.Anchor = AnchorStyles.None;
            lbIdProd.AutoSize = true;
            lbIdProd.Location = new Point(302, 379);
            lbIdProd.Name = "lbIdProd";
            lbIdProd.Size = new Size(0, 15);
            lbIdProd.TabIndex = 22;
            // 
            // ttbNomeFanta
            // 
            ttbNomeFanta.Anchor = AnchorStyles.None;
            ttbNomeFanta.Location = new Point(253, 343);
            ttbNomeFanta.Name = "ttbNomeFanta";
            ttbNomeFanta.Size = new Size(246, 23);
            ttbNomeFanta.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(255, 322);
            label5.Name = "label5";
            label5.Size = new Size(165, 17);
            label5.TabIndex = 26;
            label5.Text = "Fornecedor   [Nome Fantasia]";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1086, 580);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(540, 72);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(364, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pctFotoProd
            // 
            pctFotoProd.Anchor = AnchorStyles.None;
            pctFotoProd.BackgroundImageLayout = ImageLayout.Stretch;
            pctFotoProd.BorderStyle = BorderStyle.Fixed3D;
            pctFotoProd.Image = (Image)resources.GetObject("pctFotoProd.Image");
            pctFotoProd.Location = new Point(244, 110);
            pctFotoProd.Name = "pctFotoProd";
            pctFotoProd.Size = new Size(264, 117);
            pctFotoProd.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFotoProd.TabIndex = 30;
            pctFotoProd.TabStop = false;
            // 
            // btNFotoProd
            // 
            btNFotoProd.Anchor = AnchorStyles.None;
            btNFotoProd.BackColor = SystemColors.GradientInactiveCaption;
            btNFotoProd.BackgroundImage = (Image)resources.GetObject("btNFotoProd.BackgroundImage");
            btNFotoProd.BackgroundImageLayout = ImageLayout.Stretch;
            btNFotoProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNFotoProd.Location = new Point(319, 233);
            btNFotoProd.Name = "btNFotoProd";
            btNFotoProd.Size = new Size(113, 23);
            btNFotoProd.TabIndex = 31;
            btNFotoProd.Text = "Carregar Imagem";
            btNFotoProd.UseVisualStyleBackColor = false;
            btNFotoProd.Click += btNFotoProd_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(235, 262);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(282, 257);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(217, 58);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(708, 474);
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(308, 376);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 34;
            label7.Text = "\"0\" p/ Novo";
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
            // TelaCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 580);
            Controls.Add(pctSair);
            Controls.Add(label7);
            Controls.Add(btNLimpar);
            Controls.Add(btNExcluir);
            Controls.Add(btNAlterar);
            Controls.Add(btNGravar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ttbNomeFanta);
            Controls.Add(ttbPreco);
            Controls.Add(ttbCodProd);
            Controls.Add(ttbNomeProd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pctFotoProd);
            Controls.Add(btNFotoProd);
            Controls.Add(pictureBox2);
            Controls.Add(btNTransport);
            Controls.Add(dgvProd);
            Controls.Add(label1);
            Controls.Add(lbIdProd);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadastroProduto";
            Text = "TelaCadastroProduto";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctFotoProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ttbNomeProd;
        private TextBox ttbCodProd;
        private Button btNGravar;
        private Button btNAlterar;
        private Button btNExcluir;
        private TextBox ttbPreco;
        private DataGridView dgvProd;
        private Button btNTransport;
        private Button btNLimpar;
        private Label label6;
        private Label lbIdProd;
        private TextBox ttbNomeFanta;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pctFotoProd;
        private Button btNFotoProd;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label7;
        private PictureBox pctSair;
    }
}