namespace ArmazemGP.View
{
    partial class TelaCadastroContasPGR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroContasPGR));
            label1 = new Label();
            ttbNomeContaPG = new TextBox();
            label3 = new Label();
            ttbCodContaPG = new TextBox();
            label4 = new Label();
            label5 = new Label();
            mktDataInputPG = new MaskedTextBox();
            mktDataOutVencPG = new MaskedTextBox();
            label6 = new Label();
            ttbValorContaPG = new TextBox();
            btNExcluirPG = new Button();
            btNAlterarPG = new Button();
            btNGravarPG = new Button();
            tabContas = new TabControl();
            tabContasAPG = new TabPage();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox5 = new PictureBox();
            btNLimpar = new Button();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            lbIdCAR = new Label();
            lbIdCAPG = new Label();
            tabRelatorioAPG = new TabPage();
            lbAPagar = new Label();
            lbAReceber = new Label();
            ttbRelatPG = new TextBox();
            btNBuscar = new Button();
            label8 = new Label();
            label7 = new Label();
            dgvRelatorioAPG = new DataGridView();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pctSair = new PictureBox();
            ttbObs = new TextBox();
            label12 = new Label();
            tabContas.SuspendLayout();
            tabContasAPG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabRelatorioAPG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorioAPG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            label1.Location = new Point(443, 135);
            label1.Name = "label1";
            label1.Size = new Size(237, 34);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Contas";
            // 
            // ttbNomeContaPG
            // 
            ttbNomeContaPG.Anchor = AnchorStyles.None;
            ttbNomeContaPG.Location = new Point(10, 105);
            ttbNomeContaPG.Name = "ttbNomeContaPG";
            ttbNomeContaPG.PlaceholderText = "ex: Água, Energia, Telefone e etc.";
            ttbNomeContaPG.Size = new Size(229, 23);
            ttbNomeContaPG.TabIndex = 1;
            ttbNomeContaPG.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(256, 87);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 3;
            label3.Text = "Código (1 ou 2)";
            // 
            // ttbCodContaPG
            // 
            ttbCodContaPG.Anchor = AnchorStyles.None;
            ttbCodContaPG.Location = new Point(256, 105);
            ttbCodContaPG.Name = "ttbCodContaPG";
            ttbCodContaPG.PlaceholderText = "1 ou 2";
            ttbCodContaPG.Size = new Size(91, 23);
            ttbCodContaPG.TabIndex = 2;
            ttbCodContaPG.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(10, 150);
            label4.Name = "label4";
            label4.Size = new Size(118, 17);
            label4.TabIndex = 5;
            label4.Text = "Data de Lançamento";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(232, 150);
            label5.Name = "label5";
            label5.Size = new Size(115, 17);
            label5.TabIndex = 6;
            label5.Text = "Data de Vencimento";
            // 
            // mktDataInputPG
            // 
            mktDataInputPG.Anchor = AnchorStyles.None;
            mktDataInputPG.Location = new Point(10, 168);
            mktDataInputPG.Mask = "00/00/0000";
            mktDataInputPG.Name = "mktDataInputPG";
            mktDataInputPG.Size = new Size(118, 23);
            mktDataInputPG.TabIndex = 7;
            mktDataInputPG.ValidatingType = typeof(DateTime);
            // 
            // mktDataOutVencPG
            // 
            mktDataOutVencPG.Anchor = AnchorStyles.None;
            mktDataOutVencPG.Location = new Point(232, 168);
            mktDataOutVencPG.Mask = "00/00/0000";
            mktDataOutVencPG.Name = "mktDataOutVencPG";
            mktDataOutVencPG.Size = new Size(115, 23);
            mktDataOutVencPG.TabIndex = 3;
            mktDataOutVencPG.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(138, 150);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 9;
            label6.Text = "Valor da Conta";
            // 
            // ttbValorContaPG
            // 
            ttbValorContaPG.Anchor = AnchorStyles.None;
            ttbValorContaPG.Location = new Point(138, 168);
            ttbValorContaPG.Name = "ttbValorContaPG";
            ttbValorContaPG.PlaceholderText = "R$ Valor Total";
            ttbValorContaPG.Size = new Size(86, 23);
            ttbValorContaPG.TabIndex = 4;
            ttbValorContaPG.TextAlign = HorizontalAlignment.Center;
            // 
            // btNExcluirPG
            // 
            btNExcluirPG.Anchor = AnchorStyles.None;
            btNExcluirPG.BackColor = SystemColors.GradientInactiveCaption;
            btNExcluirPG.BackgroundImage = (Image)resources.GetObject("btNExcluirPG.BackgroundImage");
            btNExcluirPG.BackgroundImageLayout = ImageLayout.Stretch;
            btNExcluirPG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNExcluirPG.ForeColor = Color.Red;
            btNExcluirPG.Location = new Point(17, 290);
            btNExcluirPG.Name = "btNExcluirPG";
            btNExcluirPG.Size = new Size(75, 23);
            btNExcluirPG.TabIndex = 8;
            btNExcluirPG.Text = "Excluir";
            btNExcluirPG.UseVisualStyleBackColor = false;
            btNExcluirPG.Click += btNExcluirPG_Click;
            // 
            // btNAlterarPG
            // 
            btNAlterarPG.Anchor = AnchorStyles.None;
            btNAlterarPG.BackColor = SystemColors.GradientInactiveCaption;
            btNAlterarPG.BackgroundImage = (Image)resources.GetObject("btNAlterarPG.BackgroundImage");
            btNAlterarPG.BackgroundImageLayout = ImageLayout.Stretch;
            btNAlterarPG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNAlterarPG.ForeColor = Color.Blue;
            btNAlterarPG.Location = new Point(98, 290);
            btNAlterarPG.Name = "btNAlterarPG";
            btNAlterarPG.Size = new Size(75, 23);
            btNAlterarPG.TabIndex = 7;
            btNAlterarPG.Text = "Alterar";
            btNAlterarPG.UseVisualStyleBackColor = false;
            btNAlterarPG.Click += btNAlterarPG_Click;
            // 
            // btNGravarPG
            // 
            btNGravarPG.Anchor = AnchorStyles.None;
            btNGravarPG.BackColor = SystemColors.GradientInactiveCaption;
            btNGravarPG.BackgroundImage = (Image)resources.GetObject("btNGravarPG.BackgroundImage");
            btNGravarPG.BackgroundImageLayout = ImageLayout.Stretch;
            btNGravarPG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNGravarPG.ForeColor = Color.Green;
            btNGravarPG.Location = new Point(266, 290);
            btNGravarPG.Name = "btNGravarPG";
            btNGravarPG.Size = new Size(75, 23);
            btNGravarPG.TabIndex = 5;
            btNGravarPG.Text = "Gravar";
            btNGravarPG.UseVisualStyleBackColor = false;
            btNGravarPG.Click += btNGravarPG_Click;
            // 
            // tabContas
            // 
            tabContas.Anchor = AnchorStyles.None;
            tabContas.Controls.Add(tabContasAPG);
            tabContas.Controls.Add(tabRelatorioAPG);
            tabContas.Location = new Point(223, 172);
            tabContas.Name = "tabContas";
            tabContas.SelectedIndex = 0;
            tabContas.Size = new Size(679, 385);
            tabContas.TabIndex = 15;
            // 
            // tabContasAPG
            // 
            tabContasAPG.BackgroundImage = (Image)resources.GetObject("tabContasAPG.BackgroundImage");
            tabContasAPG.BackgroundImageLayout = ImageLayout.Stretch;
            tabContasAPG.BorderStyle = BorderStyle.Fixed3D;
            tabContasAPG.Controls.Add(label12);
            tabContasAPG.Controls.Add(ttbObs);
            tabContasAPG.Controls.Add(label11);
            tabContasAPG.Controls.Add(label9);
            tabContasAPG.Controls.Add(label10);
            tabContasAPG.Controls.Add(pictureBox5);
            tabContasAPG.Controls.Add(mktDataOutVencPG);
            tabContasAPG.Controls.Add(btNLimpar);
            tabContasAPG.Controls.Add(label2);
            tabContasAPG.Controls.Add(ttbNomeContaPG);
            tabContasAPG.Controls.Add(btNGravarPG);
            tabContasAPG.Controls.Add(label3);
            tabContasAPG.Controls.Add(btNAlterarPG);
            tabContasAPG.Controls.Add(ttbCodContaPG);
            tabContasAPG.Controls.Add(btNExcluirPG);
            tabContasAPG.Controls.Add(label4);
            tabContasAPG.Controls.Add(ttbValorContaPG);
            tabContasAPG.Controls.Add(label5);
            tabContasAPG.Controls.Add(label6);
            tabContasAPG.Controls.Add(mktDataInputPG);
            tabContasAPG.Controls.Add(pictureBox4);
            tabContasAPG.Controls.Add(lbIdCAR);
            tabContasAPG.Controls.Add(lbIdCAPG);
            tabContasAPG.Location = new Point(4, 24);
            tabContasAPG.Name = "tabContasAPG";
            tabContasAPG.Padding = new Padding(3);
            tabContasAPG.Size = new Size(671, 357);
            tabContasAPG.TabIndex = 0;
            tabContasAPG.Text = "Cadastro";
            tabContasAPG.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(96, 15);
            label11.Name = "label11";
            label11.Size = new Size(175, 17);
            label11.TabIndex = 27;
            label11.Text = "No Campo Código, Para Contas";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(70, 37);
            label9.Name = "label9";
            label9.Size = new Size(99, 17);
            label9.TabIndex = 25;
            label9.Text = "A Pagar Digite '1'";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(180, 37);
            label10.Name = "label10";
            label10.Size = new Size(113, 17);
            label10.TabIndex = 24;
            label10.Text = "A Receber Digite '2'";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(6, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(345, 58);
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // btNLimpar
            // 
            btNLimpar.Anchor = AnchorStyles.None;
            btNLimpar.BackColor = SystemColors.GradientInactiveCaption;
            btNLimpar.BackgroundImage = (Image)resources.GetObject("btNLimpar.BackgroundImage");
            btNLimpar.BackgroundImageLayout = ImageLayout.Stretch;
            btNLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNLimpar.ForeColor = Color.DarkOrange;
            btNLimpar.Location = new Point(185, 290);
            btNLimpar.Name = "btNLimpar";
            btNLimpar.Size = new Size(75, 23);
            btNLimpar.TabIndex = 6;
            btNLimpar.Text = "Limpar";
            btNLimpar.UseVisualStyleBackColor = false;
            btNLimpar.Click += btNLimpar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(10, 87);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 15;
            label2.Text = "Conta";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(6, 70);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(345, 260);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // lbIdCAR
            // 
            lbIdCAR.AutoSize = true;
            lbIdCAR.Location = new Point(260, 155);
            lbIdCAR.Name = "lbIdCAR";
            lbIdCAR.Size = new Size(0, 15);
            lbIdCAR.TabIndex = 17;
            // 
            // lbIdCAPG
            // 
            lbIdCAPG.AutoSize = true;
            lbIdCAPG.Location = new Point(319, 153);
            lbIdCAPG.Name = "lbIdCAPG";
            lbIdCAPG.Size = new Size(0, 15);
            lbIdCAPG.TabIndex = 16;
            // 
            // tabRelatorioAPG
            // 
            tabRelatorioAPG.BackgroundImage = (Image)resources.GetObject("tabRelatorioAPG.BackgroundImage");
            tabRelatorioAPG.BackgroundImageLayout = ImageLayout.Stretch;
            tabRelatorioAPG.BorderStyle = BorderStyle.Fixed3D;
            tabRelatorioAPG.Controls.Add(lbAPagar);
            tabRelatorioAPG.Controls.Add(lbAReceber);
            tabRelatorioAPG.Controls.Add(ttbRelatPG);
            tabRelatorioAPG.Controls.Add(btNBuscar);
            tabRelatorioAPG.Controls.Add(label8);
            tabRelatorioAPG.Controls.Add(label7);
            tabRelatorioAPG.Controls.Add(dgvRelatorioAPG);
            tabRelatorioAPG.Controls.Add(pictureBox6);
            tabRelatorioAPG.Location = new Point(4, 24);
            tabRelatorioAPG.Name = "tabRelatorioAPG";
            tabRelatorioAPG.Padding = new Padding(3);
            tabRelatorioAPG.Size = new Size(671, 357);
            tabRelatorioAPG.TabIndex = 2;
            tabRelatorioAPG.Text = "Relatórios de Contas";
            tabRelatorioAPG.UseVisualStyleBackColor = true;
            // 
            // lbAPagar
            // 
            lbAPagar.Anchor = AnchorStyles.None;
            lbAPagar.AutoSize = true;
            lbAPagar.BorderStyle = BorderStyle.Fixed3D;
            lbAPagar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbAPagar.Location = new Point(6, 58);
            lbAPagar.Name = "lbAPagar";
            lbAPagar.Size = new Size(115, 34);
            lbAPagar.TabIndex = 41;
            lbAPagar.Text = "A PAGAR";
            // 
            // lbAReceber
            // 
            lbAReceber.Anchor = AnchorStyles.None;
            lbAReceber.AutoSize = true;
            lbAReceber.BorderStyle = BorderStyle.Fixed3D;
            lbAReceber.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbAReceber.Location = new Point(6, 58);
            lbAReceber.Name = "lbAReceber";
            lbAReceber.Size = new Size(135, 34);
            lbAReceber.TabIndex = 40;
            lbAReceber.Text = "A RECEBER";
            // 
            // ttbRelatPG
            // 
            ttbRelatPG.Anchor = AnchorStyles.None;
            ttbRelatPG.Location = new Point(597, 26);
            ttbRelatPG.Name = "ttbRelatPG";
            ttbRelatPG.PlaceholderText = "1 ou 2";
            ttbRelatPG.Size = new Size(55, 23);
            ttbRelatPG.TabIndex = 9;
            ttbRelatPG.TextAlign = HorizontalAlignment.Center;
            // 
            // btNBuscar
            // 
            btNBuscar.Anchor = AnchorStyles.None;
            btNBuscar.BackColor = SystemColors.GradientInactiveCaption;
            btNBuscar.BackgroundImage = (Image)resources.GetObject("btNBuscar.BackgroundImage");
            btNBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btNBuscar.Location = new Point(579, 55);
            btNBuscar.Name = "btNBuscar";
            btNBuscar.Size = new Size(73, 23);
            btNBuscar.TabIndex = 10;
            btNBuscar.Text = "Buscar";
            btNBuscar.UseVisualStyleBackColor = false;
            btNBuscar.Click += btNBuscar_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(449, 26);
            label8.Name = "label8";
            label8.Size = new Size(136, 17);
            label8.TabIndex = 22;
            label8.Text = "Contas a Pagar Digite '1'";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(449, 55);
            label7.Name = "label7";
            label7.Size = new Size(113, 17);
            label7.TabIndex = 21;
            label7.Text = "A Receber Digite '2'";
            // 
            // dgvRelatorioAPG
            // 
            dgvRelatorioAPG.Anchor = AnchorStyles.None;
            dgvRelatorioAPG.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvRelatorioAPG.BorderStyle = BorderStyle.Fixed3D;
            dgvRelatorioAPG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorioAPG.Location = new Point(-2, 99);
            dgvRelatorioAPG.Name = "dgvRelatorioAPG";
            dgvRelatorioAPG.ReadOnly = true;
            dgvRelatorioAPG.RowTemplate.Height = 25;
            dgvRelatorioAPG.Size = new Size(671, 260);
            dgvRelatorioAPG.TabIndex = 18;
            dgvRelatorioAPG.CellContentClick += dgvRelatorioAPG_CellContentClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(441, 18);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(220, 66);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 39;
            pictureBox6.TabStop = false;
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
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(512, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
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
            // ttbObs
            // 
            ttbObs.Location = new Point(10, 220);
            ttbObs.Multiline = true;
            ttbObs.Name = "ttbObs";
            ttbObs.PlaceholderText = "Você pode adicionar observações sobre esta conta...";
            ttbObs.Size = new Size(337, 64);
            ttbObs.TabIndex = 28;
            ttbObs.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(10, 200);
            label12.Name = "label12";
            label12.Size = new Size(76, 17);
            label12.TabIndex = 29;
            label12.Text = "Observações";
            // 
            // TelaCadastroContasPGR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1102, 619);
            Controls.Add(pctSair);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(tabContas);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadastroContasPGR";
            Text = "TelaCadastroContasPGR";
            WindowState = FormWindowState.Maximized;
            tabContas.ResumeLayout(false);
            tabContasAPG.ResumeLayout(false);
            tabContasAPG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabRelatorioAPG.ResumeLayout(false);
            tabRelatorioAPG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorioAPG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ttbNomeContaPG;
        private Label label3;
        private TextBox ttbCodContaPG;
        private Label label4;
        private Label label5;
        private MaskedTextBox mktDataInputPG;
        private MaskedTextBox mktDataOutVencPG;
        private Label label6;
        private TextBox ttbValorContaPG;
        private Button btNExcluirPG;
        private Button btNAlterarPG;
        private Button btNGravarPG;
        private TabControl tabContas;
        private TabPage tabContasAPG;
        private TabPage tabRelatorioAPG;
        private DataGridView dgvRelatorioAPG;
        private Label lbIdCAPG;
        private Label lbIdCAR;
        private Label label7;
        private TextBox ttbRelatPG;
        private Button btNBuscar;
        private Label label2;
        private Label label8;
        private Button btNLimpar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label11;
        private Label lbAReceber;
        private Label lbAPagar;
        private PictureBox pctSair;
        private Label label12;
        private TextBox ttbObs;
    }
}