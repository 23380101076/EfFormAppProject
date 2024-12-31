namespace EfFormAppProject
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
            grpOgrenciBul = new GroupBox();
            cbSinifSecimi = new ComboBox();
            txtNumara = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblSinifSecimi = new Label();
            lblNumara = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnBul = new Button();
            btnDersSecimi = new Button();
            grpOgrenciBul.SuspendLayout();
            SuspendLayout();
            // 
            // grpOgrenciBul
            // 
            grpOgrenciBul.Controls.Add(cbSinifSecimi);
            grpOgrenciBul.Controls.Add(txtNumara);
            grpOgrenciBul.Controls.Add(txtSoyad);
            grpOgrenciBul.Controls.Add(txtAd);
            grpOgrenciBul.Controls.Add(lblSinifSecimi);
            grpOgrenciBul.Controls.Add(lblNumara);
            grpOgrenciBul.Controls.Add(lblSoyad);
            grpOgrenciBul.Controls.Add(lblAd);
            grpOgrenciBul.Location = new Point(12, 12);
            grpOgrenciBul.Name = "grpOgrenciBul";
            grpOgrenciBul.Size = new Size(427, 202);
            grpOgrenciBul.TabIndex = 0;
            grpOgrenciBul.TabStop = false;
            grpOgrenciBul.Text = "Öğrenci Ekleme";
            // 
            // cbSinifSecimi
            // 
            cbSinifSecimi.FormattingEnabled = true;
            cbSinifSecimi.Location = new Point(136, 150);
            cbSinifSecimi.Name = "cbSinifSecimi";
            cbSinifSecimi.Size = new Size(121, 23);
            cbSinifSecimi.TabIndex = 7;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(136, 118);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(121, 23);
            txtNumara.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(136, 85);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(121, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(136, 56);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(121, 23);
            txtAd.TabIndex = 4;
            // 
            // lblSinifSecimi
            // 
            lblSinifSecimi.AutoSize = true;
            lblSinifSecimi.Location = new Point(20, 150);
            lblSinifSecimi.Name = "lblSinifSecimi";
            lblSinifSecimi.Size = new Size(69, 15);
            lblSinifSecimi.TabIndex = 3;
            lblSinifSecimi.Text = "Sınıf Seçiniz";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(19, 118);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(50, 15);
            lblNumara.TabIndex = 2;
            lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(19, 88);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(19, 51);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(167, 220);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 23);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(31, 220);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(116, 23);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(309, 220);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(116, 23);
            btnBul.TabIndex = 2;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnDersSecimi
            // 
            btnDersSecimi.Location = new Point(167, 266);
            btnDersSecimi.Name = "btnDersSecimi";
            btnDersSecimi.Size = new Size(120, 24);
            btnDersSecimi.TabIndex = 3;
            btnDersSecimi.Text = "Ders Seçimi";
            btnDersSecimi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 329);
            Controls.Add(btnDersSecimi);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(grpOgrenciBul);
            Name = "Form1";
            Text = "Bul";
            Load += Form1_Load;
            grpOgrenciBul.ResumeLayout(false);
            grpOgrenciBul.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOgrenciBul;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnBul;
        private Button btnDersSecimi;
        private ComboBox cbSinifSecimi;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label lblSinifSecimi;
        private Label lblNumara;
        private Label lblSoyad;
        private Label lblAd;
    }
}
