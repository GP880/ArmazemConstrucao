namespace ArmazemGP.View
{
    partial class ScreenLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenLogin));
            lbErroSenha = new Label();
            pictureBox2 = new PictureBox();
            pctVisualizar = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            ttbSenha = new TextBox();
            ttbEmail = new TextBox();
            lbErrorLogin = new Label();
            pbgCarregarSistema = new ProgressBar();
            lbInvisivel2 = new Label();
            lbInvisivel1 = new Label();
            pictureBox5 = new PictureBox();
            btnLogin = new Button();
            checkBoxOfc = new CheckBox();
            lbFacaLogin = new Label();
            label2 = new Label();
            label1 = new Label();
            lbEntrar = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lbSucesso = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVisualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbErroSenha
            // 
            lbErroSenha.Anchor = AnchorStyles.None;
            lbErroSenha.AutoSize = true;
            lbErroSenha.ForeColor = Color.Coral;
            lbErroSenha.Location = new Point(1181, 600);
            lbErroSenha.Name = "lbErroSenha";
            lbErroSenha.Size = new Size(0, 15);
            lbErroSenha.TabIndex = 61;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1087, 203);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(292, 190);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // pctVisualizar
            // 
            pctVisualizar.Anchor = AnchorStyles.None;
            pctVisualizar.BackColor = SystemColors.GradientInactiveCaption;
            pctVisualizar.BorderStyle = BorderStyle.Fixed3D;
            pctVisualizar.Image = (Image)resources.GetObject("pctVisualizar.Image");
            pctVisualizar.Location = new Point(1339, 488);
            pctVisualizar.Name = "pctVisualizar";
            pctVisualizar.Size = new Size(28, 23);
            pctVisualizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVisualizar.TabIndex = 59;
            pctVisualizar.TabStop = false;
            pctVisualizar.Click += pctVisualizar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1101, 488);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1101, 431);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 57;
            pictureBox6.TabStop = false;
            // 
            // ttbSenha
            // 
            ttbSenha.Anchor = AnchorStyles.None;
            ttbSenha.Location = new Point(1101, 488);
            ttbSenha.Name = "ttbSenha";
            ttbSenha.PlaceholderText = "* * * * *";
            ttbSenha.Size = new Size(232, 23);
            ttbSenha.TabIndex = 2;
            ttbSenha.TextAlign = HorizontalAlignment.Center;
            ttbSenha.UseSystemPasswordChar = true;
            // 
            // ttbEmail
            // 
            ttbEmail.Anchor = AnchorStyles.None;
            ttbEmail.Location = new Point(1127, 431);
            ttbEmail.Name = "ttbEmail";
            ttbEmail.PlaceholderText = "login@aqui.com";
            ttbEmail.Size = new Size(206, 23);
            ttbEmail.TabIndex = 1;
            ttbEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lbErrorLogin
            // 
            lbErrorLogin.Anchor = AnchorStyles.None;
            lbErrorLogin.AutoSize = true;
            lbErrorLogin.FlatStyle = FlatStyle.System;
            lbErrorLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbErrorLogin.ForeColor = Color.Coral;
            lbErrorLogin.Location = new Point(1176, 525);
            lbErrorLogin.Name = "lbErrorLogin";
            lbErrorLogin.Size = new Size(0, 15);
            lbErrorLogin.TabIndex = 54;
            // 
            // pbgCarregarSistema
            // 
            pbgCarregarSistema.Anchor = AnchorStyles.None;
            pbgCarregarSistema.BackColor = Color.Gray;
            pbgCarregarSistema.ForeColor = Color.Green;
            pbgCarregarSistema.Location = new Point(357, 488);
            pbgCarregarSistema.Name = "pbgCarregarSistema";
            pbgCarregarSistema.Size = new Size(341, 12);
            pbgCarregarSistema.Style = ProgressBarStyle.Continuous;
            pbgCarregarSistema.TabIndex = 53;
            pbgCarregarSistema.Visible = false;
            // 
            // lbInvisivel2
            // 
            lbInvisivel2.Anchor = AnchorStyles.None;
            lbInvisivel2.AutoSize = true;
            lbInvisivel2.BackColor = Color.Silver;
            lbInvisivel2.ForeColor = Color.Black;
            lbInvisivel2.Location = new Point(489, 467);
            lbInvisivel2.Name = "lbInvisivel2";
            lbInvisivel2.Size = new Size(0, 15);
            lbInvisivel2.TabIndex = 52;
            // 
            // lbInvisivel1
            // 
            lbInvisivel1.Anchor = AnchorStyles.None;
            lbInvisivel1.AutoSize = true;
            lbInvisivel1.BackColor = Color.Gray;
            lbInvisivel1.FlatStyle = FlatStyle.System;
            lbInvisivel1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbInvisivel1.ForeColor = Color.Black;
            lbInvisivel1.Location = new Point(363, 457);
            lbInvisivel1.Name = "lbInvisivel1";
            lbInvisivel1.Size = new Size(0, 28);
            lbInvisivel1.TabIndex = 51;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1529, 769);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 50;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = SystemColors.GradientInactiveCaption;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(1161, 519);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBoxOfc
            // 
            checkBoxOfc.Anchor = AnchorStyles.None;
            checkBoxOfc.AutoSize = true;
            checkBoxOfc.BackColor = SystemColors.GradientInactiveCaption;
            checkBoxOfc.BackgroundImageLayout = ImageLayout.Stretch;
            checkBoxOfc.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxOfc.ForeColor = Color.DimGray;
            checkBoxOfc.Location = new Point(1161, 557);
            checkBoxOfc.Name = "checkBoxOfc";
            checkBoxOfc.Size = new Size(123, 20);
            checkBoxOfc.TabIndex = 3;
            checkBoxOfc.Text = "Manter logado";
            checkBoxOfc.UseVisualStyleBackColor = false;
            // 
            // lbFacaLogin
            // 
            lbFacaLogin.Anchor = AnchorStyles.None;
            lbFacaLogin.AutoSize = true;
            lbFacaLogin.BackColor = SystemColors.GradientInactiveCaption;
            lbFacaLogin.BorderStyle = BorderStyle.Fixed3D;
            lbFacaLogin.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbFacaLogin.ForeColor = SystemColors.GrayText;
            lbFacaLogin.Location = new Point(1193, 410);
            lbFacaLogin.Name = "lbFacaLogin";
            lbFacaLogin.Size = new Size(44, 18);
            lbFacaLogin.TabIndex = 47;
            lbFacaLogin.Text = "Login";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(357, 503);
            label2.Name = "label2";
            label2.Size = new Size(341, 33);
            label2.TabIndex = 46;
            label2.Text = "sempre conectando você";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(357, 393);
            label1.Name = "label1";
            label1.Size = new Size(268, 33);
            label1.TabIndex = 45;
            label1.Text = "Seja bem vindo (a)!";
            // 
            // lbEntrar
            // 
            lbEntrar.Anchor = AnchorStyles.None;
            lbEntrar.AutoSize = true;
            lbEntrar.BackColor = Color.Silver;
            lbEntrar.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbEntrar.ForeColor = Color.White;
            lbEntrar.Location = new Point(357, 352);
            lbEntrar.Name = "lbEntrar";
            lbEntrar.Size = new Size(84, 33);
            lbEntrar.TabIndex = 44;
            lbEntrar.Text = "Entre";
            // 
            // lbSucesso
            // 
            lbSucesso.Anchor = AnchorStyles.None;
            lbSucesso.AutoSize = true;
            lbSucesso.ForeColor = Color.Coral;
            lbSucesso.Location = new Point(1141, 396);
            lbSucesso.Name = "lbSucesso";
            lbSucesso.Size = new Size(0, 15);
            lbSucesso.TabIndex = 62;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(257, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 63;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1584, 810);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 64;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(1193, 467);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 65;
            label3.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(1087, 396);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 190);
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // ScreenLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1584, 810);
            Controls.Add(label3);
            Controls.Add(ttbEmail);
            Controls.Add(pctVisualizar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox6);
            Controls.Add(ttbSenha);
            Controls.Add(btnLogin);
            Controls.Add(checkBoxOfc);
            Controls.Add(lbFacaLogin);
            Controls.Add(pictureBox1);
            Controls.Add(pbgCarregarSistema);
            Controls.Add(lbErroSenha);
            Controls.Add(pictureBox2);
            Controls.Add(lbErrorLogin);
            Controls.Add(lbInvisivel2);
            Controls.Add(pictureBox5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbEntrar);
            Controls.Add(pictureBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbInvisivel1);
            Controls.Add(lbSucesso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ScreenLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScreenLogin";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVisualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbErroSenha;
        private PictureBox pictureBox2;
        private PictureBox pctVisualizar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private TextBox ttbSenha;
        private TextBox ttbEmail;
        private Label lbErrorLogin;
        private ProgressBar pbgCarregarSistema;
        private Label lbInvisivel2;
        private Label lbInvisivel1;
        private PictureBox pictureBox5;
        private Button btnLogin;
        private CheckBox checkBoxOfc;
        private Label lbFacaLogin;
        private Label label2;
        private Label label1;
        private Label lbEntrar;
        private System.Windows.Forms.Timer timer1;
        private Label lbSucesso;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox1;
    }
}