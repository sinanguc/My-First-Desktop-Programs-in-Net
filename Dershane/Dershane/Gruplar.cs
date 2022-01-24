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
    public partial class Gruplar : Form
    {
        /*Bu Ekranda,
         *Grup Oluşturma,Listeleme,Düzenleme ve Silme...
         *GrubA Kayıtlı Öğrencileri Listeleme...
         *İşlemleri Yapılmaktadır...
         */ 
        List<Grup> kayitlar = new List<Grup>();
        public Gruplar()
        {
            InitializeComponent();
        }

        private void Gruplar_Load(object sender, EventArgs e)
        {
            GrupListesi(); //GrupLar Listeleniyor...
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            //Seçili Grup Düzenleniyor...
            if (dgGrupListesi.SelectedRows.Count == 1)
            {
                Grup ogret = (Grup)dgGrupListesi.SelectedRows[0].DataBoundItem; //Seçili Grub u Al...
                GrupOlustur frm = new GrupOlustur(ogret); //Seçili Grub u Düzenlenmek Üzere Gönder
                frm.ShowDialog();

                GrupListesi();
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız. İşlem Yapmak İçin Grup Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void GrupListesi()
        {
            //Kayıtlı Grupları Listele...
            kayitlar = Grup.Listele();
            dgGrupListesi.AutoGenerateColumns = false;
            dgGrupListesi.DataSource = kayitlar;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgGrupListesi.SelectedRows.Count == 1)
            {
                //Seçili Grup Siliniyor...
                if (MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Grup grupSil = (Grup)dgGrupListesi.SelectedRows[0].DataBoundItem;
                    decimal id = grupSil.Grup_Id; //Seçili Grub un Id sini Al...

                    grupSil.Sil(id);

                    GrupListesi();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız. İşlem Yapmak İçin Grup Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnGrupOlustur_Click(object sender, EventArgs e)
        {
            //Grup Oluştur...
            GrupOlustur frm = new GrupOlustur();
            frm.ShowDialog();

            GrupListesi();
        }

        private void txtAdagore_TextChanged(object sender, EventArgs e)
        {
            dgGrupListesi.DataSource = (from c in kayitlar where c.GrupAdi.StartsWith(txtAdagore.Text) select c).ToList();
        }

        private void dgGrupListesi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgGrupListesi.SelectedRows.Count == 1)
            {
                Grup seciliGrup = (Grup)dgGrupListesi.SelectedRows[0].DataBoundItem;
                decimal grupId = seciliGrup.Grup_Id;
                dgGrupOgrencileri.AutoGenerateColumns = false;
                List<Ogrenci> ogrenciler = Ogrenci.Listele(grupId);
                dgGrupOgrencileri.DataSource = ogrenciler; 
            }
        }

        private void dgGrupListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
