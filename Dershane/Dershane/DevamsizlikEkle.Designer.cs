namespace Dershane
{
    partial class DevamsizlikEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevamsizlikEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDevamsizSaat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDersler = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDevamsizlikEkle = new System.Windows.Forms.ToolStripButton();
            this.btnVazgec = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbOgrenci = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDevamsizlikTarih = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(446, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = ":";
            // 
            // txtDevamsizSaat
            // 
            this.txtDevamsizSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDevamsizSaat.Location = new System.Drawing.Point(475, 325);
            this.txtDevamsizSaat.MaxLength = 3;
            this.txtDevamsizSaat.Name = "txtDevamsizSaat";
            this.txtDevamsizSaat.Size = new System.Drawing.Size(79, 21);
            this.txtDevamsizSaat.TabIndex = 42;
            this.txtDevamsizSaat.Enter += new System.EventHandler(this.txtDevamsizSaat_Enter);
            this.txtDevamsizSaat.Leave += new System.EventHandler(this.txtDevamsizSaat_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(315, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Kaç Saat Devamsız";
            // 
            // lbDersler
            // 
            this.lbDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDersler.FormattingEnabled = true;
            this.lbDersler.ItemHeight = 15;
            this.lbDersler.Location = new System.Drawing.Point(19, 26);
            this.lbDersler.Name = "lbDersler";
            this.lbDersler.Size = new System.Drawing.Size(159, 229);
            this.lbDersler.TabIndex = 53;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDevamsizlikEkle,
            this.btnVazgec,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 381);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(621, 55);
            this.toolStrip1.TabIndex = 54;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDevamsizlikEkle
            // 
            this.btnDevamsizlikEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDevamsizlikEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDevamsizlikEkle.Image")));
            this.btnDevamsizlikEkle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDevamsizlikEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDevamsizlikEkle.Name = "btnDevamsizlikEkle";
            this.btnDevamsizlikEkle.Size = new System.Drawing.Size(52, 52);
            this.btnDevamsizlikEkle.Text = "Devamsızlık Ekle";
            this.btnDevamsizlikEkle.Click += new System.EventHandler(this.btnDevamsizlikEkle_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnVazgec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVazgec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(52, 52);
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 52);
            this.toolStripLabel1.Text = "Kaydet";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(57, 52);
            this.toolStripLabel2.Text = "Vazgeç";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDersler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(370, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 274);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Listesi";
            // 
            // lbOgrenci
            // 
            this.lbOgrenci.FormattingEnabled = true;
            this.lbOgrenci.ItemHeight = 15;
            this.lbOgrenci.Location = new System.Drawing.Point(18, 26);
            this.lbOgrenci.Name = "lbOgrenci";
            this.lbOgrenci.Size = new System.Drawing.Size(231, 229);
            this.lbOgrenci.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbOgrenci);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(58, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 274);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(143, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(73, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Tarih";
            // 
            // dtDevamsizlikTarih
            // 
            this.dtDevamsizlikTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDevamsizlikTarih.Location = new System.Drawing.Point(160, 328);
            this.dtDevamsizlikTarih.Name = "dtDevamsizlikTarih";
            this.dtDevamsizlikTarih.Size = new System.Drawing.Size(115, 20);
            this.dtDevamsizlikTarih.TabIndex = 60;
            // 
            // DevamsizlikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 436);
            this.Controls.Add(this.dtDevamsizlikTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDevamsizSaat);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevamsizlikEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devamsızlık Ekranı";
            this.Load += new System.EventHandler(this.DevamsizlikEkle_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDevamsizSaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDersler;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDevamsizlikEkle;
        private System.Windows.Forms.ToolStripButton btnVazgec;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbOgrenci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDevamsizlikTarih;
    }
}