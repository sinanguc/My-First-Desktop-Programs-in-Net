using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DershaneLib
{
    public class Devamsizlik
    {
        //Ders Bilgisi
        private string dersAdi;
        public string DersAdi { get { return dersAdi; } set { dersAdi = value; } }


        //Devamsızlık Bilgileri
        private decimal devamsizlikId;
        public decimal DevamsizlikId { get { return devamsizlikId; } set { devamsizlikId = value; } }

        private decimal ogrenci_Id;
        public decimal Ogrenci_Id { get { return ogrenci_Id; } set { ogrenci_Id = value; } }

        private decimal dersId;
        public decimal DersId { get { return dersId; } set { dersId = value; } }

        private DateTime devamsizlikTarih;
        public DateTime DevamsizlikTarih { get { return devamsizlikTarih; } set { devamsizlikTarih = value; } }

        private int dersSaat;
        public int DersSaat { get { return dersSaat; } set { dersSaat = value; } }


        //Grup Bilgileri
        private decimal grupNo;
        public decimal GrupNo { get { return grupNo; } set { grupNo = value; } }

        private string grupAdi;
        public string GrupAdi { get { return grupAdi; } set { grupAdi = value; } }  
      

        //Öğrenci Bilgileri
        private decimal tcKimlik;
        public decimal TcKimlik { get { return tcKimlik; } set { tcKimlik = value; } }

        private string adi;
        public string Adi { get { return adi; } set { adi = value; } }

        private string soyadi;
        public string Soyadi { get { return soyadi; } set { soyadi = value; } }

        private string babaAdi;
        public string BabaAdi { get { return babaAdi; } set { babaAdi = value; } }


        //Devamsızlık Girilmesi için Öğrenci Listesi Alınıyor...
        public static List<Devamsizlik> OgrenciListesi()
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT GrupOgrencisi.*,Ogrenci.*,Grup.*,Kurs.KursAdi AS GrupAdi FROM Ogrenci,Grup,Kurs,GrupOgrencisi WHERE GrupOgrencisi.Ogrenci_Id=Ogrenci.Ogrenci_Id AND GrupOgrencisi.Grup_Id=Grup.Grup_Id AND Kurs.Kurs_Id=Grup.Kurs_Id ORDER BY GrupNo", baglan);            

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception)
            {
                throw new Exception("Öğrencilerin Listelenmesi Sırasında Hata Oluştu");
            }

            List<Devamsizlik> sonuc = new List<Devamsizlik>();
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                Devamsizlik ogListe = new Devamsizlik();
                ogListe.ogrenci_Id = decimal.Parse(tablo.Rows[i]["Ogrenci_Id"].ToString());
                ogListe.grupNo = decimal.Parse(tablo.Rows[i]["GrupNo"].ToString());
                ogListe.grupAdi = tablo.Rows[i]["GrupAdi"].ToString();
                ogListe.tcKimlik = decimal.Parse(tablo.Rows[i]["TCKimlik"].ToString());
                ogListe.adi = tablo.Rows[i]["Adi"].ToString();
                ogListe.soyadi = tablo.Rows[i]["Soyadi"].ToString();
                ogListe.babaAdi = tablo.Rows[i]["BabaAdi"].ToString();

                sonuc.Add(ogListe);
            }

            return sonuc;
        }


        //Öğrenciye Devamsızlık Ekle...
        public void DevamsizlikEkle()
        {
            SqlConnection baglan = SQLAyar.baglanti;
            try
            {
                baglan.Open();
            }
            catch (Exception)
            {
                throw new Exception("Bağlantı Açılamadı");
            }

            SqlCommand komut = new SqlCommand("INSERT INTO Devamsizlik (Ders_Id,Ogrenci_Id,DevamsizlikTarih,DersSaat) VALUES (@Ders_Id,@Ogrenci_Id,@DevamsizlikTarih,@DersSaat)", baglan);
            komut.Parameters.AddWithValue("@Ders_Id", dersId);
            komut.Parameters.AddWithValue("@Ogrenci_Id", ogrenci_Id);
            komut.Parameters.AddWithValue("@DevamsizlikTarih", devamsizlikTarih);
            komut.Parameters.AddWithValue("@DersSaat", dersSaat);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Devamsizlik Kaydı Sırasında Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        public override string ToString()
        {
            return Adi;
            
        }


        //Öğrenci nin Devamsızlığını Listele
        public static List<Devamsizlik> DevamsizlikListele(decimal ogId) //Seçili Öğrenciyi Al
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT Devamsizlik.*,Ders.*,Ogrenci.Ogrenci_Id FROM Devamsizlik,Ogrenci,Ders WHERE Ogrenci.Ogrenci_Id=@Ogrenci_Id AND Devamsizlik.Ogrenci_Id=@Ogrenci_Id AND Ders.Ders_Id=Devamsizlik.Ders_Id", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@Ogrenci_Id", ogId);

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception ex)
            {
                throw new Exception("Devamsızlık Bilgileri Okunurken Hata Oluştu");
            }

            List<Devamsizlik> sonuc = new List<Devamsizlik>();
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                Devamsizlik devam = new Devamsizlik();
                devam.ogrenci_Id = decimal.Parse(tablo.Rows[i]["Ogrenci_Id"].ToString());
                devam.devamsizlikId = decimal.Parse(tablo.Rows[i]["Devamsizlik_Id"].ToString());
                devam.adi = tablo.Rows[i]["Adi"].ToString();
                devam.devamsizlikTarih = DateTime.Parse(tablo.Rows[i]["DevamsizlikTarih"].ToString());
                devam.dersSaat = int.Parse(tablo.Rows[i]["DersSaat"].ToString());

                sonuc.Add(devam);
            }

            return sonuc;
        }


        //Öğrenci nin Devamsızlığını Sil...
        public void DevamsizlikSil(decimal devamsizlikId) //Seçili Devamsızlığı Al
        {
            SqlConnection baglan = SQLAyar.baglanti;
            try
            {
                baglan.Open();
            }
            catch (Exception)
            {
                throw new Exception("Bağlantı Açılamadı");
            }

            SqlCommand komut = new SqlCommand("DELETE FROM Devamsizlik WHERE Devamsizlik_Id=@Devamsizlik_Id", baglan);
            komut.Parameters.AddWithValue("@Devamsizlik_Id", devamsizlikId);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Devamsızlık Silinmesi Sırasında Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Seçili Devamsızlığı Düzenler...
        public void Duzenle()
        {
            SqlConnection baglan = SQLAyar.baglanti;
            try
            {
                baglan.Open();
            }
            catch (Exception)
            {
                throw new Exception("Bağlantı Açılamadı");
            }

            SqlCommand komut = new SqlCommand("UPDATE Devamsizlik SET DevamsizlikTarih=@DevamsizlikTarih, DersSaat=@DersSaat WHERE Devamsizlik_Id=@Devamsizlik_Id", baglan);
            komut.Parameters.AddWithValue("@Devamsizlik_Id", devamsizlikId);
            komut.Parameters.AddWithValue("@DevamsizlikTarih", devamsizlikTarih);
            komut.Parameters.AddWithValue("@DersSaat", dersSaat);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Devamsızlık Düzenleme Sırasında Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Öğrenci Toplam Devamsızlık Sayısı
        public static List<Devamsizlik> ToplamDevamsizlik(decimal ogId)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT Devamsizlik.Ogrenci_Id,SUM(Devamsizlik.DersSaat)DersSaat FROM Devamsizlik WHERE Ogrenci_Id=@Ogrenci_Id GROUP BY Ogrenci_Id", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@Ogrenci_Id", ogId);

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception)
            {
                throw new Exception("Devamsızlık Sayısı Okunurken Hata Oluştu");
            }

            List<Devamsizlik> sonuc = new List<Devamsizlik>();
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                Devamsizlik sayi = new Devamsizlik();
                sayi.ogrenci_Id = decimal.Parse(tablo.Rows[i]["Ogrenci_Id"].ToString());
                sayi.dersSaat = int.Parse(tablo.Rows[i]["DersSaat"].ToString());

                sonuc.Add(sayi);
            }

            return sonuc;

        }

        
    }
}
