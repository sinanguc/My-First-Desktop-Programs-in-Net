using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Dershane
{
    public partial class yedek : Form
    {
        public yedek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose(true);
     
            SqlConnection Baglanti = new SqlConnection();
            
            Baglanti.ConnectionString = "Data Source=SINAN\\SQLEXPRESS;Initial Catalog=Sirketi;Integrated Security=True";

            string Commandstring = "backup database Sirketi to disk='C:\\Yedek\\DenemeModel.bak'";
            
            SqlCommand komut = new SqlCommand(Commandstring, Baglanti);

     
            Baglanti.Open();

            komut.ExecuteNonQuery();

            Baglanti.Close();
        }

        private void yedek_Load(object sender, EventArgs e)
        {
           
        }
    }
}
