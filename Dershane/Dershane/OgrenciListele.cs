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
    public partial class OgrenciListele : Form
    {
        /*Bu Ekranda,
         *Öğrenci Listeleme ve Silme
         *İşlemleri Yapılmaktadır...
         */ 
        List<Ogrenci> kayitlar = new List<Ogrenci>(); //Öğrenci Kayıtlarını Diziye Doldur

        public OgrenciListele()
        {
            InitializeComponent();
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Kaydet Form u Açılıyor...
            OgrenciEkle frm = new OgrenciEkle();
            frm.ShowDialog();

            OgrenciListesi();
        }

        private void OgrenciListele_Load(object sender, EventArgs e)
        {
            OgrenciListesi(); //Öğrencileri Listele
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            //Seçili Öğrenciyi Düzenle            
            if (dgOgrenciListesi.SelectedRows.Count == 1)
            {
                Ogrenci og = (Ogrenci)dgOgrenciListesi.SelectedRows[0].DataBoundItem;
                OgrenciEkle frm = new OgrenciEkle(og); //Seçili Öğrenciyi Düzenlemek için Öğrenci Ekranına Gönder
                frm.ShowDialog();
                OgrenciListesi();
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız. İşlem Yapmak İçin Öğrenci Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgOgrenciListesi.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Seçili Öğrenci Siliniyor...
                    Ogrenci ogSil = (Ogrenci)dgOgrenciListesi.SelectedRows[0].DataBoundItem;
                    decimal id = ogSil.Ogrenci_Id;
                    Ogrenci.Sil(id); //Silinmesi için seçili Id yi Ogrenci.class a Gönder

                    OgrenciListesi();
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

        private void OgrenciListesi()
        {
            //Oğrenciler Listesi DataGrid e Dolduruluyor...
            kayitlar = Ogrenci.Listele();

            dgOgrenciListesi.AutoGenerateColumns = false;
            dgOgrenciListesi.DataSource = kayitlar;            
        }

        private void txtAdagore_TextChanged(object sender, EventArgs e)
        {
            dgOgrenciListesi.DataSource = (from c in kayitlar where c.Adi.StartsWith(txtAdagore.Text) select c).ToList();
        }

        private void txtSoyadagore_TextChanged(object sender, EventArgs e)
        {
            dgOgrenciListesi.DataSource = (from c in kayitlar where c.Soyadi.StartsWith(txtSoyadagore.Text) select c).ToList();
        }

        
    }
}
