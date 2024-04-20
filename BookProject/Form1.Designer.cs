namespace BookProject
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKitapAdi = new TextBox();
            txtFiyat = new TextBox();
            txtSayfaSayisi = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 65);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 122);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Fiyatı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 181);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Sayfa Sayısı : ";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(225, 57);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(100, 23);
            txtKitapAdi.TabIndex = 3;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(225, 119);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(100, 23);
            txtFiyat.TabIndex = 4;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(225, 173);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(100, 23);
            txtSayfaSayisi.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.Desktop;
            btnKaydet.Location = new Point(225, 240);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 46);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(txtSayfaSayisi);
            Controls.Add(txtFiyat);
            Controls.Add(txtKitapAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKitapAdi;
        private TextBox txtFiyat;
        private TextBox txtSayfaSayisi;
        private Button btnKaydet;
    }
}
