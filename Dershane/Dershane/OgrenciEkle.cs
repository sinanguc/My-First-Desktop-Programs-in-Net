using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DershaneLib;
using System.Collections;

namespace Dershane
{
    public partial class OgrenciEkle : Form
    {
        /*Bu Ekranda,
         * Öğrenci Ekleme ve Düzenlenme
         * Öğrenci nin Devamsızlık Bilgilerinin Listelenmesi,Düzenlenmesi ve Silinmesi
         * Öğrencinin Kayıtlı Olduğu Grupları Listeleme
         * Öğrenci yi GrupA Ekleme ve Silme,
         * İşlemleri Yapılmaktadır...
         */
        Ogrenci ogkayit = new Ogrenci();
        List<Grup> grup = new List<Grup>();
        List<Devamsizlik> devam = new List<Devamsizlik>();
        bool guncelleme = false; //Yeni Kayıt..
               
       
        public OgrenciEkle()
        {
            InitializeComponent();
        }
        
        public OgrenciEkle(Ogrenci ogkayit) //Düzenlenmek için Gelen Kaydı Al...
        {
            InitializeComponent();
            this.ogkayit = ogkayit;
            guncelleme = true; //Güncellenmek için Geldi...
            return;
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            YeniEskiKayit(); //Alanlar; Yeni Kayıt ise Boş,Değilse Dolu Gelir...

            GruplariListele(); //Grup Ekleme İşlemi için Grupları ComboBoxA Doldurur
            OgrencininGrubunuGoster(); //Öğrenci nin Kayıtlı Olduğu Grupları DataGrid de Listeler
            DevamsizlikListele(); //Öğrenci nin Devamsızlıklarını Listeler...
            ToplamDevamsizlikSayisi();           

           
        }

        public void GruplariListele()
        {
            //Kayıtlı Gruplar Listeleniyor...
            grup = Grup.Listele();
            cmbGrupListesi.DataSource = grup;
        }

        public void DevamsizlikListele()
        {
            //Öğrenci nin Devamsızlıkları Listeleniyor...
            decimal ogId = ogkayit.Ogrenci_Id;
            
            devam = Devamsizlik.DevamsizlikListele(ogId); //Seçili Öğrenci nin Devamsızlıklarını Al

            dgDevamsizlikListesi.AutoGenerateColumns = false;
            dgDevamsizlikListesi.DataSource = devam;
        }

        public void YeniEskiKayit()
        {
            //Düzenleme(Güncelleme) için Öğrenci Bilgiler Dolduruluyor...
            if (guncelleme == true)
            {
                panelKisaBilgi.Visible = true;
                //Kişisel Bilgiler Dolduruluyor
                txtTCkimlik.Text = ogkayit.TcKimlik.ToString();
                txtOgrenciAdi.Text = ogkayit.Adi;
                txtOgrenciSoyadi.Text = ogkayit.Soyadi;
                dtDogumTarihi.Value = ogkayit.DogumTarihi;
                txtDogumYeri.Text = ogkayit.DogumYeri;
                txtAnneAdi.Text = ogkayit.AnneAdi;
                txtBabaAdi.Text = ogkayit.BabaAdi;
                if (ogkayit.Cinsiyet == "Erkek")
                {
                    rdErkek.Checked = true;
                }
                else
                {
                    rdKadin.Checked = true;
                }
                cmbEgitimDurumu.Text = ogkayit.EgitimDurumu;

                //İletişim Bilgileri Dolduruluyor
                txtEvTel.Text = ogkayit.EvTelefonu;
                txtCepTel.Text = ogkayit.CepTelefonu;
                txtEPosta.Text = ogkayit.Eposta;
                txtAdres.Text = ogkayit.Adres;

                //Veli Bilgileri Dolduruluyor
                txtVeliAd.Text = ogkayit.VeliAdi;
                txtVeliSoyad.Text = ogkayit.VeliSoyadi;
                txtVeliAdres.Text = ogkayit.VeliAdres;
                txtVeliEvTel.Text = ogkayit.VeliEvTelefonu;
                txtVeliCeptel.Text = ogkayit.VeliCepTelefonu;
                txtVeliIsTel.Text = ogkayit.VeliIsTelefonu;
                txtVeliEposta.Text = ogkayit.VeliEposta;

                //Kısa Bilgi Alanı Dolduruluyor
                LTCKimlik.Text = ogkayit.TcKimlik.ToString();
                LOgrenciAdi.Text = ogkayit.Adi;
                LOgrenciSoyadi.Text = ogkayit.Soyadi;
                LKayitTarihi.Text = ogkayit.KayitTarihi.ToString();

                //Resim Dolduruluyor
                if (ogkayit.Resim.Length > 0)
                {
                    imgOgrenciResim.Image = CImage.ConvertByteArrayToImage(ogkayit.Resim);
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
                imgOgrenciResim.ImageLocation = openFileDialog1.FileName;
                System.IO.Stream veri = openFileDialog1.OpenFile();
                ogkayit.Resim = new byte[veri.Length];
                veri.Read(ogkayit.Resim, 0, (int)veri.Length);
                
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
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
            txtOgrenciAdi.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtOgrenciAdi_Leave(object sender, EventArgs e)
        {
            txtOgrenciAdi.BackColor = System.Drawing.Color.White;
        }

        private void txtOgrenciSoyadi_Enter(object sender, EventArgs e)
        {
            txtOgrenciSoyadi.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtOgrenciSoyadi_Leave(object sender, EventArgs e)
        {
            txtOgrenciSoyadi.BackColor = System.Drawing.Color.White;
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

        private void txtVeliAd_Enter(object sender, EventArgs e)
        {
            txtVeliAd.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtVeliAd_Leave(object sender, EventArgs e)
        {
            txtVeliAd.BackColor = System.Drawing.Color.White;
        }

        private void txtVeliSoyad_Enter(object sender, EventArgs e)
        {
            txtVeliSoyad.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtVeliSoyad_Leave(object sender, EventArgs e)
        {
            txtVeliSoyad.BackColor = System.Drawing.Color.White;
        }

        private void txtVeliAdres_Enter(object sender, EventArgs e)
        {
            txtVeliAdres.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtVeliAdres_Leave(object sender, EventArgs e)
        {
            txtVeliAdres.BackColor = System.Drawing.Color.White;
        }

        private void txtVeliEvTel_Enter(object sender, EventArgs e)
        {
            txtVeliEvTel.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtVeliEvTel_Leave(object sender, EventArgs e)
        {
            txtVeliEvTel.BackColor = System.Drawing.Color.White;
        }

        private void txtVeliCeptel_Enter(object sender, EventArgs e)
        {
            txtVeliCeptel.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtVeliCeptel_Leave(object sender, EventArgs e)
        {
            txtVeliCeptel.BackColor = System.Drawing.Color.White;
        }

        private void txtVeliIsTel_Enter(object sender, EventArgs e)
        {
            txtVeliIsTel.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtVeliIsTel_Leave(object sender, EventArgs e)
        {
            txtVeliIsTel.BackColor = System.Drawing.Color.White;
        }

        private void txtVeliEposta_Leave(object sender, EventArgs e)
        {
            txtVeliEposta.BackColor = System.Drawing.Color.White;
        }

        private void txtVeliEposta_Enter_1(object sender, EventArgs e)
        {
            txtVeliEposta.BackColor = System.Drawing.Color.Yellow;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Kayıt veya Düzenleme İşlemi Yapılıyor..
            if (guncelleme == false)
            {
                if (Ogrenci.VarMi(decimal.Parse(txtTCkimlik.Text)) == true)
                {
                    MessageBox.Show("Girdiğiniz T.C. Kimlik Numarası Daha Önceden Kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }

            //Kişisel Bilgiler Giriliyor
            ogkayit.TcKimlik = decimal.Parse(txtTCkimlik.Text);
            ogkayit.Adi = txtOgrenciAdi.Text;
            ogkayit.Soyadi = txtOgrenciSoyadi.Text;
            ogkayit.DogumTarihi = DateTime.Parse(dtDogumTarihi.Text);
            ogkayit.DogumYeri = txtDogumYeri.Text;
            ogkayit.AnneAdi = txtAnneAdi.Text;
            ogkayit.BabaAdi = txtBabaAdi.Text;
            if (rdErkek.Checked)
            {
                ogkayit.Cinsiyet = rdErkek.Text;
            }
            else
            {
                ogkayit.Cinsiyet = rdKadin.Text;
            }
            ogkayit.EgitimDurumu = cmbEgitimDurumu.Text;

            //İletişim Bilgileri Giriliyor
            ogkayit.EvTelefonu = txtEvTel.Text;
            ogkayit.CepTelefonu = txtCepTel.Text;
            ogkayit.Eposta = txtEPosta.Text;
            ogkayit.Adres = txtAdres.Text;

            //Veli Bilgileri Giriliyor
            ogkayit.VeliAdi = txtVeliAd.Text;
            ogkayit.VeliSoyadi = txtVeliSoyad.Text;
            ogkayit.VeliAdres = txtVeliAdres.Text;
            ogkayit.VeliEvTelefonu = txtVeliEvTel.Text;
            ogkayit.VeliCepTelefonu = txtVeliCeptel.Text;
            ogkayit.VeliIsTelefonu = txtVeliIsTel.Text;
            ogkayit.VeliEposta = txtVeliEposta.Text;

            if (guncelleme == false) //Yeni Kayıt
            {
                ogkayit.Kaydet();

                OgrenciGruplari seciliGrup = (OgrenciGruplari)dgKayitliOlduguGruplar.SelectedRows[0].DataBoundItem;
                decimal grupId = seciliGrup.Grup_Id;

                //TODO:GrupA Kayıt Yapılacak
                List<OgrenciGruplari> gelenOg = new List<OgrenciGruplari>();
                gelenOg = OgrenciGruplari.OgrenciCek();
                OgrenciGruplari ogrenci = new OgrenciGruplari();
                ogrenci.Ogrenci_Id = decimal.Parse(gelenOg.ToString());
                decimal ogId = ogrenci.Ogrenci_Id;                

                seciliGrup.OgrenciyiGrubAKaydet(ogId, grupId);

            }
            else //Düzenleme
            {
                ogkayit.Duzenle();
            }

            this.Close();
        }

        private void btnGrubaEkle_Click(object sender, EventArgs e)
        {
            //TODO:Sanal Grup Ekleme İşlemi Yapılacak...
            if (guncelleme == true)
            {
                Grup seciliGrup = (Grup)cmbGrupListesi.SelectedItem;
                decimal grupId = seciliGrup.Grup_Id;
                decimal ogId = ogkayit.Ogrenci_Id;

                if (Grup.KayitliMi(ogId) == true && Grup.KayitliMi1(grupId) == true)
                {
                    MessageBox.Show("Eklemek İstediğiniz Öğrenci Gruba Zaten Kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                seciliGrup.OgrenciyiGrubAKaydet(grupId, ogId);

                OgrencininGrubunuGoster();

            }
            else
            {
                Grup seciliGrup = (Grup)cmbGrupListesi.SelectedItem;
                decimal grupId = seciliGrup.Grup_Id;

                dgKayitliOlduguGruplar.DataSource = OgrenciGruplari.SanalKaydet(grupId);

                
            }            
        }

        private void OgrencininGrubunuGoster()
        {
            //Öğrenci ye Ait Grupları Listele...
            decimal id = ogkayit.Ogrenci_Id;
            dgKayitliOlduguGruplar.AutoGenerateColumns = false;
            dgKayitliOlduguGruplar.DataSource = Grup.OgrenciNinGrupListele(id);  
        }

        private void btnGruptanSil_Click(object sender, EventArgs e)
        {
            if (guncelleme == true)
            {
                if (dgKayitliOlduguGruplar.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Öğrenci yi Gruptan Sil...
                        Grup seciliGrup = (Grup)dgKayitliOlduguGruplar.SelectedRows[0].DataBoundItem;
                        decimal grupId = seciliGrup.Grup_Id;

                        seciliGrup.OgrencitiGruptanSil(grupId); //Seçili Öğrenciyi Al

                        OgrencininGrubunuGoster();
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
            else
            {
                //TODO:SanalSilme Yapılacak
                dgKayitliOlduguGruplar.Rows.Remove(dgKayitliOlduguGruplar.SelectedRows[0]);                
                
            }
        }

        private void btnResimSil_Click(object sender, EventArgs e)
        {
            imgOgrenciResim.Image = Image.FromFile("BosResim.png");
            //System.IO.Stream veri = System.Drawing.Image.FromFile("BosResim.png");
            //ogkayit.Resim = new byte[veri.Length];
            //veri.Read(ogkayit.Resim, 0, (int)veri.Length);
        }

        private void btnDevamsizlikEkle_Click(object sender, EventArgs e)
        {
            if (guncelleme == true)
            {
                //TODO:İsim Soyisim Listeleme İşlemi yapılacak
                DevamsizlikEkle frm = new DevamsizlikEkle(ogkayit);
                frm.ShowDialog();

                DevamsizlikListele();
            }
        }

        private void btnDevamsizlikSil_Click(object sender, EventArgs e)
        {
            if (guncelleme == true)
            {
                if (dgDevamsizlikListesi.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Devamsızlık Silme İşlemi Yapılıyor...
                        Devamsizlik seciliDevamsizlik = (Devamsizlik)dgDevamsizlikListesi.SelectedRows[0].DataBoundItem;
                        decimal devamsizlikId = seciliDevamsizlik.DevamsizlikId;

                        seciliDevamsizlik.DevamsizlikSil(devamsizlikId); //Seçili Devamsızlığı Al

                        DevamsizlikListele();
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

        private void ToplamDevamsizlikSayisi()
        {
            if (guncelleme == true)
            {
                //TODO:Devamsızlık Sayısı Boş Çıkıyor..Düzenlenecek...
                decimal ogId = ogkayit.Ogrenci_Id;
                List<Devamsizlik> sonuc = new List<Devamsizlik>();
                sonuc = Devamsizlik.ToplamDevamsizlik(ogId);
                if (sonuc.Count > 0)
                {
                    string sayi = sonuc[0].DersSaat.ToString();
                    LToplamDevamsizlik.Text = sayi;                    
                }
                else
                {                    
                    LToplamDevamsizlik.Text = "0";
                }
            }
            
        }

        private void btnDevamsizlikDuzenle_Click(object sender, EventArgs e)
        {
            if (guncelleme == true)
            {
                //Seçili Devamsızlık Düzenleniyor...
                if (dgDevamsizlikListesi.SelectedRows.Count == 1)
                {
                    Devamsizlik devam = (Devamsizlik)dgDevamsizlikListesi.SelectedRows[0].DataBoundItem;
                    DevamsizlikDuzenle frm = new DevamsizlikDuzenle(devam);
                    frm.ShowDialog();

                    DevamsizlikListele();
                }
                else
                {
                    MessageBox.Show("Seçim Yapmadınız. İşlem Yapmak İçin Öğrenci Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
