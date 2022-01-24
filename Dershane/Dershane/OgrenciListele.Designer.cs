namespace Dershane
{
    partial class OgrenciListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciListele));
            this.dgOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.TCKimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BabaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeliAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CepTelefonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeliCepTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdagore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadagore = new System.Windows.Forms.TextBox();
            this.Filtre = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnOgrenciKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciListesi)).BeginInit();
            this.Filtre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOgrenciListesi
            // 
            this.dgOgrenciListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOgrenciListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TCKimlik,
            this.Adi,
            this.Soyadi,
            this.DogumTarihi,
            this.DogumYeri,
            this.BabaAdi,
            this.VeliAdi,
            this.CepTelefonu,
            this.VeliCepTelefon});
            this.dgOgrenciListesi.Location = new System.Drawing.Point(12, 175);
            this.dgOgrenciListesi.Name = "dgOgrenciListesi";
            this.dgOgrenciListesi.ReadOnly = true;
            this.dgOgrenciListesi.Size = new System.Drawing.Size(843, 510);
            this.dgOgrenciListesi.TabIndex = 0;
            // 
            // TCKimlik
            // 
            this.TCKimlik.DataPropertyName = "TCKimlik";
            this.TCKimlik.HeaderText = "T.C. Kimlik";
            this.TCKimlik.Name = "TCKimlik";
            this.TCKimlik.ReadOnly = true;
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "Adi";
            this.Adi.HeaderText = "Adı";
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            // 
            // Soyadi
            // 
            this.Soyadi.DataPropertyName = "Soyadi";
            this.Soyadi.HeaderText = "Soyadı";
            this.Soyadi.Name = "Soyadi";
            this.Soyadi.ReadOnly = true;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.DataPropertyName = "DogumTarihi";
            this.DogumTarihi.HeaderText = "Doğum Tarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.ReadOnly = true;
            // 
            // DogumYeri
            // 
            this.DogumYeri.DataPropertyName = "DogumYeri";
            this.DogumYeri.HeaderText = "Doğum Yeri";
            this.DogumYeri.Name = "DogumYeri";
            this.DogumYeri.ReadOnly = true;
            // 
            // BabaAdi
            // 
            this.BabaAdi.DataPropertyName = "BabaAdi";
            this.BabaAdi.HeaderText = "Baba Adı";
            this.BabaAdi.Name = "BabaAdi";
            this.BabaAdi.ReadOnly = true;
            // 
            // VeliAdi
            // 
            this.VeliAdi.DataPropertyName = "VeliAdi";
            this.VeliAdi.HeaderText = "Veli Adı";
            this.VeliAdi.Name = "VeliAdi";
            this.VeliAdi.ReadOnly = true;
            // 
            // CepTelefonu
            // 
            this.CepTelefonu.DataPropertyName = "CepTelefonu";
            this.CepTelefonu.HeaderText = "Cep Telefonu";
            this.CepTelefonu.Name = "CepTelefonu";
            this.CepTelefonu.ReadOnly = true;
            // 
            // VeliCepTelefon
            // 
            this.VeliCepTelefon.DataPropertyName = "VeliCepTelefonu";
            this.VeliCepTelefon.HeaderText = "Veli Cep Telefon";
            this.VeliCepTelefon.Name = "VeliCepTelefon";
            this.VeliCepTelefon.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // txtAdagore
            // 
            this.txtAdagore.Location = new System.Drawing.Point(231, 30);
            this.txtAdagore.Name = "txtAdagore";
            this.txtAdagore.Size = new System.Drawing.Size(125, 21);
            this.txtAdagore.TabIndex = 2;
            this.txtAdagore.TextChanged += new System.EventHandler(this.txtAdagore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyadı";
            // 
            // txtSoyadagore
            // 
            this.txtSoyadagore.Location = new System.Drawing.Point(231, 57);
            this.txtSoyadagore.Name = "txtSoyadagore";
            this.txtSoyadagore.Size = new System.Drawing.Size(125, 21);
            this.txtSoyadagore.TabIndex = 4;
            this.txtSoyadagore.TextChanged += new System.EventHandler(this.txtSoyadagore_TextChanged);
            // 
            // Filtre
            // 
            this.Filtre.Controls.Add(this.label4);
            this.Filtre.Controls.Add(this.label3);
            this.Filtre.Controls.Add(this.pictureBox1);
            this.Filtre.Controls.Add(this.txtAdagore);
            this.Filtre.Controls.Add(this.label1);
            this.Filtre.Controls.Add(this.txtSoyadagore);
            this.Filtre.Controls.Add(this.label2);
            this.Filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Filtre.Location = new System.Drawing.Point(12, 70);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(843, 99);
            this.Filtre.TabIndex = 6;
            this.Filtre.TabStop = false;
            this.Filtre.Text = "Filtre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = ":";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dershane.Properties.Resources.ara;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::Dershane.Properties.Resources.Sil;
            this.btnSil.Location = new System.Drawing.Point(266, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 41);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Image = global::Dershane.Properties.Resources.duzenle1;
            this.btnDuzenle.Location = new System.Drawing.Point(139, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(121, 41);
            this.btnDuzenle.TabIndex = 7;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnOgrenciKaydet
            // 
            this.btnOgrenciKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrenciKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciKaydet.Image = global::Dershane.Properties.Resources.yeni;
            this.btnOgrenciKaydet.Location = new System.Drawing.Point(12, 12);
            this.btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            this.btnOgrenciKaydet.Size = new System.Drawing.Size(121, 41);
            this.btnOgrenciKaydet.TabIndex = 5;
            this.btnOgrenciKaydet.Text = "Yeni Kayıt";
            this.btnOgrenciKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOgrenciKaydet.UseVisualStyleBackColor = true;
            this.btnOgrenciKaydet.Click += new System.EventHandler(this.btnOgrenciKaydet_Click);
            // 
            // OgrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 742);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.Filtre);
            this.Controls.Add(this.btnOgrenciKaydet);
            this.Controls.Add(this.dgOgrenciListesi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciListele";
            this.Text = "Öğrenci";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OgrenciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciListesi)).EndInit();
            this.Filtre.ResumeLayout(false);
            this.Filtre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOgrenciListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdagore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadagore;
        private System.Windows.Forms.Button btnOgrenciKaydet;
        private System.Windows.Forms.GroupBox Filtre;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCKimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn BabaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeliAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CepTelefonu;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeliCepTelefon;
    }
}