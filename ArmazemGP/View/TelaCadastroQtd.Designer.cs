namespace ArmazemGP.View
{
    partial class TelaCadastroQtd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroQtd));
            label2 = new Label();
            label3 = new Label();
            btNGravar = new Button();
            ttbQtd = new TextBox();
            cbbProd = new ComboBox();
            lbQtdEstoqueAtual = new Label();
            label4 = new Label();
            cbbQtd = new ComboBox();
            dgvProd = new DataGridView();
            dgvQtd = new DataGridView();
            lbIdProd = new Label();
            lbQtd = new Label();
            lbNome = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pctSair = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQtd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctSair).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(158, 157);
            label2.Name = "label2";
            label2.Size = new Size(126, 17);
            label2.TabIndex = 1;
            label2.Text = "Selecione um Produto";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(158, 441);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // btNGravar
            // 
            btNGravar.Anchor = AnchorStyles.None;
            btNGravar.BackColor = SystemColors.GradientInactiveCaption;
            btNGravar.BackgroundImage = (Image)resources.GetObject("btNGravar.BackgroundImage");
            btNGravar.BackgroundImageLayout = ImageLayout.Stretch;
            btNGravar.ForeColor = Color.Blue;
            btNGravar.Location = new Point(384, 460);
            btNGravar.Name = "btNGravar";
            btNGravar.Size = new Size(75, 23);
            btNGravar.TabIndex = 3;
            btNGravar.Text = "Gravar";
            btNGravar.UseVisualStyleBackColor = false;
            btNGravar.Click += btNGravar_Click;
            // 
            // ttbQtd
            // 
            ttbQtd.Anchor = AnchorStyles.None;
            ttbQtd.Location = new Point(158, 461);
            ttbQtd.Name = "ttbQtd";
            ttbQtd.PlaceholderText = "Digite a Quantidade";
            ttbQtd.Size = new Size(181, 23);
            ttbQtd.TabIndex = 4;
            // 
            // cbbProd
            // 
            cbbProd.Anchor = AnchorStyles.None;
            cbbProd.FormattingEnabled = true;
            cbbProd.Location = new Point(158, 177);
            cbbProd.Name = "cbbProd";
            cbbProd.Size = new Size(301, 23);
            cbbProd.TabIndex = 5;
            cbbProd.SelectedIndexChanged += cbbProd_SelectedIndexChanged;
            // 
            // lbQtdEstoqueAtual
            // 
            lbQtdEstoqueAtual.Anchor = AnchorStyles.None;
            lbQtdEstoqueAtual.AutoSize = true;
            lbQtdEstoqueAtual.BackColor = SystemColors.GradientInactiveCaption;
            lbQtdEstoqueAtual.BorderStyle = BorderStyle.Fixed3D;
            lbQtdEstoqueAtual.Location = new Point(278, 331);
            lbQtdEstoqueAtual.Name = "lbQtdEstoqueAtual";
            lbQtdEstoqueAtual.Size = new Size(2, 17);
            lbQtdEstoqueAtual.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(158, 331);
            label4.Name = "label4";
            label4.Size = new Size(108, 17);
            label4.TabIndex = 7;
            label4.Text = "Quantidade Atual: ";
            // 
            // cbbQtd
            // 
            cbbQtd.Anchor = AnchorStyles.None;
            cbbQtd.FormattingEnabled = true;
            cbbQtd.Location = new Point(494, 175);
            cbbQtd.Name = "cbbQtd";
            cbbQtd.Size = new Size(10, 23);
            cbbQtd.TabIndex = 8;
            // 
            // dgvProd
            // 
            dgvProd.Anchor = AnchorStyles.None;
            dgvProd.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvProd.BorderStyle = BorderStyle.Fixed3D;
            dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProd.Location = new Point(465, 177);
            dgvProd.Name = "dgvProd";
            dgvProd.ReadOnly = true;
            dgvProd.RowTemplate.Height = 25;
            dgvProd.Size = new Size(466, 306);
            dgvProd.TabIndex = 9;
            // 
            // dgvQtd
            // 
            dgvQtd.Anchor = AnchorStyles.None;
            dgvQtd.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvQtd.BorderStyle = BorderStyle.Fixed3D;
            dgvQtd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQtd.Location = new Point(546, 331);
            dgvQtd.Name = "dgvQtd";
            dgvQtd.ReadOnly = true;
            dgvQtd.RowTemplate.Height = 25;
            dgvQtd.Size = new Size(330, 150);
            dgvQtd.TabIndex = 10;
            // 
            // lbIdProd
            // 
            lbIdProd.AutoSize = true;
            lbIdProd.Location = new Point(482, 180);
            lbIdProd.Name = "lbIdProd";
            lbIdProd.Size = new Size(0, 15);
            lbIdProd.TabIndex = 11;
            // 
            // lbQtd
            // 
            lbQtd.AutoSize = true;
            lbQtd.Location = new Point(565, 410);
            lbQtd.Name = "lbQtd";
            lbQtd.Size = new Size(0, 15);
            lbQtd.TabIndex = 12;
            // 
            // lbNome
            // 
            lbNome.Anchor = AnchorStyles.None;
            lbNome.AutoSize = true;
            lbNome.Location = new Point(260, 180);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(0, 15);
            lbNome.TabIndex = 13;
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
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(416, 103);
            label5.Name = "label5";
            label5.Size = new Size(225, 34);
            label5.TabIndex = 0;
            label5.Text = "Adicionar Estoque";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(484, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
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
            // TelaCadastroQtd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 580);
            Controls.Add(pctSair);
            Controls.Add(cbbProd);
            Controls.Add(pictureBox3);
            Controls.Add(lbIdProd);
            Controls.Add(dgvProd);
            Controls.Add(label4);
            Controls.Add(lbQtdEstoqueAtual);
            Controls.Add(ttbQtd);
            Controls.Add(btNGravar);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(lbQtd);
            Controls.Add(cbbQtd);
            Controls.Add(lbNome);
            Controls.Add(dgvQtd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadastroQtd";
            Text = "TelaCadastroQtd";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQtd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button btNGravar;
        private TextBox ttbQtd;
        private ComboBox cbbProd;
        private Label lbQtdEstoqueAtual;
        private Label label4;
        private ComboBox cbbQtd;
        private DataGridView dgvProd;
        private DataGridView dgvQtd;
        private Label lbIdProd;
        private Label lbQtd;
        private Label lbNome;
        private PictureBox pictureBox1;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pctSair;
    }
}