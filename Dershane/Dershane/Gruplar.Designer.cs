namespace Dershane
{
    partial class Gruplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gruplar));
            this.Filtre = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAdagore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgGrupListesi = new System.Windows.Forms.DataGridView();
            this.GrupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontenjan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnGrupOlustur = new System.Windows.Forms.Button();
            this.dgGrupOgrencileri = new System.Windows.Forms.DataGridView();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filtre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrupListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrupOgrencileri)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtre
            // 
            this.Filtre.Controls.Add(this.label4);
            this.Filtre.Controls.Add(this.pictureBox1);
            this.Filtre.Controls.Add(this.txtAdagore);
            this.Filtre.Controls.Add(this.label2);
            this.Filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Filtre.Location = new System.Drawing.Point(12, 70);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(843, 99);
            this.Filtre.TabIndex = 20;
            this.Filtre.TabStop = false;
            this.Filtre.Text = "Filtre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = ":";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dershane.Properties.Resources.ara__2_;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtAdagore
            // 
            this.txtAdagore.Location = new System.Drawing.Point(233, 44);
            this.txtAdagore.Name = "txtAdagore";
            this.txtAdagore.Size = new System.Drawing.Size(125, 21);
            this.txtAdagore.TabIndex = 4;
            this.txtAdagore.TextChanged += new System.EventHandler(this.txtAdagore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grup Adı";
            // 
            // dgGrupListesi
            // 
            this.dgGrupListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrupListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrupNo,
            this.GrupAdi,
            this.Turu,
            this.BaslamaTarih,
            this.BitisTarih,
            this.Kontenjan});
            this.dgGrupListesi.Location = new System.Drawing.Point(12, 175);
            this.dgGrupListesi.Name = "dgGrupListesi";
            this.dgGrupListesi.Size = new System.Drawing.Size(643, 510);
            this.dgGrupListesi.TabIndex = 19;
            this.dgGrupListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGrupListesi_CellContentClick);
            this.dgGrupListesi.SelectionChanged += new System.EventHandler(this.dgGrupListesi_SelectionChanged);
            // 
            // GrupNo
            // 
            this.GrupNo.DataPropertyName = "GrupNo";
            this.GrupNo.HeaderText = "Grup No";
            this.GrupNo.Name = "GrupNo";
            // 
            // GrupAdi
            // 
            this.GrupAdi.DataPropertyName = "GrupAdi";
            this.GrupAdi.HeaderText = "Grup Adı";
            this.GrupAdi.Name = "GrupAdi";
            // 
            // Turu
            // 
            this.Turu.DataPropertyName = "Turu";
            this.Turu.HeaderText = "Turu";
            this.Turu.Name = "Turu";
            // 
            // BaslamaTarih
            // 
            this.BaslamaTarih.DataPropertyName = "BaslamaTarihi";
            this.BaslamaTarih.HeaderText = "Baslama Tarihi";
            this.BaslamaTarih.Name = "BaslamaTarih";
            // 
            // BitisTarih
            // 
            this.BitisTarih.DataPropertyName = "BitisTarihi";
            this.BitisTarih.HeaderText = "Bitiş Tarihi";
            this.BitisTarih.Name = "BitisTarih";
            // 
            // Kontenjan
            // 
            this.Kontenjan.DataPropertyName = "Kontenjan";
            this.Kontenjan.HeaderText = "Kontenjan";
            this.Kontenjan.Name = "Kontenjan";
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::Dershane.Properties.Resources.Sil;
            this.btnSil.Location = new System.Drawing.Point(266, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 41);
            this.btnSil.TabIndex = 18;
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
            this.btnDuzenle.TabIndex = 17;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnGrupOlustur
            // 
            this.btnGrupOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrupOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrupOlustur.Image = global::Dershane.Properties.Resources.yeni;
            this.btnGrupOlustur.Location = new System.Drawing.Point(12, 12);
            this.btnGrupOlustur.Name = "btnGrupOlustur";
            this.btnGrupOlustur.Size = new System.Drawing.Size(121, 41);
            this.btnGrupOlustur.TabIndex = 15;
            this.btnGrupOlustur.Text = "Grup Oluştur";
            this.btnGrupOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrupOlustur.UseVisualStyleBackColor = true;
            this.btnGrupOlustur.Click += new System.EventHandler(this.btnGrupOlustur_Click);
            // 
            // dgGrupOgrencileri
            // 
            this.dgGrupOgrencileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGrupOgrencileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrupOgrencileri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adi,
            this.Soyadi});
            this.dgGrupOgrencileri.Location = new System.Drawing.Point(662, 175);
            this.dgGrupOgrencileri.Name = "dgGrupOgrencileri";
            this.dgGrupOgrencileri.Size = new System.Drawing.Size(193, 510);
            this.dgGrupOgrencileri.TabIndex = 21;
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
            // Gruplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 742);
            this.Controls.Add(this.dgGrupOgrencileri);
            this.Controls.Add(this.Filtre);
            this.Controls.Add(this.dgGrupListesi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnGrupOlustur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gruplar";
            this.Text = "Grup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Gruplar_Load);
            this.Filtre.ResumeLayout(false);
            this.Filtre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrupListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrupOgrencileri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnGrupOlustur;
        private System.Windows.Forms.GroupBox Filtre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAdagore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgGrupListesi;
        private System.Windows.Forms.DataGridView dgGrupOgrencileri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontenjan;
    }
}