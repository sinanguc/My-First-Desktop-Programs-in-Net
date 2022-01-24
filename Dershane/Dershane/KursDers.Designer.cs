namespace Dershane
{
    partial class KursDers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KursDers));
            this.lbKursListesi = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKursSil = new System.Windows.Forms.Button();
            this.btnKursDuzenle = new System.Windows.Forms.Button();
            this.btnKursEkle = new System.Windows.Forms.Button();
            this.txtKursAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersDuzenle = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.lbDersListesi = new System.Windows.Forms.ListBox();
            this.cmbKurslar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKursDersleri = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDersler = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKurstanCikar = new System.Windows.Forms.Button();
            this.btnKursaEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKursListesi
            // 
            this.lbKursListesi.FormattingEnabled = true;
            this.lbKursListesi.ItemHeight = 15;
            this.lbKursListesi.Location = new System.Drawing.Point(15, 72);
            this.lbKursListesi.Name = "lbKursListesi";
            this.lbKursListesi.Size = new System.Drawing.Size(172, 169);
            this.lbKursListesi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKursSil);
            this.groupBox1.Controls.Add(this.btnKursDuzenle);
            this.groupBox1.Controls.Add(this.btnKursEkle);
            this.groupBox1.Controls.Add(this.txtKursAdi);
            this.groupBox1.Controls.Add(this.lbKursListesi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurs";
            // 
            // btnKursSil
            // 
            this.btnKursSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKursSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKursSil.Image = global::Dershane.Properties.Resources.silufak;
            this.btnKursSil.Location = new System.Drawing.Point(112, 251);
            this.btnKursSil.Name = "btnKursSil";
            this.btnKursSil.Size = new System.Drawing.Size(75, 23);
            this.btnKursSil.TabIndex = 4;
            this.btnKursSil.Text = "Sil";
            this.btnKursSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKursSil.UseVisualStyleBackColor = true;
            this.btnKursSil.Click += new System.EventHandler(this.btnKursSil_Click);
            // 
            // btnKursDuzenle
            // 
            this.btnKursDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKursDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKursDuzenle.Image = global::Dershane.Properties.Resources.duzenleufak;
            this.btnKursDuzenle.Location = new System.Drawing.Point(15, 251);
            this.btnKursDuzenle.Name = "btnKursDuzenle";
            this.btnKursDuzenle.Size = new System.Drawing.Size(78, 23);
            this.btnKursDuzenle.TabIndex = 3;
            this.btnKursDuzenle.Text = "Düzenle";
            this.btnKursDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKursDuzenle.UseVisualStyleBackColor = true;
            this.btnKursDuzenle.Click += new System.EventHandler(this.btnKursDuzenle_Click);
            // 
            // btnKursEkle
            // 
            this.btnKursEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKursEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKursEkle.Location = new System.Drawing.Point(142, 35);
            this.btnKursEkle.Name = "btnKursEkle";
            this.btnKursEkle.Size = new System.Drawing.Size(45, 23);
            this.btnKursEkle.TabIndex = 2;
            this.btnKursEkle.Text = "Ekle";
            this.btnKursEkle.UseVisualStyleBackColor = true;
            this.btnKursEkle.Click += new System.EventHandler(this.btnKursEkle_Click);
            // 
            // txtKursAdi
            // 
            this.txtKursAdi.Location = new System.Drawing.Point(15, 37);
            this.txtKursAdi.MaxLength = 50;
            this.txtKursAdi.Name = "txtKursAdi";
            this.txtKursAdi.Size = new System.Drawing.Size(121, 21);
            this.txtKursAdi.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDersSil);
            this.groupBox2.Controls.Add(this.btnDersDuzenle);
            this.groupBox2.Controls.Add(this.btnDersEkle);
            this.groupBox2.Controls.Add(this.txtDersAdi);
            this.groupBox2.Controls.Add(this.lbDersListesi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(304, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 316);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders";
            // 
            // btnDersSil
            // 
            this.btnDersSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDersSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersSil.Image = global::Dershane.Properties.Resources.silufak;
            this.btnDersSil.Location = new System.Drawing.Point(112, 251);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(75, 23);
            this.btnDersSil.TabIndex = 4;
            this.btnDersSil.Text = "Sil";
            this.btnDersSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersDuzenle
            // 
            this.btnDersDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDersDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersDuzenle.Image = global::Dershane.Properties.Resources.duzenleufak;
            this.btnDersDuzenle.Location = new System.Drawing.Point(15, 251);
            this.btnDersDuzenle.Name = "btnDersDuzenle";
            this.btnDersDuzenle.Size = new System.Drawing.Size(78, 23);
            this.btnDersDuzenle.TabIndex = 3;
            this.btnDersDuzenle.Text = "Düzenle";
            this.btnDersDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDersDuzenle.UseVisualStyleBackColor = true;
            this.btnDersDuzenle.Click += new System.EventHandler(this.btnDersDuzenle_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.Location = new System.Drawing.Point(142, 35);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(45, 23);
            this.btnDersEkle.TabIndex = 2;
            this.btnDersEkle.Text = "Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(15, 37);
            this.txtDersAdi.MaxLength = 50;
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(121, 21);
            this.txtDersAdi.TabIndex = 1;
            // 
            // lbDersListesi
            // 
            this.lbDersListesi.FormattingEnabled = true;
            this.lbDersListesi.ItemHeight = 15;
            this.lbDersListesi.Location = new System.Drawing.Point(15, 72);
            this.lbDersListesi.Name = "lbDersListesi";
            this.lbDersListesi.Size = new System.Drawing.Size(172, 169);
            this.lbDersListesi.TabIndex = 0;
            // 
            // cmbKurslar
            // 
            this.cmbKurslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKurslar.FormattingEnabled = true;
            this.cmbKurslar.Location = new System.Drawing.Point(74, 26);
            this.cmbKurslar.Name = "cmbKurslar";
            this.cmbKurslar.Size = new System.Drawing.Size(136, 23);
            this.cmbKurslar.TabIndex = 3;
            this.cmbKurslar.SelectedIndexChanged += new System.EventHandler(this.cmbKurslar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kurslar";
            // 
            // lbKursDersleri
            // 
            this.lbKursDersleri.FormattingEnabled = true;
            this.lbKursDersleri.ItemHeight = 15;
            this.lbKursDersleri.Location = new System.Drawing.Point(15, 92);
            this.lbKursDersleri.Name = "lbKursDersleri";
            this.lbKursDersleri.Size = new System.Drawing.Size(186, 154);
            this.lbKursDersleri.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kurs\'un Dersleri";
            // 
            // lbDersler
            // 
            this.lbDersler.FormattingEnabled = true;
            this.lbDersler.ItemHeight = 15;
            this.lbDersler.Location = new System.Drawing.Point(265, 92);
            this.lbDersler.Name = "lbDersler";
            this.lbDersler.Size = new System.Drawing.Size(200, 154);
            this.lbDersler.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnKurstanCikar);
            this.groupBox3.Controls.Add(this.cmbKurslar);
            this.groupBox3.Controls.Add(this.btnKursaEkle);
            this.groupBox3.Controls.Add(this.lbKursDersleri);
            this.groupBox3.Controls.Add(this.lbDersler);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(24, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 274);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kurs\'a Ders Ekleme";
            // 
            // btnKurstanCikar
            // 
            this.btnKurstanCikar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKurstanCikar.Image = global::Dershane.Properties.Resources.sagOK;
            this.btnKurstanCikar.Location = new System.Drawing.Point(208, 175);
            this.btnKurstanCikar.Name = "btnKurstanCikar";
            this.btnKurstanCikar.Size = new System.Drawing.Size(51, 57);
            this.btnKurstanCikar.TabIndex = 9;
            this.btnKurstanCikar.UseVisualStyleBackColor = true;
            this.btnKurstanCikar.Click += new System.EventHandler(this.btnKurstanCikar_Click);
            // 
            // btnKursaEkle
            // 
            this.btnKursaEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKursaEkle.Image = global::Dershane.Properties.Resources.solOK;
            this.btnKursaEkle.Location = new System.Drawing.Point(208, 112);
            this.btnKursaEkle.Name = "btnKursaEkle";
            this.btnKursaEkle.Size = new System.Drawing.Size(51, 57);
            this.btnKursaEkle.TabIndex = 8;
            this.btnKursaEkle.UseVisualStyleBackColor = true;
            this.btnKursaEkle.Click += new System.EventHandler(this.btnKursaEkle_Click);
            // 
            // KursDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 742);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KursDers";
            this.Text = "Kurs - Ders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KursDers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKursListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKursSil;
        private System.Windows.Forms.Button btnKursDuzenle;
        private System.Windows.Forms.Button btnKursEkle;
        private System.Windows.Forms.TextBox txtKursAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersDuzenle;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.ListBox lbDersListesi;
        private System.Windows.Forms.ComboBox cmbKurslar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKursDersleri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDersler;
        private System.Windows.Forms.Button btnKursaEkle;
        private System.Windows.Forms.Button btnKurstanCikar;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}