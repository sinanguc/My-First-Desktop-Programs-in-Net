using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DershaneLib
{
    public class Grup
    {
        //Grup Id Bilgisi
        private decimal grup_Id;
        public decimal Grup_Id { get { return grup_Id; } }

        //Kurs Id Bilgisi (Grup Oluşturmak için Eklendi)
        private decimal kursId;
        public decimal KursId { get { return kursId; } set { kursId = value; } }


        //Grup Oluşturma Bilgileri
        private decimal grupNo;
        public decimal GrupNo { get { return grupNo; } set { grupNo = value; } }

        private string grupAdi;
        public string GrupAdi { get { return grupAdi; }  }

        private DateTime baslamaTarihi;
        public DateTime BaslamaTarihi { get { return baslamaTarihi; } set { baslamaTarihi = value; } }

        private DateTime bitisTarihi;
        public DateTime BitisTarihi { get { return bitisTarihi; } set { bitisTarihi = value; } }

        private string turu;
        public string Turu { get { return turu; } set { turu = value; } }

        private int kontenjan;
        public int Kontenjan { get { return kontenjan; } set { kontenjan = value; } }               

        private string dersler;
        public string Dersler { get { return dersler; } set { dersler = value; } }


        //Grup Günleri
        private bool pazartesi;
        public bool Pazartesi { get { return pazartesi; } set { pazartesi = value; } }

        private bool sali;
        public bool Sali { get { return sali; } set { sali = value; } }

        private bool carsamba;
        public bool Carsamba { get { return carsamba; } set { carsamba = value; } }

        private bool persembe;
        public bool Persembe { get { return persembe; } set { persembe = value; } }

        private bool cuma;
        public bool Cuma { get { return cuma; } set { cuma = value; } }

        private bool cumartesi;
        public bool Cumartesi { get { return cumartesi; } set { cumartesi = value; } }

        private bool pazar;
        public bool Pazar { get { return pazar; } set { pazar = value; } }
        

        //Grup Oluşturuluyor...
        public void Kaydet() //Seçili Kurs Id sini Al...
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

            SqlCommand komut = new SqlCommand("INSERT INTO Grup (Kurs_Id,GrupNo,BaslamaTarih,BitisTarih,Turu,Kontenjan,Pazartesi,Sali,Carsamba,Persembe,Cuma,Cumartesi,Pazar) VALUES (@Kurs_Id, @GrupNo,@BaslamaTarih,@BitisTarih,@Turu,@Kontenjan,@Pazartesi,@Sali,@Carsamba,@Persembe,@Cuma,@Cumartesi,@Pazar)", baglan);
            komut.Parameters.AddWithValue("@Kurs_Id", kursId);
            komut.Parameters.AddWithValue("@GrupNo", grupNo);            
            komut.Parameters.AddWithValue("@BaslamaTarih", baslamaTarihi);
            komut.Parameters.AddWithValue("@BitisTarih", bitisTarihi);
            komut.Parameters.AddWithValue("@Turu", turu);
            komut.Parameters.AddWithValue("@Kontenjan", kontenjan);
            komut.Parameters.AddWithValue("@Pazartesi", pazartesi);
            komut.Parameters.AddWithValue("@Sali", sali);
            komut.Parameters.AddWithValue("@Carsamba", carsamba);
            komut.Parameters.AddWithValue("@Persembe", persembe);
            komut.Parameters.AddWithValue("@Cuma", cuma);
            komut.Parameters.AddWithValue("@Cumartesi", cumartesi);
            komut.Parameters.AddWithValue("@Pazar", pazar);

            try 
	        {
                komut.ExecuteNonQuery();		
	        }
	        catch (Exception)
	        {		
		        throw new Exception("Grup Kayıt Edilirken Hata Oluştu");
	        }
            finally
            {
                baglan.Close();
            }
        }


        //Gruplar Listeleniyor...
        public static List<Grup> Listele()
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT Grup.*, Kurs.KursAdi AS GrupAdi FROM Grup,Kurs WHERE Grup.Kurs_Id=Kurs.Kurs_Id", baglan);

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception ex)
            {
                throw new Exception("Grup Listesi Okunurken Hata Oluştu");
            }

            List<Grup> sonuc = new List<Grup>();
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                Grup gruplar = new Grup();
                gruplar.grup_Id = decimal.Parse(tablo.Rows[i]["Grup_Id"].ToString());
                gruplar.grupAdi = tablo.Rows[i]["GrupAdi"].ToString(); //SQL Sorgusu ile KursAdi GrupAdi Oldu...
                gruplar.grupNo = decimal.Parse(tablo.Rows[i]["GrupNo"].ToString());
                gruplar.baslamaTarihi = DateTime.Parse(tablo.Rows[i]["BaslamaTarih"].ToString());
                gruplar.bitisTarihi = DateTime.Parse(tablo.Rows[i]["BitisTarih"].ToString());
                gruplar.turu = tablo.Rows[i]["Turu"].ToString();
                gruplar.kontenjan = int.Parse(tablo.Rows[i]["Kontenjan"].ToString());
                gruplar.pazartesi = bool.Parse(tablo.Rows[i]["Pazartesi"].ToString());
                gruplar.sali = bool.Parse(tablo.Rows[i]["Sali"].ToString());
                gruplar.carsamba = bool.Parse(tablo.Rows[i]["Carsamba"].ToString());
                gruplar.persembe = bool.Parse(tablo.Rows[i]["Persembe"].ToString());
                gruplar.cuma = bool.Parse(tablo.Rows[i]["Cuma"].ToString());
                gruplar.cumartesi = bool.Parse(tablo.Rows[i]["Cumartesi"].ToString());
                gruplar.pazar = bool.Parse(tablo.Rows[i]["Pazar"].ToString());
                          
                gruplar.kursId = decimal.Parse(tablo.Rows[i]["Kurs_Id"].ToString());

                sonuc.Add(gruplar);
            }

            return sonuc;
        }

        public override string ToString()
        {
            return GrupAdi + " " + GrupNo;
            
        }


        //Seçili Grup Düzenleniyor
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

            SqlCommand komut = new SqlCommand("UPDATE Grup SET Kurs_Id=@Kurs_Id, GrupNo=@GrupNo, BaslamaTarih=@BaslamaTarih, BitisTarih=@BitisTarih, Turu=@Turu, Kontenjan=@Kontenjan, Pazartesi=@Pazartesi, Sali=@Sali, Carsamba=@Carsamba, Persembe=@Persembe, Cuma=@Cuma, Cumartesi=@Cumartesi, Pazar=@Pazar WHERE Grup_Id=@Grup_Id", baglan);
            komut.Parameters.AddWithValue("@Grup_Id", grup_Id);
            komut.Parameters.AddWithValue("@Kurs_Id", kursId);
            komut.Parameters.AddWithValue("@GrupNo", grupNo);
            komut.Parameters.AddWithValue("@BaslamaTarih", baslamaTarihi);
            komut.Parameters.AddWithValue("@BitisTarih", bitisTarihi);
            komut.Parameters.AddWithValue("@Turu", turu);
            komut.Parameters.AddWithValue("@Kontenjan", kontenjan);
            komut.Parameters.AddWithValue("@Pazartesi", pazartesi);
            komut.Parameters.AddWithValue("@Sali", sali);
            komut.Parameters.AddWithValue("@Carsamba", carsamba);
            komut.Parameters.AddWithValue("@Persembe", persembe);
            komut.Parameters.AddWithValue("@Cuma", cuma);
            komut.Parameters.AddWithValue("@Cumartesi", cumartesi);
            komut.Parameters.AddWithValue("@Pazar", pazar);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Grup Düzenlenmesi Sırasında Hata oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Grup Silme İşlemi Yapılıyor..
        public void Sil(decimal id) //Seçili Grup Id sini Al
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

            SqlCommand komut = new SqlCommand("DELETE FROM Grup WHERE Grup_Id=@Grup_Id", baglan);
            komut.Parameters.AddWithValue("Grup_Id", id);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Grup Silinmesi Sırasında Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Öğrenciyi Öğrenci Ekranındaki Alanda GrubA Kaydet
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


        //Öğrencinin Kayıtlı Olduğu Grupları Öğrenci Ekranındaki Alanda Listeler...
        public static List<Grup> OgrenciNinGrupListele(decimal id)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT Grup.*, Kurs.KursAdi AS GrupAdi FROM Grup,Kurs,GrupOgrencisi WHERE Grup.Kurs_Id=Kurs.Kurs_Id AND Ogrenci_Id=@Ogrenci_Id AND Grup.Grup_Id=GrupOgrencisi.Grup_Id", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@Ogrenci_Id", id);

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception ex)
            {
                throw new Exception("Öğrenci'nin Kayıtlı Olduğu Gruplar Listelenirken Hata Oluştu");
            }

            List<Grup> sonuc = new List<Grup>();
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                Grup talebeGrup = new Grup();
                talebeGrup.grup_Id = decimal.Parse(tablo.Rows[i]["Grup_Id"].ToString());
                talebeGrup.grupNo = decimal.Parse(tablo.Rows[i]["GrupNo"].ToString());
                talebeGrup.grupAdi = tablo.Rows[i]["GrupAdi"].ToString();
                talebeGrup.baslamaTarihi = DateTime.Parse(tablo.Rows[i]["BaslamaTarih"].ToString());
                talebeGrup.bitisTarihi = DateTime.Parse(tablo.Rows[i]["BitisTarih"].ToString());

                sonuc.Add(talebeGrup);
            }

            return sonuc;
        }


        //Öğrenciyi Öğrenci Ekranındaki Alanda GrubDan Sil
        public void OgrencitiGruptanSil(decimal grupId)
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

            SqlCommand komut = new SqlCommand("DELETE FROM GrupOgrencisi WHERE Grup_Id=@Grup_Id", baglan);
            komut.Parameters.AddWithValue("@Grup_Id", grupId);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Öğrenci Gruptan Silinirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Girilen Kayıt Daha Önce Kayıtlı mı ? Değil mi ?
        public static bool VarMi(decimal grupNo, decimal kursId)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Grup WHERE Kurs_Id=@Kurs_Id AND GrupNo=@GrupNo", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@GrupNo", grupNo);
            adaptor.SelectCommand.Parameters.AddWithValue("@Kurs_Id", kursId);

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


        //Öğrenci KursA Daha Önceden Kayıtlı mı ? Değil mi ?
        public static bool KayitliMi(decimal ogId)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM GrupOgrencisi WHERE Ogrenci_Id=@Ogrenci_Id", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@Ogrenci_Id", ogId);

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

        //Öğrenci KursA Daha Önceden Kayıtlı mı ? Değil mi ?
        public static bool KayitliMi1(decimal grupId)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM GrupOgrencisi WHERE Grup_Id=@Grup_Id", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@Grup_Id", grupId);

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
