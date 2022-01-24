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
    public partial class DevamsizlikListe : Form
    {
        /*Bu Ekranda,
         *Devamsızlık Ekleme,Düzenleme ve Silme
         *Ve Öğrencin ye Ait Devamsızlık Bilgilerinin Listelenmesi
         *İşlemleri Yapılmaktadır...
         */ 
        List<Devamsizlik> ogListe = new List<Devamsizlik>();

        public DevamsizlikListe()
        {
            InitializeComponent();
        }

        private void btnDevamsizlikisle_Click(object sender, EventArgs e)
        {
            if (dgDevamsizlikListesi.SelectedRows.Count == 1)
            {
                //Devamsızlık Eklemek için Devamsızlık Ekleme Ekranına Bilgiler Gönderiliyor...
                Devamsizlik seciliOgrenci = (Devamsizlik)dgDevamsizlikListesi.SelectedRows[0].DataBoundItem;
                DevamsizlikEkle frm = new DevamsizlikEkle(seciliOgrenci); //Seçili Öğrenciyi Al
                frm.ShowDialog();                
                
                OgrenciListesi();

                dgDevamsizlikDetay.DataSource = Devamsizlik.DevamsizlikListele(seciliOgrenci.Ogrenci_Id);
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız. İşlem Yapmak İçin Öğrenci Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void DevamsizlikListe_Load(object sender, EventArgs e)
        {
            OgrenciListesi(); //Öğrenci Listesi Listeleniyor...
        }

        private void OgrenciListesi()
        {
            //Öğrenci Listesi
            ogListe = Devamsizlik.OgrenciListesi();
            dgDevamsizlikListesi.AutoGenerateColumns = false;
            dgDevamsizlikListesi.DataSource = ogListe;


        }

        private void txtAdagore_TextChanged(object sender, EventArgs e)
        {
            dgDevamsizlikListesi.DataSource = (from c in ogListe where c.Adi.StartsWith(txtAdagore.Text) select c).ToList();
        }

        private void txtSoyadagore_TextChanged(object sender, EventArgs e)
        {
            dgDevamsizlikListesi.DataSource = (from c in ogListe where c.Soyadi.StartsWith(txtSoyadagore.Text) select c).ToList();
        }
    
        private void dgDevamsizlikListesi_SelectionChanged(object sender, EventArgs e)
        {
            //Devamsızlık Listesinde Devamsızlık Seçildiğinde Diğer Grid de Devamsızlık Detay Gösterir
            if (dgDevamsizlikListesi.SelectedRows.Count == 1)
            {
                Devamsizlik secili = (Devamsizlik)dgDevamsizlikListesi.SelectedRows[0].DataBoundItem;
                decimal ogId = secili.Ogrenci_Id;
                dgDevamsizlikDetay.AutoGenerateColumns = false;
                dgDevamsizlikDetay.DataSource = Devamsizlik.DevamsizlikListele(ogId);
                
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Seçili Devamsızlığı Sil
            if (dgDevamsizlikDetay.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Devamsizlik secili = (Devamsizlik)dgDevamsizlikDetay.SelectedRows[0].DataBoundItem;
                    decimal devamsizlikId = secili.DevamsizlikId;

                    secili.DevamsizlikSil(devamsizlikId);

                    dgDevamsizlikDetay.DataSource = Devamsizlik.DevamsizlikListele(secili.Ogrenci_Id);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız. İşlem Yapmak İçin Devamsızlık Kaydı Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            //Seçili Devamsızlığı Düzenle
            if (dgDevamsizlikDetay.SelectedRows.Count == 1)
            {
                Devamsizlik devam = (Devamsizlik)dgDevamsizlikDetay.SelectedRows[0].DataBoundItem;
                DevamsizlikDuzenle frm = new DevamsizlikDuzenle(devam);
                frm.ShowDialog();

                Devamsizlik secili = (Devamsizlik)dgDevamsizlikDetay.SelectedRows[0].DataBoundItem;
                dgDevamsizlikDetay.DataSource = Devamsizlik.DevamsizlikListele(secili.Ogrenci_Id);
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız. İşlem Yapmak İçin Devamsızlık Kaydı Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
