using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace DershaneLib
{
    public class OgrenciGruplari
    {
        public static ArrayList sanal = new ArrayList();
        //GrupA Kayıt için Bilgiler
        private decimal ogrenci_Id;
        public decimal Ogrenci_Id { get { return ogrenci_Id; } set { ogrenci_Id = value; } }

        private decimal grup_Id;
        public decimal Grup_Id { get { return grup_Id; } set { grup_Id = value; } }


        //Hafıza da Sanal Olarak Ekleme,Silme ve Listeleme için Bilgiler
        private decimal grupNo;
        public decimal GrupNo { get { return grupNo; } set { grupNo = value; } }

        private string grupAdi;
        public string GrupAdi { get { return grupAdi; } set { grupAdi = value; } }

        private DateTime baslamaTarihi;
        public DateTime BaslamaTarihi { get { return baslamaTarihi; } set { baslamaTarihi = value; } }

        private DateTime bitisTarihi;
        public DateTime BitisTarihi { get { return bitisTarihi; } set { bitisTarihi = value; } }


        public static ArrayList SanalKaydet(decimal grupId)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT Grup.*, Kurs.KursAdi AS GrupAdi FROM Grup,Kurs WHERE Grup_Id=@Grup_Id AND Grup.Kurs_Id=Kurs.Kurs_Id", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@Grup_Id", grupId);

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception)
            {
                throw new Exception("Grup Bilgileri Okunamadı");
            }

            
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                OgrenciGruplari A = new OgrenciGruplari();
                //Kayıt için
                A.grup_Id = decimal.Parse(tablo.Rows[i]["Grup_Id"].ToString());                
                //Listeleme Yapmak için                
                A.grupAdi = tablo.Rows[i]["GrupAdi"].ToString();
                A.grupNo = decimal.Parse(tablo.Rows[i]["GrupNo"].ToString());
                A.baslamaTarihi = DateTime.Parse(tablo.Rows[i]["BaslamaTarih"].ToString());
                A.bitisTarihi = DateTime.Parse(tablo.Rows[i]["BitisTarih"].ToString());

                sanal.Add(A);
            }

            return sanal;
        }

        public override string ToString()
        {
            return GrupAdi;
        }

        public void OgrenciyiGrubAKaydet(decimal grupId, decimal ogId)
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

            SqlCommand komut = new SqlCommand("INSERT INTO GrupOgrencisi (Ogrenci_Id,Grup_Id) VALUES (@Ogrenci_Id,@Grup_Id)", baglan);
            komut.Parameters.AddWithValue("@Ogrenci_Id", ogId);
            komut.Parameters.AddWithValue("@Grup_Id", grupId);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Öğrenci Grup'a Eklenirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }

        public static List<OgrenciGruplari> OgrenciCek()
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT Top 1 * FROM Ogrenci ORDER BY Ogrenci_Id DESC", baglan);            

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception)
            {
                throw new Exception("Öğrenci Bilgisi Çekilemedi");
            }

            List<OgrenciGruplari> sonuc = new List<OgrenciGruplari>();
            for (int i = 0;i < tablo.Rows.Count; i++)
            {
                OgrenciGruplari ogrenci = new OgrenciGruplari();
                ogrenci.ogrenci_Id = decimal.Parse(tablo.Rows[i]["Ogrenci_Id"].ToString());

                sonuc.Add(ogrenci);
            }

            return sonuc;
        }
    }
}
