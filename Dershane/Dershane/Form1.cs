using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DershaneLib;
using System.IO;
using System.Collections;

namespace Dershane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            OgrenciEkle frm = new OgrenciEkle();
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            OgretmenEkle frm = new OgretmenEkle();
            frm.Show();
        }

        private void MenuOgrenci_Click_1(object sender, EventArgs e)
        {
            OgrenciListele frm = new OgrenciListele();
            frm.MdiParent = this;
            frm.Show();

            LMenuYazisi.Text = "ÖĞRENCİ MODÜLÜ";

            ToplamOgrenci();
        }

        private void MenuOgretmen_Click(object sender, EventArgs e)
        {
            OgretmenListele frm = new OgretmenListele();
            frm.MdiParent = this;
            frm.Show();

            LMenuYazisi.Text = "ÖĞRETMEN MODÜLÜ";   
        }

        private void MenuDevamsizlik_Click(object sender, EventArgs e)
        {
            DevamsizlikListe frm = new DevamsizlikListe();
            frm.MdiParent = this;
            frm.Show();

            LMenuYazisi.Text = "DEVAMSIZLIK MODÜLÜ";
        }

        private void MenuKursDers_Click(object sender, EventArgs e)
        {
            KursDers frm = new KursDers();
            frm.MdiParent = this;
            frm.Show();

            LMenuYazisi.Text = "KURS - DERS MODÜLÜ";   
        }

        private void MenuGrup_Click(object sender, EventArgs e)
        {
            Gruplar frm = new Gruplar();
            frm.MdiParent = this;
            frm.Show();

            LMenuYazisi.Text = "GRUP MODÜLÜ";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DevamsizlikEkle frm = new DevamsizlikEkle();
            frm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            GrupOlustur frm = new GrupOlustur();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToplamOgrenci();
            KullaniciAdi();
            
            LTarih.Text = DateTime.Now.ToString();
            
        }

        private void ToplamOgrenci()
        {
            int sonuc = 0;
            List<Ogrenci> toplam = new List<Ogrenci>();
            toplam = Ogrenci.Listele();
            for (int i = 0; i <= toplam.Count; i++)
            {
                sonuc = i;
            }

            LToplamOgrenci.Text = sonuc.ToString();
        }

        private void KullaniciAdi()
        {
            //Kullancı Adı Ayar.txt den okunuyor...
            StreamReader rd = new StreamReader("Ayar.txt");
            ArrayList sonuc = new ArrayList();
            while (rd.EndOfStream == false)
            {
                string kayit = rd.ReadLine();
                string[] alanlar = kayit.Split('=');
                sonuc.Add(alanlar[1]);
            }
            rd.Close();

            LKullaniciAdi.Text = sonuc[0].ToString();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            Hakkinda frm = new Hakkinda();
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Giris frm = new Giris();
            frm.Show();

            this.Visible = false;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Yardim frm = new Yardim();
            frm.MdiParent = this;
            frm.Show();

            LMenuYazisi.Text = "YARDIM";

        }

        private void MenuYardim_Click(object sender, EventArgs e)
        {
            Yardim frm = new Yardim();
            frm.MdiParent = this;
            frm.Show();

            LMenuYazisi.Text = "YARDIM";
        }
    }
}
