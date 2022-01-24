using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CafeLib;
using System.IO;

namespace Cafe_Programı
{
    /*Burada Siparişlerin Alınmasını Yaptım,
     *Kullanıcı Sipariş Listesine Eklemek İstediği Verileri Ürün Resimlerine Tıklayarak Seçer, 
     *Seçilen Ürünler ListBox da Listelenir,
     *Kullanıcı Hesapla Butonuna Bastığında Siparişin Birim Tutarı, KDV ve Toplam Tutarı Ekranda Görünür,
     *Sipariş Tamamlandığında Ekranda Gösterilen Bilgiler Veri Kaynağına Kayıt Edilir.
     */

    public partial class SiparisEkrani : Form
    {
        ArrayList siparisler = new ArrayList();

        public SiparisEkrani()
        {
            InitializeComponent();
        }

        private void SiparisEkrani_Load(object sender, EventArgs e)
        {
            //Sipariş Ekranındaki ComboBox'a Masa Ekleme...
            cmbMasalar.Items.Add("Bir Masa Seçiniz");
            cmbMasalar.Items.Add("Masa 1");
            cmbMasalar.Items.Add("Masa 2");
            cmbMasalar.Items.Add("Masa 3");
            cmbMasalar.Items.Add("Masa 4");
            cmbMasalar.Items.Add("Masa 5");
            cmbMasalar.Items.Add("Masa 6");
            cmbMasalar.Items.Add("Masa 7");
            cmbMasalar.Items.Add("Masa 8");
            cmbMasalar.Items.Add("Masa 9");
            cmbMasalar.Items.Add("Masa 10");
            cmbMasalar.Items.Add("Masa 11");
            cmbMasalar.Items.Add("Masa 12");
            cmbMasalar.Items.Add("Masa 13");
            cmbMasalar.Items.Add("Masa 14");
            cmbMasalar.Items.Add("Masa 15");

            cmbMasalar.SelectedIndex = 0;

        }

        //Sipariş Tamamlama İşlemi Burada Yapılıyor...
        private void btnSiparistamamla_Click(object sender, EventArgs e)
        {

            Siparis S = new Siparis(); //Siparişleri Verilerini Tutmak için Dizi Oluştur
            S.Masalar = cmbMasalar.Text;
            S.Tarih = DateTime.Parse(dateTarih.Text);
            S.BirimTutar = decimal.Parse(txtBirimtutar.Text);
            S.Kdv = decimal.Parse(txtKDV.Text);
            S.ToplamTutar = decimal.Parse(txtToplamtutar.Text);
            S.Kaydet();

            if (cmbMasalar.SelectedIndex == 1) //Eğer Masa 1 Seçilirse...
            {
                StreamWriter sw = new StreamWriter("Masa1.txt"); //Yazılacak Veri Kaynağı Belirle
                foreach (object liste in lbSiparislistesi.Items) //Listbox daki her yazıyı al
                {
                    sw.Write(liste.ToString()); //Alınan Yazıları Veri Kaynağına Yaz
                    sw.Write("|"); //Alınan Yazıları | İşareti ile Ayır
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa1Hesap.txt"); //Yazılacak Veri Kaynağı Belirle
                hesap.Write(txtToplamtutar.Text); //TextBox daki Rakamı Veri Kaynağına Ekle
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 2)
            {
                StreamWriter sw = new StreamWriter("Masa2.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa2Hesap.txt");
                hesap.Write(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 3)
            {
                StreamWriter sw = new StreamWriter("Masa3.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa3Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 4)
            {
                StreamWriter sw = new StreamWriter("Masa4.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa4Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 5)
            {
                StreamWriter sw = new StreamWriter("Masa5.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa5Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 6)
            {
                StreamWriter sw = new StreamWriter("Masa6.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa6Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 7)
            {
                StreamWriter sw = new StreamWriter("Masa7.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa7Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 8)
            {
                StreamWriter sw = new StreamWriter("Masa8.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa8Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 9)
            {
                StreamWriter sw = new StreamWriter("Masa9.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa9Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 10)
            {
                StreamWriter sw = new StreamWriter("Masa10.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa10Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 11)
            {
                StreamWriter sw = new StreamWriter("Masa11.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa11Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 12)
            {
                StreamWriter sw = new StreamWriter("Masa12.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa12Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 13)
            {
                StreamWriter sw = new StreamWriter("Masa13.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa13Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 14)
            {
                StreamWriter sw = new StreamWriter("Masa14.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa14Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }

            if (cmbMasalar.SelectedIndex == 15)
            {
                StreamWriter sw = new StreamWriter("Masa15.txt");
                foreach (object liste in lbSiparislistesi.Items)
                {
                    sw.Write(liste.ToString());
                    sw.Write("|");
                }
                sw.Write("");
                sw.Close();

                StreamWriter hesap = new StreamWriter("Masa15Hesap.txt");
                hesap.WriteLine(txtToplamtutar.Text);
                hesap.Close();
                this.Close();
            }
        }

        //Hesaplama İşlemi Burada Yapılıyor...
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal birimTutar = 0;
            decimal birimTutar2;

            for (int i = 0; i < siparisler.Count; i++)
            {
                birimTutar += int.Parse(siparisler[i].ToString());
            }

            txtBirimtutar.Text = birimTutar.ToString();
            birimTutar2 = decimal.Parse(txtBirimtutar.Text);

            decimal kdv = birimTutar2 * 18 / 100;
            txtKDV.Text = kdv.ToString();

            decimal toplamTutar = birimTutar2 + kdv;
            txtToplamtutar.Text = toplamTutar.ToString();

            btnHesapla.Enabled = false;
        }

        //Pizzalar Burada...
        private void karisikmantarlipizza_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Karışık Mantarlı Pizza");
            siparisler.Add(10);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Karışık Pizza");
            siparisler.Add(12);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Mantarlı Pizza");
            siparisler.Add(8);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Parça Pizza");
            siparisler.Add(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Special Pizza");
            siparisler.Add(15);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Salamlı Pizza");
            siparisler.Add(8);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Sosisli Pizza");
            siparisler.Add(8);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Sucuklu Pizza");
            siparisler.Add(8);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Vejeteryan Pizza");
            siparisler.Add(8);
        }

        //Kumpirler Burada...
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Etli Kumpir");
            siparisler.Add(7);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Mantarlı Kumpir");
            siparisler.Add(6);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Sade Kumpir");
            siparisler.Add(4);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Special Kumpir");
            siparisler.Add(7);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Sütlü Kumpir");
            siparisler.Add(5);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Tam Karışık Kumpir");
            siparisler.Add(6);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Ton Balıklı Kumpir");
            siparisler.Add(7);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Ultra Sade Kumpir");
            siparisler.Add(4);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Vejeteryan Kumpir");
            siparisler.Add(6);
        }

        //Tatlılar Burada...
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Sufle");
            siparisler.Add(3);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Fırın Sütlaç");
            siparisler.Add(3);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Kazandibi");
            siparisler.Add(3);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Keşkül");
            siparisler.Add(3);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Supangle");
            siparisler.Add(3);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Tavuk Göğsü");
            siparisler.Add(3);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Profiterol");
            siparisler.Add(4);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Dilim Pasta");
            siparisler.Add(4);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Sakızlı Muhallebi");
            siparisler.Add(3);
        }

        //İçecekler Burada...
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Sütaş Ayran");
            siparisler.Add(1);
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Coca Cola");
            siparisler.Add(2);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Coca Cola Light");
            siparisler.Add(2);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Coca Cola Zero");
            siparisler.Add(2);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Fanta");
            siparisler.Add(2);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Nestea");
            siparisler.Add(2);
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Sprite");
            siparisler.Add(2);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Cappy");
            siparisler.Add(2);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Soda");
            siparisler.Add(1);
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Su");
            siparisler.Add(1);
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Schweppes");
            siparisler.Add(2);
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            lbSiparislistesi.Items.Add("Üzüm Suyu");
            siparisler.Add(1);
        }
    }
}
