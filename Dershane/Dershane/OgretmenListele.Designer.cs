namespace Dershane
{
    partial class OgretmenListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenListele));
            this.btnOgretmenDuzenle = new System.Windows.Forms.Button();
            this.Filtre = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdagore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyadagore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgOgretmenListesi = new System.Windows.Forms.DataGridView();
            this.TCKimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BabaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvTelefonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CepTelefonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOgretmenSil = new System.Windows.Forms.Button();
            this.btnOgretmenKaydet = new System.Windows.Forms.Button();
            this.Filtre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgretmenListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOgretmenDuzenle
            // 
            this.btnOgretmenDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgretmenDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenDuzenle.Image = global::Dershane.Properties.Resources.duzenle1;
            this.btnOgretmenDuzenle.Location = new System.Drawing.Point(139, 12);
            this.btnOgretmenDuzenle.Name = "btnOgretmenDuzenle";
            this.btnOgretmenDuzenle.Size = new System.Drawing.Size(121, 41);
            this.btnOgretmenDuzenle.TabIndex = 12;
            this.btnOgretmenDuzenle.Text = "Düzenle";
            this.btnOgretmenDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOgretmenDuzenle.UseVisualStyleBackColor = true;
            this.btnOgretmenDuzenle.Click += new System.EventHandler(this.btnOgretmenDuzenle_Click);
            // 
            // Filtre
            // 
            this.Filtre.Controls.Add(this.label4);
            this.Filtre.Controls.Add(this.label3);
            this.Filtre.Controls.Add(this.txtAdagore);
            this.Filtre.Controls.Add(this.label1);
            this.Filtre.Controls.Add(this.txtSoyadagore);
            this.Filtre.Controls.Add(this.label2);
            this.Filtre.Controls.Add(this.pictureBox1);
            this.Filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Filtre.Location = new System.Drawing.Point(12, 70);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(843, 99);
            this.Filtre.TabIndex = 11;
            this.Filtre.TabStop = false;
            this.Filtre.Text = "Filtre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = ":";
            // 
            // txtAdagore
            // 
            this.txtAdagore.Location = new System.Drawing.Point(231, 29);
            this.txtAdagore.Name = "txtAdagore";
            this.txtAdagore.Size = new System.Drawing.Size(125, 21);
            this.txtAdagore.TabIndex = 16;
            this.txtAdagore.TextChanged += new System.EventHandler(this.txtAdagore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adı";
            // 
            // txtSoyadagore
            // 
            this.txtSoyadagore.Location = new System.Drawing.Point(231, 56);
            this.txtSoyadagore.Name = "txtSoyadagore";
            this.txtSoyadagore.Size = new System.Drawing.Size(125, 21);
            this.txtSoyadagore.TabIndex = 18;
            this.txtSoyadagore.TextChanged += new System.EventHandler(this.txtSoyadagore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Soyadı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dershane.Properties.Resources.ara;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dgOgretmenListesi
            // 
            this.dgOgretmenListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOgretmenListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgretmenListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TCKimlik,
            this.Adi,
            this.Soyadi,
            this.Brans,
            this.DogumTarihi,
            this.DogumYeri,
            this.BabaAdi,
            this.EvTelefonu,
            this.CepTelefonu});
            this.dgOgretmenListesi.Location = new System.Drawing.Point(12, 175);
            this.dgOgretmenListesi.Name = "dgOgretmenListesi";
            this.dgOgretmenListesi.Size = new System.Drawing.Size(843, 510);
            this.dgOgretmenListesi.TabIndex = 9;
            // 
            // TCKimlik
            // 
            this.TCKimlik.DataPropertyName = "TCKimlik";
            this.TCKimlik.HeaderText = "T.C. Kimlik";
            this.TCKimlik.Name = "TCKimlik";
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "Adi";
            this.Adi.HeaderText = "Adı";
            this.Adi.Name = "Adi";
            // 
            // Soyadi
            // 
            this.Soyadi.DataPropertyName = "Soyadi";
            this.Soyadi.HeaderText = "Soyadı";
            this.Soyadi.Name = "Soyadi";
            // 
            // Brans
            // 
            this.Brans.DataPropertyName = "Brans";
            this.Brans.HeaderText = "Brans";
            this.Brans.Name = "Brans";
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.DataPropertyName = "DogumTarihi";
            this.DogumTarihi.HeaderText = "Doğum Tarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            // 
            // DogumYeri
            // 
            this.DogumYeri.DataPropertyName = "DogumYeri";
            this.DogumYeri.HeaderText = "Doğum Yeri";
            this.DogumYeri.Name = "DogumYeri";
            // 
            // BabaAdi
            // 
            this.BabaAdi.DataPropertyName = "BabaAdi";
            this.BabaAdi.HeaderText = "Baba Adı";
            this.BabaAdi.Name = "BabaAdi";
            // 
            // EvTelefonu
            // 
            this.EvTelefonu.DataPropertyName = "EvTelefonu";
            this.EvTelefonu.HeaderText = "Ev Telefonu";
            this.EvTelefonu.Name = "EvTelefonu";
            // 
            // CepTelefonu
            // 
            this.CepTelefonu.DataPropertyName = "CepTelefonu";
            this.CepTelefonu.HeaderText = "Cep Telefonu";
            this.CepTelefonu.Name = "CepTelefonu";
            // 
            // btnOgretmenSil
            // 
            this.btnOgretmenSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgretmenSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenSil.Image = global::Dershane.Properties.Resources.Sil;
            this.btnOgretmenSil.Location = new System.Drawing.Point(266, 12);
            this.btnOgretmenSil.Name = "btnOgretmenSil";
            this.btnOgretmenSil.Size = new System.Drawing.Size(121, 41);
            this.btnOgretmenSil.TabIndex = 13;
            this.btnOgretmenSil.Text = "Sil";
            this.btnOgretmenSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOgretmenSil.UseVisualStyleBackColor = true;
            this.btnOgretmenSil.Click += new System.EventHandler(this.btnOgretmenSil_Click);
            // 
            // btnOgretmenKaydet
            // 
            this.btnOgretmenKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgretmenKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenKaydet.Image = global::Dershane.Properties.Resources.yeni;
            this.btnOgretmenKaydet.Location = new System.Drawing.Point(12, 12);
            this.btnOgretmenKaydet.Name = "btnOgretmenKaydet";
            this.btnOgretmenKaydet.Size = new System.Drawing.Size(121, 41);
            this.btnOgretmenKaydet.TabIndex = 10;
            this.btnOgretmenKaydet.Text = "Yeni Kayıt";
            this.btnOgretmenKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOgretmenKaydet.UseVisualStyleBackColor = true;
            this.btnOgretmenKaydet.Click += new System.EventHandler(this.btnOgretmenKaydet_Click);
            // 
            // OgretmenListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 742);
            this.Controls.Add(this.btnOgretmenSil);
            this.Controls.Add(this.btnOgretmenDuzenle);
            this.Controls.Add(this.Filtre);
            this.Controls.Add(this.btnOgretmenKaydet);
            this.Controls.Add(this.dgOgretmenListesi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgretmenListele";
            this.Text = "Öğretmen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OgretmenListele_Load);
            this.Filtre.ResumeLayout(false);
            this.Filtre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgretmenListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgretmenSil;
        private System.Windows.Forms.Button btnOgretmenDuzenle;
        private System.Windows.Forms.GroupBox Filtre;
        private System.Windows.Forms.Button btnOgretmenKaydet;
        private System.Windows.Forms.DataGridView dgOgretmenListesi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdagore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyadagore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCKimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brans;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn BabaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvTelefonu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CepTelefonu;
    }
}