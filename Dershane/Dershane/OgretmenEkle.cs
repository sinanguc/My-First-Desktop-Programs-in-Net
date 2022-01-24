using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DershaneLib;

namespace Dershane
{
    public partial class OgretmenEkle : Form
    {
        /*Bu Ekranda,
         *Öğretmen Ekleme ve Düzenlenme
         *Öğretmene Ders Ekleme, Silme
         *Öğretmene Ait Dersleri Listeler
         *İşlemleri Yapılmaktadır...
         */
        Ogretmen ogretKayit = new Ogretmen();
        List<Ders> dersler = new List<Ders>();
        bool guncelleme = false; //Yeni Kayıt
        
        public OgretmenEkle()
        {
            InitializeComponent();
        }

        public OgretmenEkle(Ogretmen ogretKayit) //Düzenlenmek için Gelen Kaydı Al...
        {
            InitializeComponent();
            this.ogretKayit = ogretKayit;
            guncelleme = true; //Güncellenmek için Geldi...
            return;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTCkimlik_Enter(object sender, EventArgs e)
        {
            txtTCkimlik.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtTCkimlik_Leave(object sender, EventArgs e)
        {
            txtTCkimlik.BackColor = System.Drawing.Color.White;
        }

        private void txtOgrenciAdi_Enter(object sender, EventArgs e)
        {
            txtOgretmenAdi.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtOgrenciAdi_Leave(object sender, EventArgs e)
        {
            txtOgretmenAdi.BackColor = System.Drawing.Color.White;
        }

        private void txtOgrenciSoyadi_Enter(object sender, EventArgs e)
        {
            txtOgretmenSoyadi.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtOgrenciSoyadi_Leave(object sender, EventArgs e)
        {
            txtOgretmenSoyadi.BackColor = System.Drawing.Color.White;
        }

        private void txtDogumYeri_Enter(object sender, EventArgs e)
        {
            txtDogumYeri.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtDogumYeri_Leave(object sender, EventArgs e)
        {
            txtDogumYeri.BackColor = System.Drawing.Color.White;
        }

        private void txtAnneAdi_Enter(object sender, EventArgs e)
        {
            txtAnneAdi.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtAnneAdi_Leave(object sender, EventArgs e)
        {
            txtAnneAdi.BackColor = System.Drawing.Color.White;
        }

        private void txtBabaAdi_Enter(object sender, EventArgs e)
        {
            txtBabaAdi.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtBabaAdi_Leave(object sender, EventArgs e)
        {
            txtBabaAdi.BackColor = System.Drawing.Color.White;
        }

        private void txtEvTel_Enter(object sender, EventArgs e)
        {
            txtEvTel.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtEvTel_Leave(object sender, EventArgs e)
        {
            txtEvTel.BackColor = System.Drawing.Color.White;
        }

        private void txtCepTel_Enter(object sender, EventArgs e)
        {
            txtCepTel.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtCepTel_Leave(object sender, EventArgs e)
        {
            txtCepTel.BackColor = System.Drawing.Color.White;
        }

        private void txtEPosta_Enter(object sender, EventArgs e)
        {
            txtEPosta.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtEPosta_Leave(object sender, EventArgs e)
        {
            txtEPosta.BackColor = System.Drawing.Color.White;
        }

        private void txtAdres_Enter(object sender, EventArgs e)
        {
            txtAdres.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtAdres_Leave(object sender, EventArgs e)
        {
            txtAdres.BackColor = System.Drawing.Color.White;
        }

        private void txtBitirdigiOkul_Enter(object sender, EventArgs e)
        {
            txtBitirdigiOkul.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtBitirdigiOkul_Leave(object sender, EventArgs e)
        {
            txtBitirdigiOkul.BackColor = System.Drawing.Color.White;
        }

        private void txtBolumu_Enter(object sender, EventArgs e)
        {
            txtBolumu.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtBolumu_Leave(object sender, EventArgs e)
        {
            txtBolumu.BackColor = System.Drawing.Color.White;
        }

        private void txtBransi_Enter(object sender, EventArgs e)
        {
            txtBrans.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtBrans_Leave(object sender, EventArgs e)
        {
            txtBrans.BackColor = System.Drawing.Color.White;
        }

        private void txtIsDeneyimleri_Enter(object sender, EventArgs e)
        {
            txtIsDeneyimleri.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtIsDeneyimleri_Leave(object sender, EventArgs e)
        {
            txtIsDeneyimleri.BackColor = System.Drawing.Color.White;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Kayıt veya Düzenleme İşlemi Yapılıyor..
            if (guncelleme == false)
            {
                if (Ogretmen.VarMi(decimal.Parse(txtTCkimlik.Text)) == true)
                {
                    MessageBox.Show("Girdiğiniz T.C. Kimlik Numarası Daha Önceden Kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            //Kişisel Bilgiler Giriliyor
            ogretKayit.TcKimlik = decimal.Parse(txtTCkimlik.Text);
            ogretKayit.Adi = txtOgretmenAdi.Text;
            ogretKayit.Soyadi = txtOgretmenSoyadi.Text;
            ogretKayit.DogumTarihi = DateTime.Parse(dtDogumTarihi.Text);
            ogretKayit.DogumYeri = txtDogumYeri.Text;
            ogretKayit.AnneAdi = txtAnneAdi.Text;
            ogretKayit.BabaAdi = txtBabaAdi.Text;

            if (rdErkek.Checked) //Eğer Erkek işaretli ise...
            {
                ogretKayit.Cinsiyet = rdErkek.Text;
            }
            else //Değilse...
            {
                ogretKayit.Cinsiyet = rdKadin.Text;
            }

            //İletişim Bilgileri Giriliyor
            ogretKayit.EvTelefonu = txtEvTel.Text;
            ogretKayit.CepTelefonu = txtCepTel.Text;
            ogretKayit.Eposta = txtEPosta.Text;
            ogretKayit.Adres = txtAdres.Text;

            //İş Bilgileri Giriliyor
            ogretKayit.BitirdigiOkul = txtBitirdigiOkul.Text;
            ogretKayit.Bolumu = txtBolumu.Text;
            ogretKayit.EgitimDurumu = cmbEgitimDurumu.Text;
            ogretKayit.Brans = txtBrans.Text;
            ogretKayit.IsDeneyimleri = txtIsDeneyimleri.Text;
            

            if (guncelleme == false) //Yeni Kayıt
            {
                ogretKayit.Kaydet();
            }
            else //Düzenleme
            {
                ogretKayit.Duzenle();
            }

            this.Close();
        }

        private void OgretmenEkle_Load(object sender, EventArgs e)
        {
            KayitYeniEski(); //Alanlar; Yeni Kayıt ise Boş,Değilse Dolu Gelir

            DersListesi(); //Öğretmene Ders Eklemek için Ders Listesini ComboBoxA Doldurur

            OgretmenDersleriListele(); //Öğretmene Ait Dersleri Listeler..

        }

        private void DersListesi()
        {
            //Öğretmene Ders Ekleme İşlemi için Ders Listele...
            dersler = Ders.Listele();
            cmbDersler.DataSource = dersler;
        }

        private void KayitYeniEski()
        {
            //Düzenleme(Güncelleme) için Öğrenci Bilgiler Dolduruluyor...
            if (guncelleme == true) //Güncelleme
            {
                panelKisaBilgi.Visible = true;

                //Kişisel Bilgiler Dolduruluyor
                txtTCkimlik.Text = ogretKayit.TcKimlik.ToString();
                txtOgretmenAdi.Text = ogretKayit.Adi;
                txtOgretmenSoyadi.Text = ogretKayit.Soyadi;
                dtDogumTarihi.Value = ogretKayit.DogumTarihi;
                txtDogumYeri.Text = ogretKayit.DogumYeri;
                txtAnneAdi.Text = ogretKayit.AnneAdi;
                txtBabaAdi.Text = ogretKayit.BabaAdi;
                if (ogretKayit.Cinsiyet == "Erkek")
                {
                    rdErkek.Checked = true;
                }
                else
                {
                    rdKadin.Checked = true;
                }
                cmbEgitimDurumu.Text = ogretKayit.EgitimDurumu;

                //İletişim Bilgileri Dolduruluyor
                txtEvTel.Text = ogretKayit.EvTelefonu;
                txtCepTel.Text = ogretKayit.CepTelefonu;
                txtEPosta.Text = ogretKayit.Eposta;
                txtAdres.Text = ogretKayit.Adres;

                //İş Bilgileri Dolduruluyor
                txtBitirdigiOkul.Text = ogretKayit.BitirdigiOkul;
                txtBolumu.Text = ogretKayit.Bolumu;
                cmbEgitimDurumu.Text = ogretKayit.EgitimDurumu;
                txtBrans.Text = ogretKayit.Brans;
                txtIsDeneyimleri.Text = ogretKayit.IsDeneyimleri;

                //Kısa Bilgi Alanı Dolduruluyor
                LTCKimlik.Text = ogretKayit.TcKimlik.ToString();
                LOgretmenAdi.Text = ogretKayit.Adi;
                LOgretmenSoyadi.Text = ogretKayit.Soyadi;
                LKayitTarihi.Text = ogretKayit.KayitTarihi.ToString();

                //Resim Dolduruluyor
                if (ogretKayit.Resim.Length > 0)
                {
                    imgOgretmenResim.Image = CImage.ConvertByteArrayToImage(ogretKayit.Resim);
                }
            }
            else //Yeni Kayıt
            {
                panelKisaBilgi.Visible = false;
            }
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            //Resim Ekleme İşlemi Yapılıyor...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgOgretmenResim.ImageLocation = openFileDialog1.FileName;
                System.IO.Stream veri = openFileDialog1.OpenFile();
                ogretKayit.Resim = new byte[veri.Length];
                veri.Read(ogretKayit.Resim, 0, (int)veri.Length);

            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            //ComboBox dan Seçilen Ders i Öğretmene Ekle
            Ders seciliDers = (Ders)cmbDersler.SelectedItem;
            decimal dersId = seciliDers.DersId;

            decimal ogretId = ogretKayit.Ogretmen_Id;

            seciliDers.OgretmenDersEkle(dersId, ogretId); //Seçili Öğretmen ve Ders Bilgilerini Al

            OgretmenDersleriListele();
        }

        private void OgretmenDersleriListele()
        {
            //Öğretmenin Hangi Gruplara Hangi Dersleri Verdiği Dersleri Listele...
            decimal ogretId = ogretKayit.Ogretmen_Id;

            dgOgretmenDersleri.AutoGenerateColumns = false;
            dgOgretmenDersleri.DataSource = Ders.OgretmenDersleri(ogretId);
        }

        private void btnGruptanSil_Click(object sender, EventArgs e)
        {
            if (guncelleme == true)
            {
                if (dgOgretmenDersleri.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Seçili Ders i Öğretmenden Sil
                        Ders seciliDers = (Ders)dgOgretmenDersleri.SelectedRows[0].DataBoundItem;
                        decimal dersId = seciliDers.DersId;

                        seciliDers.OgretmenDerstenSil(dersId);

                        OgretmenDersleriListele();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Seçim Yapmadınız. İşlem Yapmak İçin Öğrenci Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
