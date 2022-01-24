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
    public partial class DevamsizlikEkle : Form
    {
        /*Bu Ekranda,
         *Öğrenci ye Devamsızlık Ekleme ve Düzenleme
         *İşlemleri Yapılmaktadır...
         */ 
        List<Ogrenci> ogrenci = new List<Ogrenci>();
        List<Ders> dersListe = new List<Ders>();
        Devamsizlik ogListe = null; 

        decimal ogId; //Seçili Gelen Öğrencinin Id si

        Ogrenci ogrenciEkran = new Ogrenci();
        

        public DevamsizlikEkle()
        {
            InitializeComponent();
        }

        public DevamsizlikEkle(Devamsizlik ogListe) //Devamsızlık Ekranından Seçili Gelen Öğrenci
        {
            InitializeComponent();
            this.ogListe = ogListe;
            return;
        }

        public DevamsizlikEkle(Ogrenci ogrenciEkran) //Öğrenci Ekranından Gelen Bilgiler
        {
            InitializeComponent();
            ogrenci.Add(ogrenciEkran);
            return;
        }

        private void txtDevamsizSaat_Enter(object sender, EventArgs e)
        {
            txtDevamsizSaat.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtDevamsizSaat_Leave(object sender, EventArgs e)
        {
            txtDevamsizSaat.BackColor = System.Drawing.Color.White;
        }

        private void DevamsizlikEkle_Load(object sender, EventArgs e)
        {            

            DersListesi(); //DersLeri ListBox da Listele
            OgrenciBilgileriniListele(); //Seçili Öğrencileri ListBox da Listele

        }

        public void DersListesi()
        {
            //Dersleri ListBox da Listele
            dersListe = Ders.Listele();
            lbDersler.DataSource = dersListe;
            
        }

        public void OgrenciBilgileriniListele()
        {
            
            
            if (ogListe != null)
            {
                //Seçili Öğrenciyi ListBox da Listele
                ogId = ogListe.Ogrenci_Id;

                ogrenci = Ogrenci.Devamsizlik(ogId);
                lbOgrenci.DataSource = ogrenci;
            }
            else if (ogrenci.Count > 0)
            {
            
                lbOgrenci.DataSource = ogrenci;
            }
        }

        private void btnDevamsizlikEkle_Click(object sender, EventArgs e)
        {
            if (txtDevamsizSaat.Text != "")
            {
                //Öğrenciye Devamsızlık Ekleniyor....
                Ders seciliDers = (Ders)lbDersler.SelectedItem;
                decimal dersId = seciliDers.DersId;

                if (ogListe == null)
                {
                    ogListe = new Devamsizlik();
                }

                Ogrenci secili = (Ogrenci)lbOgrenci.SelectedItem;
                decimal ogId = secili.Ogrenci_Id;

                ogListe.Ogrenci_Id = secili.Ogrenci_Id;
                ogListe.DersId = dersId;
                ogListe.DevamsizlikTarih = dtDevamsizlikTarih.Value;
                ogListe.DersSaat = int.Parse(txtDevamsizSaat.Text);

                ogListe.DevamsizlikEkle();

                this.Close();
            }
            else
            {
                MessageBox.Show("Devamsızlık Saati Boş Olamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
