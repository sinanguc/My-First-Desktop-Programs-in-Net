using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DershaneLib
{
    public class Ders
    {
        //Ders in Id Bilgisi
        private decimal dersId;
        public decimal DersId { get { return dersId; } set { dersId = value; } }


        //GrupAdi Bilgisi (Grup Adı Göstermek için Eklendi)
        private string grupAdi;
        public string GrupAdi { get { return grupAdi; } set { grupAdi = value; } }

        private decimal grupNo;
        public decimal GrupNo { get { return grupNo; } set { grupNo = value; } }


        //Ders Adı Bilgisi
        private string dersAdi;
        public string DersAdi { get { return dersAdi; } set { dersAdi = value; } }


        //Ders Kaydediliyor...
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

            SqlCommand komut = new SqlCommand("INSERT INTO Ders (Adi) VALUES (@Adi)", baglan);
            komut.Parameters.AddWithValue("@Adi", dersAdi);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ders Kayıt Edilirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //DersLer Listeleniyor...
        public static List<Ders> Listele()
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable dersListe = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Ders", baglan);

            try
            {
                adaptor.Fill(dersListe);
            }
            catch (Exception)
            {
                throw new Exception("Ders Listesi Okunurken Hata Oluştu");
            }

            List<Ders> sonuc = new List<Ders>();
            for (int i = 0; i < dersListe.Rows.Count; i++)
            {
                Ders dersler = new Ders();
                dersler.dersId = decimal.Parse(dersListe.Rows[i]["Ders_Id"].ToString());
                dersler.dersAdi = dersListe.Rows[i]["Adi"].ToString();

                sonuc.Add(dersler);
            }

            return sonuc;
        }


        //Seçili Ders Siliniyor....
        public void Sil(string dersAdi) //Silinecek Ders i Al...
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

            SqlCommand komut = new SqlCommand("DELETE FROM Ders WHERE Adi=@Adi", baglan);
            komut.Parameters.AddWithValue("@Adi", dersAdi);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {                
                throw new Exception("Ders Silinirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Seçili Ders Düzenleniyor
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

            SqlCommand komut = new SqlCommand("UPDATE Ders SET Adi=@Adi WHERE Ders_Id=@Id", baglan);
            komut.Parameters.AddWithValue("@Id", dersId); //DataBase Düzenlemesi Yapıldı. ID column u Eklendi...
            komut.Parameters.AddWithValue("@Adi", dersAdi);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ders Düzenlemesi Sırasında Hata Oluştu");
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


        //ÖgretmenE  Öğretmen Ekranından Ders Ekleniyor...
        public void OgretmenDersEkle(decimal dersId, decimal OgretId) //Seçili Ders ve Öğretmeni Al
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

            SqlCommand komut = new SqlCommand("INSERT INTO OgretmenDers (Ogretmen_Id,Ders_Id) VALUES (@Ogretmen_Id,@Ders_Id)", baglan);
            komut.Parameters.AddWithValue("@Ogretmen_Id", OgretId);
            komut.Parameters.AddWithValue("@Ders_Id", dersId);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Öğretmen'e Ders Eklenmesi Sırasında Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Öğretmene Ait Dersler Öğretmen Ekranın da Listeleniyor...
        public static List<Ders> OgretmenDersleri(decimal ogretId) //Seçili Öğretmeni Al
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT Ders.*,OgretmenDers.*,Kurs.Kurs_Id,KursAdi AS GrupAdi FROM KursDersleri,ders,OgretmenDers,Kurs WHERE KursDersleri.Ders_Id=Ders.Ders_Id AND OgretmenDers.Ogretmen_Id=@Ogretmen_Id AND Ders.Ders_Id=OgretmenDers.Ders_Id AND KursDersleri.Kurs_Id=Kurs.Kurs_Id", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@Ogretmen_Id", ogretId);

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception)
            {
                throw new Exception("Öğretmen'in Dersleri Listelenirken Hata Oluştu");
            }

            List<Ders> sonuc = new List<Ders>();
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                Ders ogretDers = new Ders();                
                ogretDers.grupAdi = tablo.Rows[i]["GrupAdi"].ToString();
                ogretDers.dersId = decimal.Parse(tablo.Rows[i]["Ders_Id"].ToString());
                ogretDers.dersAdi = tablo.Rows[i]["Adi"].ToString();

                sonuc.Add(ogretDers);
            }

            return sonuc;
        }


        //Öğretmeni DersDen Sil
        public void OgretmenDerstenSil(decimal dersId) //Seçili Ders Id sini Al
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

            SqlCommand komut = new SqlCommand("DELETE FROM OgretmenDers WHERE Ders_Id=@Ders_Id", baglan);
            komut.Parameters.AddWithValue("@Ders_Id", dersId);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Öğretmen Dersten Silirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Girilen Kayıt Daha Önce Kayıtlı mı ? Değil mi ?
        public static bool VarMi(string dersAdi)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Ders WHERE Adi=@DersAdi", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@DersAdi", dersAdi);

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
