using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CafeLib;
using System.IO;

namespace Cafe_Programı
{
    public partial class ToplamKazanc : Form
    {
        public ToplamKazanc()
        {
            InitializeComponent();
        }


        private void HesapKesimi_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Siparis.Listele();

            decimal birimTutar = 0;
            decimal birimTutar2 = 0;

            //Toplam Birim Kazanç Göster
            ArrayList birimKazanc = Siparis.BirimKazanc();
            for (int i = 0; i < birimKazanc.Count; i++)
            {
                birimTutar += Convert.ToInt32(birimKazanc[i]);
            }

            lblToplambirimtutar.Text = birimTutar.ToString();
            birimTutar2 = decimal.Parse(lblToplambirimtutar.Text);

            //Toplam KDV Göster
            decimal KDV = 0;
            decimal KDV2 = 0;

            ArrayList toplamKDV = Siparis.ToplamKDV();
            for (int i = 0; i < toplamKDV.Count; i++)
            {
                KDV += Convert.ToInt32(toplamKDV[i]);
            }

            lblToplamKDV.Text = KDV.ToString();
            KDV2 = decimal.Parse(lblToplamKDV.Text);

            //Toplam Kazanç Göster
            decimal toplamTutar = 0;
            decimal toplamTutar2 = 0;

            ArrayList toplamKazanc = Siparis.ToplamKazanc();
            for (int i = 0; i < toplamKazanc.Count; i++)
            {
                toplamTutar += Convert.ToInt32(toplamKazanc[i]);
            }

            lblToplamtutar.Text = toplamTutar.ToString();
            toplamTutar2 = decimal.Parse(lblToplamtutar.Text);

            
        }
    }
}
