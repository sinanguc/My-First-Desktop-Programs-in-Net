using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DershaneLib
{
    public class Ogretmen
    {
        //Id Bilgisi
        private decimal ogretmen_Id;
        public decimal Ogretmen_Id { get { return ogretmen_Id; } }


        //Resim Bilgisi
        private byte[] resim = new byte[0];
        public byte[] Resim { get { return resim; } set { resim = value; } }


        //Kişisel Bilgiler
        private decimal tcKimlik;
        public decimal TcKimlik { get { return tcKimlik; } set { tcKimlik = value; } }

        private string adi;
        public string Adi { get { return adi; } set { adi = value; } }

        private string soyadi;
        public string Soyadi { get { return soyadi; } set { soyadi = value; } }

        private DateTime kayitTarihi;
        public DateTime KayitTarihi { get { return kayitTarihi; } set { kayitTarihi = value; } }

        private DateTime dogumTarihi;
        public DateTime DogumTarihi { get { return dogumTarihi; } set { dogumTarihi = value; } }

        private string dogumYeri;
        public string DogumYeri { get { return dogumYeri; } set { dogumYeri = value; } }

        private string anneAdi;
        public string AnneAdi { get { return anneAdi; } set { anneAdi = value; } }

        private string babaAdi;
        public string BabaAdi { get { return babaAdi; } set { babaAdi = value; } }

        private string cinsiyet;
        public string Cinsiyet { get { return cinsiyet; } set { cinsiyet = value; } }


        //iletişim Bilgileri
        private string evTelefonu;
        public string EvTelefonu { get { return evTelefonu; } set { evTelefonu = value; } }

        private string cepTelefonu;
        public string CepTelefonu { get { return cepTelefonu; } set { cepTelefonu = value; } }

        private string eposta;
        public string Eposta { get { return eposta; } set { eposta = value; } }

        private string adres;
        public string Adres { get { return adres; } set { adres = value; } }    


        //İş Bilgisi
        private string bitirdigiOkul;
        public string BitirdigiOkul { get { return bitirdigiOkul; } set { bitirdigiOkul = value; } }

        private string bolumu;
        public string Bolumu { get { return bolumu; } set { bolumu = value; } }

        private string egitimDurumu;
        public string EgitimDurumu { get { return egitimDurumu; } set { egitimDurumu = value; } }

        private string brans;
        public string Brans { get { return brans; } set { brans = value; } }

        private string isDeneyimleri;
        public string IsDeneyimleri { get { return isDeneyimleri; } set { isDeneyimleri = value; } }


        //Öğretmen Bilgileri Kayıt Ediliyor
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

            SqlCommand komut = new SqlCommand("INSERT INTO Ogretmen (TCKimlik,Resim,KayitTarihi,Adi,Soyadi,DogumTarihi,DogumYeri,AnneAdi,BabaAdi,Cinsiyet,EvTel,CepTel,EPosta,Adres,BitirdigiOkul,Bolumu,EgitimDurumu,Brans,IsDeneyimleri) VALUES (@TCKimlik,@Resim,@KayitTarihi,@Adi,@Soyadi,@DogumTarihi,@DogumYeri,@AnneAdi,@BabaAdi,@Cinsiyet,@EvTel,@CepTel,@EPosta,@Adres,@BitirdigiOkul,@Bolumu,@EgitimDurumu,@Brans,@IsDeneyimleri)", baglan);
            //Kişisel Bilgiler
            komut.Parameters.AddWithValue("@TCKimlik", tcKimlik);
            komut.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);
            komut.Parameters.AddWithValue("@Adi", adi);
            komut.Parameters.AddWithValue("@Soyadi", soyadi);
            komut.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            komut.Parameters.AddWithValue("@DogumYeri", dogumYeri);
            komut.Parameters.AddWithValue("@AnneAdi", anneAdi);
            komut.Parameters.AddWithValue("@BabaAdi", babaAdi);
            komut.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
            //İletişim Bilgisi
            komut.Parameters.AddWithValue("@EvTel", evTelefonu);
            komut.Parameters.AddWithValue("@CepTel", cepTelefonu);
            komut.Parameters.AddWithValue("@EPosta", eposta);
            komut.Parameters.AddWithValue("@Adres", adres);
            //Diğer Bilgiler
            komut.Parameters.AddWithValue("@BitirdigiOkul", bitirdigiOkul);
            komut.Parameters.AddWithValue("@Bolumu", bolumu);
            komut.Parameters.AddWithValue("@EgitimDurumu", egitimDurumu);
            komut.Parameters.AddWithValue("@Brans", brans);
            komut.Parameters.AddWithValue("@IsDeneyimleri", isDeneyimleri);

            //Resim Bilgisi
            komut.Parameters.AddWithValue("@Resim", resim);


            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Öğretmen Kayıt Edilirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }

        //Öğretmen Tablosu Okunuyor..
        public static List<Ogretmen> Listele()
        {
            SqlConnection baglan = SQLAyar.baglanti;

            DataTable ogretListe = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Ogretmen", baglan);

            try
            {
                adaptor.Fill(ogretListe); //Öğretmen Listesi Dolduruluyor....
            }
            catch (Exception)
            {
                throw new Exception("Öğretmen Listesi Okunurken Hata Oluştu");
            }

            //Her Bir Öğretmen Kaydı sonuc Dizisine dolduruluyor...
            List<Ogretmen> sonuc = new List<Ogretmen>();
            for (int i = 0; i < ogretListe.Rows.Count; i++)
            {
                Ogretmen hoca = new Ogretmen();
                //Id Bilgisi
                hoca.ogretmen_Id = decimal.Parse(ogretListe.Rows[i]["Ogretmen_Id"].ToString());
                //Kişisel Bilgiler
                hoca.tcKimlik = decimal.Parse(ogretListe.Rows[i]["TCKimlik"].ToString());
                hoca.kayitTarihi = DateTime.Parse(ogretListe.Rows[i]["KayitTarihi"].ToString());
                hoca.adi = ogretListe.Rows[i]["Adi"].ToString();
                hoca.soyadi = ogretListe.Rows[i]["Soyadi"].ToString();
                hoca.dogumTarihi = DateTime.Parse(ogretListe.Rows[i]["DogumTarihi"].ToString());
                hoca.dogumYeri = ogretListe.Rows[i]["DogumYeri"].ToString();
                hoca.anneAdi = ogretListe.Rows[i]["AnneAdi"].ToString();
                hoca.babaAdi = ogretListe.Rows[i]["BabaAdi"].ToString();
                hoca.cinsiyet = ogretListe.Rows[i]["Cinsiyet"].ToString();
                //İletişim Bilgileri
                hoca.evTelefonu = ogretListe.Rows[i]["EvTel"].ToString();
                hoca.cepTelefonu = ogretListe.Rows[i]["CepTel"].ToString();
                hoca.eposta = ogretListe.Rows[i]["EPosta"].ToString();
                hoca.adres = ogretListe.Rows[i]["Adres"].ToString();
                //İş Bilgileri
                hoca.bitirdigiOkul = ogretListe.Rows[i]["BitirdigiOkul"].ToString();
                hoca.bolumu = ogretListe.Rows[i]["Bolumu"].ToString();
                hoca.egitimDurumu = ogretListe.Rows[i]["EgitimDurumu"].ToString();
                hoca.brans = ogretListe.Rows[i]["Brans"].ToString();
                hoca.isDeneyimleri = ogretListe.Rows[i]["IsDeneyimleri"].ToString();
                //Resim Bilgisi
                if (ogretListe.Rows[i]["Resim"] != DBNull.Value)
                {
                    hoca.resim = (byte[])ogretListe.Rows[i]["Resim"];
                }

                sonuc.Add(hoca);
            }

            return sonuc;
        }

        //Öğretmen Kaydı Düzenleniyor...
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

            SqlCommand komut = new SqlCommand("UPDATE Ogretmen SET TCKimlik=@TCKimlik, Adi=@Adi, Soyadi=@Soyadi, DogumTarihi=@DogumTarihi, DogumYeri=@DogumYeri, AnneAdi=@AnneAdi, BabaAdi=@BabaAdi, Cinsiyet=@Cinsiyet, EvTel=@EvTel, CepTel=@CepTel, EPosta=@EPosta, Adres=@Adres, BitirdigiOkul=@BitirdigiOkul, Bolumu=@Bolumu, EgitimDurumu=@EgitimDurumu, Brans=@Brans, IsDeneyimleri=@IsDeneyimleri WHERE Ogretmen_Id=@Ogretmen_Id", baglan);
            komut.Parameters.AddWithValue("@Ogretmen_Id", Ogretmen_Id);

            //Kişisel Bilgiler
            komut.Parameters.AddWithValue("@TCKimlik", tcKimlik);
            komut.Parameters.AddWithValue("@Adi", adi);
            komut.Parameters.AddWithValue("@Soyadi", soyadi);
            komut.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            komut.Parameters.AddWithValue("@DogumYeri", dogumYeri);
            komut.Parameters.AddWithValue("@AnneAdi", anneAdi);
            komut.Parameters.AddWithValue("@BabaAdi", babaAdi);
            komut.Parameters.AddWithValue("@Cinsiyet", cinsiyet);            
            //İletişim Bilgileri
            komut.Parameters.AddWithValue("@EvTel", evTelefonu);
            komut.Parameters.AddWithValue("@CepTel", cepTelefonu);
            komut.Parameters.AddWithValue("@EPosta", eposta);
            komut.Parameters.AddWithValue("@Adres", adres);
            //İş Bilgisi
            komut.Parameters.AddWithValue("@BitirdigiOkul", bitirdigiOkul);
            komut.Parameters.AddWithValue("@Bolumu", bolumu);
            komut.Parameters.AddWithValue("@EgitimDurumu", egitimDurumu);
            komut.Parameters.AddWithValue("@Brans", brans);
            komut.Parameters.AddWithValue("@IsDeneyimleri", isDeneyimleri);
            //Resim Bilgisi
            komut.Parameters.AddWithValue("@Resim", resim);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Öğretmen Kaydı Düzenlenirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
            
        }

        //Öğretmen Kaydı Siliniyor...
        public void Sil(decimal id) //sSeçili Öğretmeni Al
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

            SqlCommand komut = new SqlCommand("DELETE FROM Ogretmen WHERE Ogretmen_Id=@Ogretmen_Id", baglan);
            komut.Parameters.AddWithValue("@Ogretmen_Id", id);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ogretmen Silinirken Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Girilen Kayıt Daha Önce Kayıtlı mı ? Değil mi ?
        public static bool VarMi(decimal tcKimlik)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Ogretmen WHERE TCKimlik=@TCKimlik", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@TCKimlik", tcKimlik);

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


