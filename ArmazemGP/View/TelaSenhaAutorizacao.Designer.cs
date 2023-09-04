namespace ArmazemGP.View
{
    partial class TelaSenhaAutorizacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSenhaAutorizacao));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ttbLogin = new TextBox();
            ttbSenha = new TextBox();
            btNAutorizar = new Button();
            btNCancelar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pctSair = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            label1.Location = new Point(456, 231);
            label1.Name = "label1";
            label1.Size = new Size(154, 34);
            label1.TabIndex = 0;
            label1.Text = "Autorização";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(457, 285);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(456, 351);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // ttbLogin
            // 
            ttbLogin.Anchor = AnchorStyles.None;
            ttbLogin.Location = new Point(457, 303);
            ttbLogin.Name = "ttbLogin";
            ttbLogin.Size = new Size(185, 23);
            ttbLogin.TabIndex = 3;
            // 
            // ttbSenha
            // 
            ttbSenha.Anchor = AnchorStyles.None;
            ttbSenha.Location = new Point(457, 369);
            ttbSenha.Name = "ttbSenha";
            ttbSenha.Size = new Size(185, 23);
            ttbSenha.TabIndex = 4;
            // 
            // btNAutorizar
            // 
            btNAutorizar.Anchor = AnchorStyles.None;
            btNAutorizar.BackColor = SystemColors.GradientInactiveCaption;
            btNAutorizar.BackgroundImage = (Image)resources.GetObject("btNAutorizar.BackgroundImage");
            btNAutorizar.BackgroundImageLayout = ImageLayout.Stretch;
            btNAutorizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNAutorizar.ForeColor = Color.Blue;
            btNAutorizar.Location = new Point(456, 416);
            btNAutorizar.Name = "btNAutorizar";
            btNAutorizar.Size = new Size(75, 23);
            btNAutorizar.TabIndex = 5;
            btNAutorizar.Text = "Autorizar";
            btNAutorizar.UseVisualStyleBackColor = false;
            btNAutorizar.Click += btNAutorizar_Click;
            // 
            // btNCancelar
            // 
            btNCancelar.Anchor = AnchorStyles.None;
            btNCancelar.BackColor = SystemColors.GradientInactiveCaption;
            btNCancelar.BackgroundImage = (Image)resources.GetObject("btNCancelar.BackgroundImage");
            btNCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btNCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btNCancelar.ForeColor = Color.Red;
            btNCancelar.Location = new Point(567, 416);
            btNCancelar.Name = "btNCancelar";
            btNCancelar.Size = new Size(75, 23);
            btNCancelar.TabIndex = 6;
            btNCancelar.Text = "Cancelar";
            btNCancelar.UseVisualStyleBackColor = false;
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
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(492, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(311, 197);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(480, 261);
            pictureBox3.TabIndex = 10;
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
            // TelaSenhaAutorizacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 580);
            Controls.Add(pctSair);
            Controls.Add(btNCancelar);
            Controls.Add(btNAutorizar);
            Controls.Add(ttbSenha);
            Controls.Add(ttbLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaSenhaAutorizacao";
            Text = "TelaSenhaAutorizacao";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ttbLogin;
        private TextBox ttbSenha;
        private Button btNAutorizar;
        private Button btNCancelar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pctSair;
    }
}