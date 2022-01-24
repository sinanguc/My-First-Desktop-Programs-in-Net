namespace Dershane
{
    partial class DevamsizlikListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevamsizlikListe));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnDevamsizlikisle = new System.Windows.Forms.Button();
            this.Filtre = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAdagore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyadagore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDevamsizlikListesi = new System.Windows.Forms.DataGridView();
            this.GrupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCKimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BabaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDevamsizlikDetay = new System.Windows.Forms.DataGridView();
            this.DersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filtre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevamsizlikListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevamsizlikDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::Dershane.Properties.Resources.Sil;
            this.btnSil.Location = new System.Drawing.Point(276, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 41);
            this.btnSil.TabIndex = 13;
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
            this.btnDuzenle.Location = new System.Drawing.Point(149, 12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(121, 41);
            this.btnDuzenle.TabIndex = 12;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnDevamsizlikisle
            // 
            this.btnDevamsizlikisle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevamsizlikisle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevamsizlikisle.Image = global::Dershane.Properties.Resources.yeni;
            this.btnDevamsizlikisle.Location = new System.Drawing.Point(12, 12);
            this.btnDevamsizlikisle.Name = "btnDevamsizlikisle";
            this.btnDevamsizlikisle.Size = new System.Drawing.Size(131, 41);
            this.btnDevamsizlikisle.TabIndex = 10;
            this.btnDevamsizlikisle.Text = "Devamsızlık Ekle";
            this.btnDevamsizlikisle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevamsizlikisle.UseVisualStyleBackColor = true;
            this.btnDevamsizlikisle.Click += new System.EventHandler(this.btnDevamsizlikisle_Click);
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
            this.Filtre.Location = new System.Drawing.Point(12, 59);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(843, 99);
            this.Filtre.TabIndex = 22;
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
            this.txtAdagore.Location = new System.Drawing.Point(231, 30);
            this.txtAdagore.Name = "txtAdagore";
            this.txtAdagore.Size = new System.Drawing.Size(125, 21);
            this.txtAdagore.TabIndex = 2;
            this.txtAdagore.TextChanged += new System.EventHandler(this.txtAdagore_TextChanged);
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
            // txtSoyadagore
            // 
            this.txtSoyadagore.Location = new System.Drawing.Point(231, 57);
            this.txtSoyadagore.Name = "txtSoyadagore";
            this.txtSoyadagore.Size = new System.Drawing.Size(125, 21);
            this.txtSoyadagore.TabIndex = 4;
            this.txtSoyadagore.TextChanged += new System.EventHandler(this.txtSoyadagore_TextChanged);
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
            // dgDevamsizlikListesi
            // 
            this.dgDevamsizlikListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDevamsizlikListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrupNo,
            this.GrupAdi,
            this.TCKimlik,
            this.Adi,
            this.Soyadi,
            this.BabaAdi});
            this.dgDevamsizlikListesi.Location = new System.Drawing.Point(12, 164);
            this.dgDevamsizlikListesi.Name = "dgDevamsizlikListesi";
            this.dgDevamsizlikListesi.Size = new System.Drawing.Size(643, 510);
            this.dgDevamsizlikListesi.TabIndex = 21;
            this.dgDevamsizlikListesi.SelectionChanged += new System.EventHandler(this.dgDevamsizlikListesi_SelectionChanged);
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
            // TCKimlik
            // 
            this.TCKimlik.DataPropertyName = "TCKimlik";
            this.TCKimlik.HeaderText = "T.C. Kimlik";
            this.TCKimlik.Name = "TCKimlik";
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "Adi";
            this.Adi.HeaderText = "Adi";
            this.Adi.Name = "Adi";
            // 
            // Soyadi
            // 
            this.Soyadi.DataPropertyName = "Soyadi";
            this.Soyadi.HeaderText = "Soyadı";
            this.Soyadi.Name = "Soyadi";
            // 
            // BabaAdi
            // 
            this.BabaAdi.DataPropertyName = "BabaAdi";
            this.BabaAdi.HeaderText = "Baba Adı";
            this.BabaAdi.Name = "BabaAdi";
            // 
            // dgDevamsizlikDetay
            // 
            this.dgDevamsizlikDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDevamsizlikDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDevamsizlikDetay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DersAdi,
            this.DersSaat});
            this.dgDevamsizlikDetay.Location = new System.Drawing.Point(662, 165);
            this.dgDevamsizlikDetay.Name = "dgDevamsizlikDetay";
            this.dgDevamsizlikDetay.Size = new System.Drawing.Size(193, 509);
            this.dgDevamsizlikDetay.TabIndex = 23;
            // 
            // DersAdi
            // 
            this.DersAdi.DataPropertyName = "Adi";
            this.DersAdi.HeaderText = "Ders Adı";
            this.DersAdi.Name = "DersAdi";
            // 
            // DersSaat
            // 
            this.DersSaat.DataPropertyName = "DersSaat";
            this.DersSaat.HeaderText = "Saat";
            this.DersSaat.Name = "DersSaat";
            // 
            // DevamsizlikListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 742);
            this.Controls.Add(this.dgDevamsizlikDetay);
            this.Controls.Add(this.Filtre);
            this.Controls.Add(this.dgDevamsizlikListesi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnDevamsizlikisle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevamsizlikListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devamsızlık";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DevamsizlikListe_Load);
            this.Filtre.ResumeLayout(false);
            this.Filtre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevamsizlikListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevamsizlikDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnDevamsizlikisle;
        private System.Windows.Forms.GroupBox Filtre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAdagore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyadagore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgDevamsizlikListesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCKimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BabaAdi;
        private System.Windows.Forms.DataGridView dgDevamsizlikDetay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersSaat;
    }
}