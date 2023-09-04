namespace ArmazemGP
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            cadastrarProdutoToolStripMenuItem = new ToolStripMenuItem();
            adicionarQtdEstoqueToolStripMenuItem = new ToolStripMenuItem();
            adicionarQtdAoEstoqueToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFornecedorToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFornecedorToolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarColaboradorToolStripMenuItem = new ToolStripMenuItem();
            cadastrarSenhaDeAutorizaçãoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarColaboradorToolStripMenuItem1 = new ToolStripMenuItem();
            pDVVenderToolStripMenuItem = new ToolStripMenuItem();
            frenteDeCaixaToolStripMenuItem = new ToolStripMenuItem();
            contasAPagarToolStripMenuItem = new ToolStripMenuItem();
            btNNotifica = new Button();
            dgvNotifica = new DataGridView();
            pictureBox2 = new PictureBox();
            pctSair = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotifica).BeginInit();
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
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(493, 534);
            label1.Name = "label1";
            label1.Size = new Size(101, 34);
            label1.TabIndex = 0;
            label1.Text = "Sistema";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarProdutoToolStripMenuItem, relatóriosToolStripMenuItem, cadastrarFornecedorToolStripMenuItem, cadastrarColaboradorToolStripMenuItem, pDVVenderToolStripMenuItem, contasAPagarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1086, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            cadastrarProdutoToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("cadastrarProdutoToolStripMenuItem.BackgroundImage");
            cadastrarProdutoToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            cadastrarProdutoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarQtdEstoqueToolStripMenuItem, adicionarQtdAoEstoqueToolStripMenuItem });
            cadastrarProdutoToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            cadastrarProdutoToolStripMenuItem.Size = new Size(119, 20);
            cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            // 
            // adicionarQtdEstoqueToolStripMenuItem
            // 
            adicionarQtdEstoqueToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("adicionarQtdEstoqueToolStripMenuItem.BackgroundImage");
            adicionarQtdEstoqueToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            adicionarQtdEstoqueToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            adicionarQtdEstoqueToolStripMenuItem.Name = "adicionarQtdEstoqueToolStripMenuItem";
            adicionarQtdEstoqueToolStripMenuItem.Size = new Size(213, 22);
            adicionarQtdEstoqueToolStripMenuItem.Text = "Cadastrar Produto";
            adicionarQtdEstoqueToolStripMenuItem.Click += adicionarQtdEstoqueToolStripMenuItem_Click;
            // 
            // adicionarQtdAoEstoqueToolStripMenuItem
            // 
            adicionarQtdAoEstoqueToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("adicionarQtdAoEstoqueToolStripMenuItem.BackgroundImage");
            adicionarQtdAoEstoqueToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            adicionarQtdAoEstoqueToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            adicionarQtdAoEstoqueToolStripMenuItem.Name = "adicionarQtdAoEstoqueToolStripMenuItem";
            adicionarQtdAoEstoqueToolStripMenuItem.Size = new Size(213, 22);
            adicionarQtdAoEstoqueToolStripMenuItem.Text = "Adicionar Qtd ao Estoque";
            adicionarQtdAoEstoqueToolStripMenuItem.Click += adicionarQtdAoEstoqueToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("relatóriosToolStripMenuItem.BackgroundImage");
            relatóriosToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            relatóriosToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(75, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            relatóriosToolStripMenuItem.Click += relatóriosToolStripMenuItem_Click;
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            cadastrarFornecedorToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("cadastrarFornecedorToolStripMenuItem.BackgroundImage");
            cadastrarFornecedorToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            cadastrarFornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarFornecedorToolStripMenuItem1 });
            cadastrarFornecedorToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            cadastrarFornecedorToolStripMenuItem.Size = new Size(138, 20);
            cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            // 
            // cadastrarFornecedorToolStripMenuItem1
            // 
            cadastrarFornecedorToolStripMenuItem1.BackgroundImage = (Image)resources.GetObject("cadastrarFornecedorToolStripMenuItem1.BackgroundImage");
            cadastrarFornecedorToolStripMenuItem1.BackgroundImageLayout = ImageLayout.Stretch;
            cadastrarFornecedorToolStripMenuItem1.Name = "cadastrarFornecedorToolStripMenuItem1";
            cadastrarFornecedorToolStripMenuItem1.Size = new Size(193, 22);
            cadastrarFornecedorToolStripMenuItem1.Text = "Cadastrar Fornecedor";
            cadastrarFornecedorToolStripMenuItem1.Click += cadastrarFornecedorToolStripMenuItem1_Click;
            // 
            // cadastrarColaboradorToolStripMenuItem
            // 
            cadastrarColaboradorToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("cadastrarColaboradorToolStripMenuItem.BackgroundImage");
            cadastrarColaboradorToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            cadastrarColaboradorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarSenhaDeAutorizaçãoToolStripMenuItem, cadastrarColaboradorToolStripMenuItem1 });
            cadastrarColaboradorToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrarColaboradorToolStripMenuItem.Name = "cadastrarColaboradorToolStripMenuItem";
            cadastrarColaboradorToolStripMenuItem.Size = new Size(141, 20);
            cadastrarColaboradorToolStripMenuItem.Text = "Cadastrar Colaborador";
            // 
            // cadastrarSenhaDeAutorizaçãoToolStripMenuItem
            // 
            cadastrarSenhaDeAutorizaçãoToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("cadastrarSenhaDeAutorizaçãoToolStripMenuItem.BackgroundImage");
            cadastrarSenhaDeAutorizaçãoToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            cadastrarSenhaDeAutorizaçãoToolStripMenuItem.Name = "cadastrarSenhaDeAutorizaçãoToolStripMenuItem";
            cadastrarSenhaDeAutorizaçãoToolStripMenuItem.Size = new Size(249, 22);
            cadastrarSenhaDeAutorizaçãoToolStripMenuItem.Text = "Cadastrar Senha de Autorização";
            cadastrarSenhaDeAutorizaçãoToolStripMenuItem.Click += cadastrarSenhaDeAutorizaçãoToolStripMenuItem_Click;
            // 
            // cadastrarColaboradorToolStripMenuItem1
            // 
            cadastrarColaboradorToolStripMenuItem1.BackgroundImage = (Image)resources.GetObject("cadastrarColaboradorToolStripMenuItem1.BackgroundImage");
            cadastrarColaboradorToolStripMenuItem1.BackgroundImageLayout = ImageLayout.Stretch;
            cadastrarColaboradorToolStripMenuItem1.Name = "cadastrarColaboradorToolStripMenuItem1";
            cadastrarColaboradorToolStripMenuItem1.Size = new Size(249, 22);
            cadastrarColaboradorToolStripMenuItem1.Text = "Cadastrar Colaborador";
            cadastrarColaboradorToolStripMenuItem1.Click += cadastrarColaboradorToolStripMenuItem1_Click;
            // 
            // pDVVenderToolStripMenuItem
            // 
            pDVVenderToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("pDVVenderToolStripMenuItem.BackgroundImage");
            pDVVenderToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            pDVVenderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frenteDeCaixaToolStripMenuItem });
            pDVVenderToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pDVVenderToolStripMenuItem.Name = "pDVVenderToolStripMenuItem";
            pDVVenderToolStripMenuItem.Size = new Size(125, 20);
            pDVVenderToolStripMenuItem.Text = "Vender Produto R$";
            // 
            // frenteDeCaixaToolStripMenuItem
            // 
            frenteDeCaixaToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("frenteDeCaixaToolStripMenuItem.BackgroundImage");
            frenteDeCaixaToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            frenteDeCaixaToolStripMenuItem.Name = "frenteDeCaixaToolStripMenuItem";
            frenteDeCaixaToolStripMenuItem.Size = new Size(160, 22);
            frenteDeCaixaToolStripMenuItem.Text = "Frente de Caixa";
            frenteDeCaixaToolStripMenuItem.Click += pDVVenderToolStripMenuItem_Click;
            // 
            // contasAPagarToolStripMenuItem
            // 
            contasAPagarToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("contasAPagarToolStripMenuItem.BackgroundImage");
            contasAPagarToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            contasAPagarToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            contasAPagarToolStripMenuItem.Size = new Size(99, 20);
            contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            contasAPagarToolStripMenuItem.Click += contasAPagarToolStripMenuItem_Click;
            // 
            // btNNotifica
            // 
            btNNotifica.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNNotifica.BackColor = SystemColors.GradientInactiveCaption;
            btNNotifica.BackgroundImageLayout = ImageLayout.Stretch;
            btNNotifica.ForeColor = Color.Red;
            btNNotifica.Image = (Image)resources.GetObject("btNNotifica.Image");
            btNNotifica.Location = new Point(996, 34);
            btNNotifica.Name = "btNNotifica";
            btNNotifica.Size = new Size(78, 62);
            btNNotifica.TabIndex = 2;
            btNNotifica.TextAlign = ContentAlignment.TopCenter;
            btNNotifica.UseVisualStyleBackColor = false;
            btNNotifica.Click += btNNotifica_Click_1;
            // 
            // dgvNotifica
            // 
            dgvNotifica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dgvNotifica.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvNotifica.BorderStyle = BorderStyle.Fixed3D;
            dgvNotifica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifica.Location = new Point(12, 479);
            dgvNotifica.Name = "dgvNotifica";
            dgvNotifica.ReadOnly = true;
            dgvNotifica.RowTemplate.Height = 25;
            dgvNotifica.Size = new Size(382, 89);
            dgvNotifica.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1086, 580);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
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
            pctSair.TabIndex = 51;
            pctSair.TabStop = false;
            pctSair.Click += pctSair_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 580);
            Controls.Add(pctSair);
            Controls.Add(btNNotifica);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            Controls.Add(dgvNotifica);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipal";
            Text = "Tela Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotifica).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private ToolStripMenuItem cadastrarColaboradorToolStripMenuItem;
        private ToolStripMenuItem pDVVenderToolStripMenuItem;
        private ToolStripMenuItem adicionarQtdEstoqueToolStripMenuItem;
        private ToolStripMenuItem adicionarQtdAoEstoqueToolStripMenuItem;
        private Button btNNotifica;
        private ToolStripMenuItem cadastrarSenhaDeAutorizaçãoToolStripMenuItem;
        private ToolStripMenuItem cadastrarColaboradorToolStripMenuItem1;
        private ToolStripMenuItem cadastrarFornecedorToolStripMenuItem1;
        private ToolStripMenuItem frenteDeCaixaToolStripMenuItem;
        private DataGridView dgvNotifica;
        private ToolStripMenuItem contasAPagarToolStripMenuItem;
        private PictureBox pictureBox2;
        private PictureBox pctSair;
    }
}