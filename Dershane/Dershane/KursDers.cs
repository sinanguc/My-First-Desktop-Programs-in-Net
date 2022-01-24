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
    public partial class KursDers : Form
    {
        /*Bu Ekranda,
         *Kurs Ekleme,Listeleme,Düzenleme ve Silme
         *Ders Ekleme,Listeleme,Düzenleme ve Silme
         *KursA Ders Ekleme,
         *KursDan Ders Silme,
         *KursA Kayıtlı Dersleri Listeleme,
         *İşlemleri Yapılmakta...
         */
        List<Kurs> kursDersleri = new List<Kurs>();
        List<Kurs> kursKayitlari = new List<Kurs>();
        List<Ders> dersKayitlar = new List<Ders>();
        public KursDers()
        {
            InitializeComponent();
        }

        private void btnKursEkle_Click(object sender, EventArgs e)
        {
            if (txtKursAdi.Text != "")
            {
                if (Kurs.VarMi(txtKursAdi.Text) == true)
                {
                    MessageBox.Show("Girdiğiniz Kurs Adı Daha Önceden Kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                //Yeni Kurs Ekleme İşlemi Yapılıyor...
                Kurs kursEkle = new Kurs();
                kursEkle.KursAdi = txtKursAdi.Text;

                kursEkle.Kaydet();

                txtKursAdi.Clear();
                KursListele();
            }
            else
            {
                MessageBox.Show("Kurs Adı Girilmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void KursListele()
        {
            //KursLar Listeleniyor...
            kursKayitlari = Kurs.Listele();
            lbKursListesi.DataSource = kursKayitlari;
            lbKursListesi.DisplayMember = "KursAdi";
            lbKursListesi.ValueMember = "KursAdi";
        }

        private void KursDers_Load(object sender, EventArgs e)
        {
            KursListele(); //KursLarı Listele
            DersListele(); //DersLeri Listele
            cmbKurslariListele(); //ComboBox a Kursları Listele
            dersSecimiListele(); //Kurs a Ders Eklemek için Kullanılacak ListBox u Doldur...           
            
        }

        private void btnKursDuzenle_Click(object sender, EventArgs e)
        {
            //Seçili Kurs Düzenlenmek için DersDuzenle Ekranına Gönderiliyor.
            Kurs seciliKurs = (Kurs)lbKursListesi.SelectedItem;
            KursDuzenle frm = new KursDuzenle(seciliKurs);
            frm.Show();
        }

        private void btnDersDuzenle_Click(object sender, EventArgs e)
        {
            //Seçili Ders Düzenlenmek için DersDuzenle Ekranına Gönderiliyor.
            Ders seciliDers = (Ders)lbDersListesi.SelectedItem;
            DersDuzenle frm = new DersDuzenle(seciliDers);
            frm.Show();
        }

        private void btnKursSil_Click(object sender, EventArgs e)
        {
            //Kurs Silme Yapılıyor...
            if (MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Kurs kursSil = (Kurs)lbKursListesi.SelectedItem;
                decimal id = kursSil.Id; //Seçili Kursu Al
                kursSil.Sil(id); //Kurs Class ındaki Sil Method una Gönder

                KursListele(); //Kurs Listesini Yenile
            }
            else
            {
                return;
            }
           
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (txtDersAdi.Text != "")
            {
                if (Ders.VarMi(txtDersAdi.Text) == true)
                {
                    MessageBox.Show("Girdiğiniz Ders Adı Daha Önceden Kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                //Ders Ekleniyor...
                Ders dersEkle = new Ders();
                dersEkle.DersAdi = txtDersAdi.Text;

                dersEkle.Kaydet();

                txtDersAdi.Clear();
                DersListele();
            }
            else
            {
                MessageBox.Show("Ders Adı Girilmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void DersListele()
        {
            //Dersler ListBox a Dolduruluyor...
            dersKayitlar = Ders.Listele();
            
            lbDersListesi.DataSource = dersKayitlar;            
            lbDersListesi.DisplayMember = "DersAdi";
            lbDersListesi.ValueMember = "DersAdi";

            dersSecimiListele();
        }

        private void cmbKurslariListele()
        {
            //KursLar Ders Eklenmek Üzere ComboBox da Listeleniyor...
            kursKayitlari = Kurs.Listele();
            cmbKurslar.DataSource = kursKayitlari;
            cmbKurslar.DisplayMember = "KursAdi";
            cmbKurslar.ValueMember = "KursAdi";
        }

        private void dersSecimiListele()
        {
            //DersLer KursLara Eklenmek Üzere ListBox da Listeleniyor...
            dersKayitlar = Ders.Listele();
            lbDersler.DataSource = dersKayitlar;
            lbDersler.DisplayMember = "DersAdi";
            lbDersler.ValueMember = "DersAdi";            
        }


        private void btnDersSil_Click(object sender, EventArgs e)
        {
            //Ders Silme Yapılıyor
            if (MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Ders dersSil = (Ders)lbDersListesi.SelectedItem;
                string adi = dersSil.DersAdi; //Seçili Dersi Al
                dersSil.Sil(adi); //Ders Classındaki Sil Method una Gönder

                DersListele();
            }
            else
            {
                return;
            }
        }

        private void btnKursaEkle_Click(object sender, EventArgs e)
        {
            //Kurs a Ders Ekleniyor...

            //ComboBox dan Ders Eklenecek Kurs Seçiliyor...
            Kurs seciliKurs = (Kurs)cmbKurslar.SelectedItem;
            decimal id = seciliKurs.Id;

            //ListBox dan Kursa Eklenecek Ders Seçiliyor...
            Ders seciliDers = (Ders)lbDersler.SelectedItem;
            decimal dersId = seciliDers.DersId;

            if (kursDersleri.Where(c => c.DersId == dersId ).Any() == false)
            {

                seciliKurs.KursaDersEkle(id, dersId); //VeriTabanına Eklenmek için Kurs ve Ders Bilgileri Gönderiliyor.
                KursAitDersler();
            }

        }

        private void KursAitDersler()
        {
            //ComboBox Kurs Seçimine Göre Kurs Dersleri Listeleniyor...
            Kurs seciliKurs = (Kurs)cmbKurslar.SelectedItem;
            decimal kursId = seciliKurs.Id;

            
            kursDersleri = Kurs.KursaKayitliDersListele(kursId); //Seçili Kursun Id si Kurs.class ına Gönderiliyor.

            lbKursDersleri.DataSource = kursDersleri;
           

            
        }

        private void cmbKurslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox Seçilen Kurs Değişince Yap...
            lbKursDersleri.DataSource = null;
            KursAitDersler();            
        }

        private void btnKurstanCikar_Click(object sender, EventArgs e)
        {
            //Seçili Ders Kursdan Siliniyor...
            Kurs seciliDers = (Kurs)lbKursDersleri.SelectedItem;
            decimal id = seciliDers.KayitId;
            

            seciliDers.KursdanDersSil(id);
            KursAitDersler();
        }        
    }
}
