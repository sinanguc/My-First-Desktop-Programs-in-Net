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
    public partial class GrupOlustur : Form
    {
        /*Bu Ekranda,
         *Grup Oluşturma ve Düzenleme,
         *İşlemleri Yapılmaktadır...
         */
        List<Kurs> kursKayitlari = new List<Kurs>();
        Grup grup = new Grup();
        bool guncelleme = false;

        public GrupOlustur()
        {
            InitializeComponent();
        }

        public GrupOlustur(Grup grup) //Düzenlenmek için Gelen Grub u Al
        {
            InitializeComponent();
            this.grup = grup;
            guncelleme = true; //Güncellenmek için geldiyse..
            return;
        }

        private void GrupOlustur_Load(object sender, EventArgs e)
        {
            if (guncelleme == true)
            {
                GrupDuzenle(); //Seçili Grubu Doldur...
            }
            else
            {
                KursListele(); //Kursları ComboBoxA Doldur...
            }            
        }

        private void KursListele()
        {
            //Grup Oluşturmak için,
            //Kayıtlı Kurs Listesi,
            //Grup Adı ComboBox ına Dolduruluyor...            
            kursKayitlari = Kurs.Listele();

            cmbKurslar.DataSource = kursKayitlari;
            cmbKurslar.DisplayMember = "KursAdi";
            cmbKurslar.ValueMember = "KursAdi";
        }

        private void KursDersleriniListele()
        {
            //KursA Kayıtlı Dersleri ListBoxA Listele
            Kurs seciliKurs = (Kurs)cmbKurslar.SelectedItem;
            decimal kursId = seciliKurs.Id;

            kursKayitlari = Kurs.KursaKayitliDersListele(kursId);

            for (int i = 0; i < kursKayitlari.Count; i++)
            {
                lbDersler.Items.Add(kursKayitlari[i]);
            }

        }

        private void GrupDuzenle()
        {
            //Seçili Grup Düzenlenmek için Dolduruluyor..
            txtGrupNo.Text = grup.GrupNo.ToString();

            KursListele();

            cmbKurslar.Text = grup.GrupAdi;
            dtBaslamaTarih.Value = grup.BaslamaTarihi;
            dtBitisTarih.Value = grup.BitisTarihi;

            if (grup.Turu == "OrtaÖğretim")
            {
                cmbTuru.SelectedIndex = 0;
            }
            if (grup.Turu == "ÖnLisans")
            {
                cmbTuru.SelectedIndex = 1;
            }
            if (grup.Turu == "Lisans")
            {
                cmbTuru.SelectedIndex = 2;
            }
            if (grup.Turu == "Yüksek Lisans")
            {
                cmbTuru.SelectedIndex = 3;
            }
            if (grup.Turu == "Doktora")
            {
                cmbTuru.SelectedIndex = 4;
            }
            if (grup.Turu == "Diğer")
            {
                cmbTuru.SelectedIndex = 5;
            }

            txtKontenjan.Text = grup.Kontenjan.ToString();
            
            if(grup.Pazartesi == true)
            {
                lbGunler.SelectedIndex = 0;
            }            
            if (grup.Sali == true)
            {
                lbGunler.SelectedIndex = 1;
            }
            if (grup.Carsamba == true)
            {
                lbGunler.SelectedIndex = 2;
            }
            if(grup.Persembe == true)
            {
                lbGunler.SelectedIndex = 3;
            }
            if (grup.Cuma == true)
            {
                lbGunler.SelectedIndex = 4;
            }
            if (grup.Cumartesi == true)
            {
                lbGunler.SelectedIndex = 5;
            }
            if (grup.Pazar == true)
            {
                lbGunler.SelectedIndex = 6;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGrupNo_Enter(object sender, EventArgs e)
        {
            txtGrupNo.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtGrupNo_Leave(object sender, EventArgs e)
        {
            txtGrupNo.BackColor = System.Drawing.Color.White;
        }

        private void txtKontenjan_Enter(object sender, EventArgs e)
        {
            txtKontenjan.BackColor = System.Drawing.Color.Yellow;
        }

        private void txtKontenjan_Leave(object sender, EventArgs e)
        {
            txtKontenjan.BackColor = System.Drawing.Color.White;
        }

        private void cmbKurslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDersler.Items.Clear();
            KursDersleriniListele(); //Seçilen KursA Ait Dersleri ListBoxA Doldur...
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtGrupNo.Text != "" && txtKontenjan.Text != "")
            {
                Kurs seciliKurs = (Kurs)cmbKurslar.SelectedItem;
                decimal kursId = seciliKurs.Id;


                if (guncelleme == false)
                {
                    if (Grup.VarMi(decimal.Parse(txtGrupNo.Text), kursId))
                    {
                        MessageBox.Show("Girdiğiniz Grup Daha Önceden Kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                //Grup Oluşturma Yapılıyor...
                
                grup.KursId = kursId;
                grup.GrupNo = decimal.Parse(txtGrupNo.Text);
                grup.BaslamaTarihi = dtBaslamaTarih.Value;
                grup.BitisTarihi = dtBitisTarih.Value;
                grup.Turu = cmbTuru.Text;
                grup.Kontenjan = int.Parse(txtKontenjan.Text);

                if (lbGunler.SelectedIndex == 0)
                {
                    grup.Pazartesi = true;
                }
                if (lbGunler.SelectedIndex == 1)
                {
                    grup.Sali = true;
                }
                if (lbGunler.SelectedIndex == 2)
                {
                    grup.Carsamba = true;
                }
                if (lbGunler.SelectedIndex == 3)
                {
                    grup.Persembe = true;
                }
                if (lbGunler.SelectedIndex == 4)
                {
                    grup.Cuma = true;
                }
                if (lbGunler.SelectedIndex == 5)
                {
                    grup.Cumartesi = true;
                }
                if (lbGunler.SelectedIndex == 6)
                {
                    grup.Pazar = true;
                }

                if (guncelleme == false)
                {
                    grup.Kaydet();
                }
                else
                {
                    grup.Duzenle();
                }

                this.Close();
                    
            }
            else
            {
                MessageBox.Show("Lüften Boş Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
