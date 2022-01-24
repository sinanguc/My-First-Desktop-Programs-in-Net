using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DershaneLib
{
    public class Ogrenci
    {
        //Id Bilgisi
        private decimal ogrenci_Id;
        public decimal Ogrenci_Id { get { return ogrenci_Id; } set { ogrenci_Id = value; } }


        //Grup Adı (Kayıtlı Olduğu Grub u Görmek için Sonradan Eklendi)
        private string grupAdi;
        public string GrupAdi { get { return grupAdi; } set { grupAdi = value; } }


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
        public DateTime KayitTarihi { get { return kayitTarihi; } }

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

        private string egitimDurumu;
        public string EgitimDurumu { get {return egitimDurumu; } set {egitimDurumu = value; } }


        //İletişim Bilgileri
        private string evTelefonu;
        public string EvTelefonu { get { return evTelefonu; } set { evTelefonu = value; } }

        private string cepTelefonu;
        public string CepTelefonu { get { return cepTelefonu; } set { cepTelefonu = value; } }

        private string eposta;
        public string Eposta { get { return eposta; } set { eposta = value; } }

        private string adres;
        public string Adres { get { return adres; } set { adres = value; } }


        //Veli Bilgisi
        private string veliAdi;
        public string VeliAdi { get { return veliAdi; } set { veliAdi = value; } }

        private string veliSoyadi;
        public string VeliSoyadi { get { return veliSoyadi; } set { veliSoyadi = value; } }

        private string veliAdres;
        public string VeliAdres { get { return veliAdres; } set { veliAdres = value; } }

        private string veliEvTelefonu;
        public string VeliEvTelefonu { get { return veliEvTelefonu; } set { veliEvTelefonu = value; } }

        private string veliCepTelefonu;
        public string VeliCepTelefonu { get { return veliCepTelefonu; } set { veliCepTelefonu = value; } }
        
        private string veliIsTelefonu;
        public string VeliIsTelefonu { get { return veliIsTelefonu; } set { veliIsTelefonu = value; } }

        private string veliEposta;
        public string VeliEposta { get { return veliEposta; } set { veliEposta = value; } }


        //Öğrenci Bilgileri Kayıt Ediliyor
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

            SqlCommand komut = new SqlCommand("INSERT INTO Ogrenci (TCKimlik,Resim,KayitTarihi,Adi,Soyadi,DogumTarihi,DogumYeri,AnneAdi,BabaAdi,Cinsiyet,EgitimDurumu,EvTel,CepTel,EPosta,Adres,VeliAdi,VeliSoyadi,VeliAdres,VeliEvTel,VeliCepTel,VeliIsTel,VeliEposta) VALUES (@TCKimlik,@Resim,@KayitTarihi,@Adi,@Soyadi,@DogumTarihi,@DogumYeri,@AnneAdi,@BabaAdi,@Cinsiyet,@EgitimDurumu,@EvTel,@CepTel,@EPosta,@Adres,@VeliAdi,@VeliSoyadi,@VeliAdres,@VeliEvTel,@VeliCepTel,@VeliIsTel,@VeliEposta)", baglan);

            //Kişisel Bilgiler
            komut.Parameters.AddWithValue("@TCKimlik", tcKimlik);
            komut.Parameters.AddWithValue("@Adi", adi);
            komut.Parameters.AddWithValue("@Soyadi", soyadi);
            komut.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);
            komut.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            komut.Parameters.AddWithValue("@DogumYeri", dogumYeri);
            komut.Parameters.AddWithValue("@AnneAdi", anneAdi);
            komut.Parameters.AddWithValue("@BabaAdi", babaAdi);
            komut.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
            komut.Parameters.AddWithValue("@EgitimDurumu", egitimDurumu);
            //İletişim Bilgileri
            komut.Parameters.AddWithValue("@EvTel", evTelefonu);
            komut.Parameters.AddWithValue("@CepTel", cepTelefonu);
            komut.Parameters.AddWithValue("@EPosta", eposta);
            komut.Parameters.AddWithValue("@Adres", adres);
            //Veli Bilgisi
            komut.Parameters.AddWithValue("@VeliAdi", veliAdi);
            komut.Parameters.AddWithValue("@VeliSoyadi", veliSoyadi);
            komut.Parameters.AddWithValue("@VeliAdres", veliAdres);
            komut.Parameters.AddWithValue("@VeliEvTel", veliEvTelefonu);
            komut.Parameters.AddWithValue("@VeliCepTel", veliCepTelefonu);
            komut.Parameters.AddWithValue("@VeliIsTel", veliIsTelefonu);
            komut.Parameters.AddWithValue("@VeliEposta", veliEposta);
            //Resim Bilgisi
            komut.Parameters.AddWithValue("@Resim", resim);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Kayıt Sırasında Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
          
        }


        //Öğrenciler Listeleniyor
        public static List<Ogrenci> Listele()
        {            
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable ogListe = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Ogrenci", baglan);

            try
            {
                adaptor.Fill(ogListe);
            }
            catch (Exception)
            {
                throw new Exception("Öğrenci Listesi Okunurken Hata Oluştu");
            }

            List<Ogrenci> sonuc = new List<Ogrenci>();
            for (int i = 0; i < ogListe.Rows.Count; i++)
            {
                Ogrenci talebe = new Ogrenci();
                talebe = DataRowdanClassaCevir(ogListe.Rows[i]);
                
                sonuc.Add(talebe);
            }
            return sonuc;
        }


        public static List<Ogrenci> Listele(decimal grupId)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable ogListe = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Ogrenci,GrupOgrencisi WHERE Ogrenci.Ogrenci_Id=GrupOgrencisi.Ogrenci_Id AND GrupOgrencisi.Grup_Id=@Grup_Id", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@Grup_Id", grupId);

            try
            {
                adaptor.Fill(ogListe);
            }
            catch (Exception)
            {
                throw new Exception("Öğrenci Listesi Okunurken Hata Oluştu");
            }

            List<Ogrenci> sonuc = new List<Ogrenci>();
            for (int i = 0; i < ogListe.Rows.Count; i++)
            {
                Ogrenci talebe = new Ogrenci();
                talebe = DataRowdanClassaCevir(ogListe.Rows[i]);

                sonuc.Add(talebe);
            }
            return sonuc;
        }


        private static Ogrenci DataRowdanClassaCevir(DataRow rw)
        {
            Ogrenci talebe = new Ogrenci();
            //Id Bilgisi            
            talebe.ogrenci_Id = decimal.Parse(rw["Ogrenci_Id"].ToString());
            //Kişisel Bilgiler
            talebe.tcKimlik = decimal.Parse(rw["TCKimlik"].ToString());
            DateTime kayitTarihi = DateTime.Today;
            DateTime.TryParse(rw["KayitTarihi"].ToString(), out kayitTarihi);
            talebe.kayitTarihi = kayitTarihi;
            talebe.adi = rw["Adi"].ToString();
            talebe.soyadi = rw["Soyadi"].ToString();
            talebe.dogumTarihi = DateTime.Parse(rw["DogumTarihi"].ToString());
            talebe.dogumYeri = rw["DogumYeri"].ToString();
            talebe.anneAdi = rw["AnneAdi"].ToString();
            talebe.babaAdi = rw["BabaAdi"].ToString();
            talebe.cinsiyet = rw["Cinsiyet"].ToString();
            talebe.egitimDurumu = rw["EgitimDurumu"].ToString();
            //İletişim Bilgisi
            talebe.evTelefonu = rw["EvTel"].ToString();
            talebe.cepTelefonu = rw["CepTel"].ToString();
            talebe.eposta = rw["EPosta"].ToString();
            talebe.adres = rw["Adres"].ToString();
            //Veli Bilgisi
            talebe.veliAdi = rw["VeliAdi"].ToString();
            talebe.veliSoyadi = rw["VeliSoyadi"].ToString();
            talebe.veliAdres = rw["VeliAdres"].ToString();
            talebe.veliEvTelefonu = rw["VeliEvTel"].ToString();
            talebe.veliCepTelefonu = rw["VeliCepTel"].ToString();
            talebe.veliIsTelefonu = rw["VeliIsTel"].ToString();
            talebe.veliEposta = rw["VeliEposta"].ToString();
            //Resim Bilgisi
           
                if (rw["Resim"] != DBNull.Value)
                {
                    if (((byte[])rw["Resim"]).Length > 0)
                    {
                        talebe.resim = (byte[])rw["Resim"];
                    }
                }
            
            return talebe;
        }

        //Öğrenci Bilgileri Düzenleniyor
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

            SqlCommand komut = new SqlCommand("UPDATE Ogrenci SET TCKimlik=@TCKimlik, Resim=@Resim, Adi=@Adi, Soyadi=@Soyadi, DogumTarihi=@DogumTarihi, DogumYeri=@DogumYeri, AnneAdi=@AnneAdi, BabaAdi=@BabaAdi, Cinsiyet=@Cinsiyet, EgitimDurumu=@EgitimDurumu, EvTel=@EvTel, CepTel=@CepTel, EPosta=@EPosta, Adres=@Adres, VeliAdi=@VeliAdi, VeliSoyadi=@VeliSoyadi, VeliAdres=@VeliAdres, VeliEvTel=@VeliEvTel, VeliCepTel=@VeliCepTel, VeliIsTel=@VeliIsTel, VeliEposta=@VeliEposta  WHERE Ogrenci_Id=@Ogrenci_Id", baglan);
            komut.Parameters.AddWithValue("@Ogrenci_Id", Ogrenci_Id);

            //Kişisel Bilgiler
            komut.Parameters.AddWithValue("@TCKimlik", tcKimlik);
            komut.Parameters.AddWithValue("@Adi", adi);
            komut.Parameters.AddWithValue("@Soyadi", soyadi);            
            komut.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
            komut.Parameters.AddWithValue("@DogumYeri", dogumYeri);
            komut.Parameters.AddWithValue("@AnneAdi", anneAdi);
            komut.Parameters.AddWithValue("@BabaAdi", babaAdi);
            komut.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
            komut.Parameters.AddWithValue("@EgitimDurumu", egitimDurumu);
            //İletişim Bilgileri
            komut.Parameters.AddWithValue("@EvTel", evTelefonu);
            komut.Parameters.AddWithValue("@CepTel", cepTelefonu);
            komut.Parameters.AddWithValue("@EPosta", eposta);
            komut.Parameters.AddWithValue("@Adres", adres);
            //Veli Bilgisi
            komut.Parameters.AddWithValue("@VeliAdi", veliAdi);
            komut.Parameters.AddWithValue("@VeliSoyadi", veliSoyadi);
            komut.Parameters.AddWithValue("@VeliAdres", veliAdres);
            komut.Parameters.AddWithValue("@VeliEvTel", veliEvTelefonu);
            komut.Parameters.AddWithValue("@VeliCepTel", veliCepTelefonu);
            komut.Parameters.AddWithValue("@VeliIsTel", veliIsTelefonu);
            komut.Parameters.AddWithValue("@VeliEposta", veliEposta);

            //Resim Bilgisi
            komut.Parameters.AddWithValue("@Resim", resim);


            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Öğrenci Bilgilerini Güncelleme Sırasında Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }

        }


        //Seçili Öğrenci Siliniyor
        public static void Sil(decimal id) //Seçili Öğrenciyi Al
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
            SqlCommand komut = new SqlCommand("DELETE FROM Ogrenci WHERE Ogrenci_Id=@Ogrenci_Id", baglan);
            komut.Parameters.AddWithValue("@Ogrenci_Id", id);

            try
            {
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Öğrenci Silinmesi Sırasında Hata Oluştu");
            }
            finally
            {
                baglan.Close();
            }
        }


        //Devamsızlık Ekleme Ekranın da Öğrencileri Adı Soyadı na Göre Listeler
        public static List<Ogrenci> Devamsizlik(decimal ogId) //Seçili Devamsızlık Eklenecek Öğrenciyi Al
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Ogrenci WHERE Ogrenci_Id=@Ogrenci_Id", baglan);
            adaptor.SelectCommand.Parameters.AddWithValue("@Ogrenci_Id", ogId);

            try
            {
                adaptor.Fill(tablo);
            }
            catch (Exception)
            {
                throw new Exception("Devamsız Kayıt Edilecek Öğrenciler Okunurken Hata Oldu");
            }

            List<Ogrenci> sonuc = new List<Ogrenci>();
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                Ogrenci talebe = new Ogrenci();
                talebe.adi = tablo.Rows[i]["Adi"].ToString();
                talebe.soyadi = tablo.Rows[i]["Soyadi"].ToString();
                talebe.ogrenci_Id = decimal.Parse(tablo.Rows[i]["Ogrenci_Id"].ToString());
                sonuc.Add(talebe);
            }

            return sonuc;
        }

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }


        //Girilen Kayıt Daha Önce Kayıtlı mı ? Değil mi ?
        public static bool VarMi(decimal tcKimlik)
        {
            SqlConnection baglan = SQLAyar.baglanti;
            DataTable tablo = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Ogrenci WHERE TCKimlik=@TCKimlik", baglan);
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
