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

namespace Cafe_Programı
{
    public partial class HesapKapama : Form
    {
        public HesapKapama()
        {
            InitializeComponent();
        }

        /*Burada Masaların Hesaplarını ve Sipariş Listelerini Veri Kaynağından Okuma,
         *Masalardaki Hesapların Değişkenlere Atanması,
         *Masaların Sipariş Listesini ve Ödeyeceği Tutarı Ekranda Gösterdim.
         */

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList(); //Son Bilgileri Saklamak için Dizi Oluştur
            StreamReader rd = new StreamReader("Masa1.txt"); //Veri Kaynağından Oku
            string kayit = rd.ReadLine(); //Bir Satır Oku
            string[] liste = kayit.Split('|'); //Kelimelere Böl
            foreach (object A in liste) //Dizinin İçindeki Her Elemanı Al
            {
                sonuc.Add(A); //Elemanları Diziye Ekle
            }

            rd.Close(); //Bağlantıyı Kes

            for (int i = 0; i < sonuc.Count; i++) //Dizideki Elemanları Kadar Dön
            {
                listBox1.Items.Add(sonuc[i]); //Dizideki Elemanları ListBox da Göster
            }


            StreamReader sw = new StreamReader("Masa1Hesap.txt"); //Veri Kaynağından Oku
            string kayit2 = sw.ReadLine(); //Bir Satır Oku
            lblToplamtutar.Text = kayit2; //Satırı Ekrana Yazdır
            sw.Close(); //Bağlantıyı Kes
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa2.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa2Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa3.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa3Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa4.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa4Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa5.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa5Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa6.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa6Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa7.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa7Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa8.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa8Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa9.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa9Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa10.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa10Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa11_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa11.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa11Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa12_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa12.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa12Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa13_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa13.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa13Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa14_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa14.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa14Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }

        private void btnMasa15_Click(object sender, EventArgs e)
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Masa15.txt");
            string kayit = rd.ReadLine();
            string[] liste = kayit.Split('|');
            foreach (object A in liste)
            {
                sonuc.Add(A);
            }

            rd.Close();

            for (int i = 0; i < sonuc.Count; i++)
            {
                listBox1.Items.Add(sonuc[i]);
            }

            StreamReader sw = new StreamReader("Masa15Hesap.txt");
            string kayit2 = sw.ReadLine();
            lblToplamtutar.Text = kayit2;
            sw.Close();
        }
    }
}
