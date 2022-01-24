using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DershaneLib
{
    public class Kurs
    {
        //Kurs Id Bilgisi
        private decimal id;
        public decimal Id { get { return id; } }

        //Kurs Adı Bilgisi
        private string kursAdi;
        public string KursAdi { get { return kursAdi; } set { kursAdi = value; } }

        //Kursa Kayıtlı Ders Bilgisi
        private string dersAdi;
        public string DersAdi { get { return dersAdi; } set { dersAdi = value; } }

        private decimal dersId;
        public decimal DersId { get { return dersId; } set { dersId = value; } }

        //Kursdan Ders Silinmesi için Bu Id Gerekli
        private decimal kayitId;
        public decimal KayitId { get { return kayitId; } set { kayitId = value; } }


        //Kurs Kayıt Ediliyor...
        public void Kaydet()
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

            SqlCommand komut = new SqlCommand("INSERT INTO Kurs (KursAdi) VALUES (@KursAdi)", baglan);
            komut.Parameters.AddWithValue("@KursAdi", kursAdi);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Kurs Kayıt Edilirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Kurslar Listeleniyor...
        public static List<Kurs> Listele()
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable kursListe = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Kurs", baglan);

            try
            {
                adaptor.Fill(kursListe);
            }
            catch (Exception)
            {
                throw new Exception("Kurs Listesi Okunurken Hata Oluştu");
            }

            List<Kurs> sonuc = new List<Kurs>();            
            for (int i = 0; i < kursListe.Rows.Count; i++)
            {
                Kurs kurs = new Kurs();
                kurs.id = decimal.Parse(kursListe.Rows[i]["Kurs_Id"].ToString());
                kurs.kursAdi = kursListe.Rows[i]["KursAdi"].ToString();

                sonuc.Add(kurs);
            }

            return sonuc;
        }


        //Kurs Kaydı Düzenleniyor...
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

            SqlCommand komut = new SqlCommand("UPDATE Kurs SET KursAdi=@KursAdi WHERE Kurs_Id=@Kurs_Id", baglan);
            komut.Parameters.AddWithValue("@Kurs_Id", id);
            komut.Parameters.AddWithValue("@KursAdi", kursAdi);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Kurs Düzenlenmesi Sırasında Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Kurs Silme Yapılıyor...
        public void Sil(decimal id) //Silinecek Kurs u Al...
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
            
            SqlCommand komut = new SqlCommand("DELETE FROM Kurs WHERE Kurs_Id=@Kurs_Id", baglan);
            komut.Parameters.AddWithValue("@Kurs_Id", id);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Kurs Silinirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }

        }


        //Seçili Kursa Ders Ekleniyor...
        /*Başla
         *Seçili Kursu Al
         *Seçili Dersi Al
         *Eğer Seçili Ders Kursun İçinde varsa; Bitir
         *Yoksa; Dersi Kursa Kaydet
         *Bitir
         */
        public void KursaDersEkle(decimal id, decimal dersId)
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

            SqlCommand komut = new SqlCommand("INSERT INTO KursDersleri (Kurs_Id, Ders_Id) VALUES (@Kurs_Id, @Ders_Id)", baglan);
            komut.Parameters.AddWithValue("@Kurs_Id", id);
            komut.Parameters.AddWithValue("@Ders_Id", dersId);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ders Kurs'a Eklenirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Seçili Kursa Kayıtlı Dersler Listeleniyor
        public static List<Kurs> KursaKayitliDersListele(decimal kursId) //Dersleri Listelenecek Kurs Id sini Al
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM KursDersleri,Ders WHERE KursDersleri.Ders_Id=Ders.Ders_Id AND Kurs_Id=@Kurs_Id", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@Kurs_Id", kursId);

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception)
            {
                throw new Exception("Kurs'a Kayıtlı Dersler Listelenirken Hata Oluştu");
            }

            List<Kurs> sonuc = new List<Kurs>();
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                Kurs kursDersleri = new Kurs();
                kursDersleri.kayitId = decimal.Parse(tablo.Rows[i]["Id"].ToString());
                kursDersleri.id = decimal.Parse(tablo.Rows[i]["Kurs_Id"].ToString());
                kursDersleri.dersAdi = tablo.Rows[i]["Adi"].ToString();
                kursDersleri.dersId = decimal.Parse(tablo.Rows[i]["Ders_Id"].ToString());
                

                sonuc.Add(kursDersleri);
            }

            return sonuc;
        }


        //Seçili Kursdan Ders Siliniyor..
        public void KursdanDersSil(decimal id) //Silinecek KursId ve DersAdını Al
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

            SqlCommand komut = new SqlCommand("DELETE FROM KursDersleri WHERE Id=@Id", baglan);
            komut.Parameters.AddWithValue("@Id", id);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Kurs'a Kayıtlı Ders Silinirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        public override string ToString()
        {            
            return dersAdi;            
        }

        //Girilen Kayıt Daha Önce Kayıtlı mı ? Değil mi ?
        public static bool VarMi(string kursAdi)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Kurs WHERE KursAdi=@KursAdi", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@KursAdi", kursAdi);

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception)
            {
                throw new Exception("Var mı Yok mu Bilgisi Okunurken Hata Oluştu");
            }

            if (tablo.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
