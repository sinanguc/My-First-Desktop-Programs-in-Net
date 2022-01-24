using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Dershane
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            StreamReader rd = new StreamReader("Ayar.txt");
            ArrayList sonuc = new ArrayList();
            while (rd.EndOfStream == false)
            {
                string kayit = rd.ReadLine();
                string[] alanlar = kayit.Split('=');

                sonuc.Add(alanlar[1]);
            }
            rd.Close();            


            if (txtKullaniciAdi.Text == sonuc[0].ToString() && txtSifre.Text == sonuc[1].ToString())
            {                
                Form1 frm = new Form1();
                frm.Show();

                this.Visible = false;                
                
            }
            else
            {
                
                if (txtKullaniciAdi.Text == "")
                {
                    MessageBox.Show("Kullancı Adı Girilmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (txtSifre.Text == "")
                {
                    MessageBox.Show("Şifre Girilmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (txtSifre.Text != sonuc[1].ToString())
                {
                    MessageBox.Show("Şifre Hatalı Girildi. Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (txtKullaniciAdi.Text != sonuc[0].ToString())
                {
                    MessageBox.Show("Kullanıcı Adı Hatalı Girildi. Lütfen Tekrar Deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
                
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yedek frm = new yedek();
            frm.Show();
        }
    }
}
