namespace BookProject
{
    partial class NewBookForm
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
            cmbKategori = new ComboBox();
            cmbYayinEvi = new ComboBox();
            cmbYazar = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtKitapAdi = new TextBox();
            txtFiyati = new TextBox();
            txtSayfaSayisi = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 61);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 127);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Yayın Evi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 191);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Yazar :";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(239, 58);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(173, 23);
            cmbKategori.TabIndex = 3;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // cmbYayinEvi
            // 
            cmbYayinEvi.FormattingEnabled = true;
            cmbYayinEvi.Location = new Point(239, 119);
            cmbYayinEvi.Name = "cmbYayinEvi";
            cmbYayinEvi.Size = new Size(173, 23);
            cmbYayinEvi.TabIndex = 4;
            cmbYayinEvi.SelectedIndexChanged += cmbYayınEvi_SelectedIndexChanged;
            // 
            // cmbYazar
            // 
            cmbYazar.FormattingEnabled = true;
            cmbYazar.Location = new Point(239, 183);
            cmbYazar.Name = "cmbYazar";
            cmbYazar.Size = new Size(173, 23);
            cmbYazar.TabIndex = 5;
            cmbYazar.SelectedIndexChanged += cmbYazar_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 251);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 6;
            label4.Text = "Kitap Adı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 309);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 7;
            label5.Text = "Fiyatı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 361);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 8;
            label6.Text = "Sayfa Sayısı :";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(239, 243);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(175, 23);
            txtKitapAdi.TabIndex = 9;
            // 
            // txtFiyati
            // 
            txtFiyati.Location = new Point(239, 301);
            txtFiyati.Name = "txtFiyati";
            txtFiyati.Size = new Size(175, 23);
            txtFiyati.TabIndex = 10;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(239, 353);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(175, 23);
            txtSayfaSayisi.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Location = new Point(237, 411);
            button1.Name = "button1";
            button1.Size = new Size(92, 36);
            button1.TabIndex = 12;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(112, 499);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(998, 186);
            dataGridView1.TabIndex = 13;
            // 
            // NewBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 724);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtSayfaSayisi);
            Controls.Add(txtFiyati);
            Controls.Add(txtKitapAdi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbYazar);
            Controls.Add(cmbYayinEvi);
            Controls.Add(cmbKategori);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewBookForm";
            Text = "NewBookForm";
            Load += NewBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbKategori;
        private ComboBox cmbYayinEvi;
        private ComboBox cmbYazar;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKitapAdi;
        private TextBox txtFiyati;
        private TextBox txtSayfaSayisi;
        private Button button1;
        private DataGridView dataGridView1;
    }
}