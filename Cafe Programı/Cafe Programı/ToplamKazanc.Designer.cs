namespace Cafe_Programı
{
    partial class ToplamKazanc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToplamKazanc));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblToplambirimtutar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamKDV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamtutar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 442);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblToplambirimtutar
            // 
            this.lblToplambirimtutar.AutoSize = true;
            this.lblToplambirimtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplambirimtutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplambirimtutar.Location = new System.Drawing.Point(473, 69);
            this.lblToplambirimtutar.Name = "lblToplambirimtutar";
            this.lblToplambirimtutar.Size = new System.Drawing.Size(0, 70);
            this.lblToplambirimtutar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(429, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Toplam Birim Kazanç";
            // 
            // lblToplamKDV
            // 
            this.lblToplamKDV.AutoSize = true;
            this.lblToplamKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKDV.ForeColor = System.Drawing.Color.Red;
            this.lblToplamKDV.Location = new System.Drawing.Point(500, 193);
            this.lblToplamKDV.Name = "lblToplamKDV";
            this.lblToplamKDV.Size = new System.Drawing.Size(0, 70);
            this.lblToplamKDV.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(479, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Toplam KDV";
            // 
            // lblToplamtutar
            // 
            this.lblToplamtutar.AutoSize = true;
            this.lblToplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamtutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamtutar.Location = new System.Drawing.Point(473, 304);
            this.lblToplamtutar.Name = "lblToplamtutar";
            this.lblToplamtutar.Size = new System.Drawing.Size(0, 70);
            this.lblToplamtutar.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(463, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Toplam Kazanç";
            // 
            // HesapKesimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 466);
            this.Controls.Add(this.lblToplamtutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblToplamKDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplambirimtutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HesapKesimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplam Kazanç";
            this.Load += new System.EventHandler(this.HesapKesimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblToplambirimtutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamKDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamtutar;
        private System.Windows.Forms.Label label5;

    }
}