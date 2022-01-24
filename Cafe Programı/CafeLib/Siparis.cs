using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace CafeLib
{
    public class Siparis
    {

        private string masalar = "";
        public string Masalar { get { return masalar; } set { masalar = value; } }

        private DateTime tarih;
        public DateTime Tarih
        {
            get
            {
                return tarih;
            }
            set
            {
                if (value < DateTime.Today)
                {
                    throw new Exception("Eski Bir Tarih Girdiniz");
                }
                else
                {
                    tarih = value;
                }
            }
        }

        private decimal birimTutar;
        public decimal BirimTutar { get { return birimTutar; } set { birimTutar = value; } }

        private decimal kdv;
        public decimal Kdv { get { return kdv; } set { kdv = value; } }

        private decimal toplamTutar;
        public decimal ToplamTutar { get { return toplamTutar; } set { toplamTutar = value; } }

        public void Kaydet()
        {
            StreamWriter sw = new StreamWriter("Siparişler.txt", true);
            string kayit = masalar.ToString() + "|" + tarih.ToShortDateString() + "|" + birimTutar.ToString()
            + "|" + kdv + "|" + toplamTutar.ToString();
            sw.WriteLine(kayit);
            sw.Close();
        }

        public static ArrayList Listele()
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Siparişler.txt");

            while (rd.EndOfStream == false) //Dosyanın son satırına kadar oku
            {
                string kayit = rd.ReadLine(); //Dosyadan bir satır oku
                string[] alanlar = kayit.Split('|'); //Dizilere ayır

                Siparis S = new Siparis(); //Siparis dizisi oluştur
                S.masalar = alanlar[0];
                S.tarih = DateTime.Parse(alanlar[1].ToString());
                S.birimTutar = decimal.Parse(alanlar[2]);
                S.kdv = decimal.Parse(alanlar[3]);
                S.toplamTutar = decimal.Parse(alanlar[4]);
                sonuc.Add(S);             
            }
            rd.Close();
            return sonuc;

        }

        public static ArrayList BirimKazanc()
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Siparişler.txt");

            while (rd.EndOfStream == false) //Dosyanın son satırına kadar oku
            {
                string kayit = rd.ReadLine(); //Dosyadan bir satır oku
                string[] alanlar = kayit.Split('|'); //Dizilere ayır
                sonuc.Add(alanlar[2]); //Birim Tutarı Al
            }
            rd.Close();
            return sonuc;
        }

        public static ArrayList ToplamKDV()
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Siparişler.txt");

            while (rd.EndOfStream == false) //Dosyanın son satırına kadar oku
            {
                string kayit = rd.ReadLine(); //Dosyadan bir satır oku
                string[] alanlar = kayit.Split('|'); //Dizilere ayır
                sonuc.Add(decimal.Parse(alanlar[3])); //KDV yi Al
            }
            rd.Close();
            return sonuc;
        }

        public static ArrayList ToplamKazanc()
        {
            ArrayList sonuc = new ArrayList();
            StreamReader rd = new StreamReader("Siparişler.txt");

            while (rd.EndOfStream == false) //Dosyanın son satırına kadar oku
            {
                string kayit = rd.ReadLine(); //Dosyadan bir satır oku
                string[] alanlar = kayit.Split('|'); //Dizilere ayır
                sonuc.Add(decimal.Parse(alanlar[4])); //Toplam Tutarı Al
            }
            rd.Close();
            return sonuc;
        }
    }
}
