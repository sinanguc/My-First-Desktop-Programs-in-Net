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
    public partial class OgretmenListele : Form
    {
        /*Bu Ekranda,
         *Öğretmen Listeleme ve Silme
         *İşlemleri Yapılmaktadır...
         */
        List<Ogretmen> kayitlar = new List<Ogretmen>(); //Öğretmen Kayıtlarını Diziye Doldur

        public OgretmenListele()
        {
            InitializeComponent();
        }

        private void btnOgretmenKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Kaydet Form u Açılıyor...
            OgretmenEkle frm = new OgretmenEkle();
            frm.ShowDialog();

            OgretmenListesi();
        }

        private void OgretmenListele_Load(object sender, EventArgs e)
        {
            OgretmenListesi(); //Öğrencileri Listele
        }

        private void btnOgretmenDuzenle_Click(object sender, EventArgs e)
        {
            //Seçili Öğretmeni Düzenle
            if (dgOgretmenListesi.SelectedRows.Count == 1)
            {
                Ogretmen og = (Ogretmen)dgOgretmenListesi.SelectedRows[0].DataBoundItem; //Seçili Öğretmeni Al...
                OgretmenEkle frm = new OgretmenEkle(og); //Seçili Öğretmeni Düzenlemek için Öğrenci Ekranına Gönder
                frm.ShowDialog();
                OgretmenListesi();
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız. İşlem Yapmak İçin Öğretmen Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            if (dgOgretmenListesi.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Seçili Öğretmen Kaydını Sil...
                    Ogretmen ogretSil = (Ogretmen)dgOgretmenListesi.SelectedRows[0].DataBoundItem;
                    decimal id = ogretSil.Ogretmen_Id; //Seçili Öğretmenin Id sini Al
                    ogretSil.Sil(id);

                    OgretmenListesi();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız. İşlem Yapmak İçin Öğretmen Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void OgretmenListesi()
        {
            //Oğretmenler Listesi DataGrid e Dolduruluyor...
            kayitlar = Ogretmen.Listele();
            dgOgretmenListesi.AutoGenerateColumns = false;
            dgOgretmenListesi.DataSource = kayitlar;
        }

        private void txtAdagore_TextChanged(object sender, EventArgs e)
        {
            dgOgretmenListesi.DataSource = (from c in kayitlar where c.Adi.StartsWith(txtAdagore.Text) select c).ToList();
        }

        private void txtSoyadagore_TextChanged(object sender, EventArgs e)
        {
            dgOgretmenListesi.DataSource = (from c in kayitlar where c.Soyadi.StartsWith(txtSoyadagore.Text) select c).ToList();
        }
    }
}
