namespace ArmazemGP.View
{
    partial class TelaParcelas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btNConfirma = new Button();
            cbbParcelas = new ComboBox();
            label4 = new Label();
            ttbAParcelar = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 24);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 0;
            label1.Text = "Finalização de Venda";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(47, 112);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Crédito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 127);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Parcelas";
            // 
            // btNConfirma
            // 
            btNConfirma.Location = new Point(377, 376);
            btNConfirma.Name = "btNConfirma";
            btNConfirma.Size = new Size(75, 23);
            btNConfirma.TabIndex = 3;
            btNConfirma.Text = "Confirmar";
            btNConfirma.UseVisualStyleBackColor = true;
            btNConfirma.Click += btNConfirma_Click;
            // 
            // cbbParcelas
            // 
            cbbParcelas.Anchor = AnchorStyles.None;
            cbbParcelas.FormattingEnabled = true;
            cbbParcelas.Location = new Point(318, 145);
            cbbParcelas.Name = "cbbParcelas";
            cbbParcelas.Size = new Size(200, 23);
            cbbParcelas.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(47, 127);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 5;
            label4.Text = "Total a Parcelar";
            // 
            // ttbAParcelar
            // 
            ttbAParcelar.Anchor = AnchorStyles.None;
            ttbAParcelar.BackColor = SystemColors.ButtonFace;
            ttbAParcelar.Location = new Point(47, 145);
            ttbAParcelar.Name = "ttbAParcelar";
            ttbAParcelar.ReadOnly = true;
            ttbAParcelar.Size = new Size(147, 23);
            ttbAParcelar.TabIndex = 6;
            // 
            // TelaParcelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ttbAParcelar);
            Controls.Add(label4);
            Controls.Add(cbbParcelas);
            Controls.Add(btNConfirma);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaParcelas";
            Text = "TelaParcelas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btNConfirma;
        private ComboBox cbbParcelas;
        private Label label4;
        private TextBox ttbAParcelar;
    }
}