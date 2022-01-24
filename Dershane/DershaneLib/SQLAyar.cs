using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace DershaneLib
{
    class SQLAyar
    {

        public static SqlConnection baglanti = new SqlConnection("Data Source=SINAN\\SQLEXPRESS;Initial Catalog=DershaneOtomasyon;Integrated Security=True");

        //public static void SQLAYAR()
        //{
        //    StreamReader rd = new StreamReader("Ayar.txt");

        //    ArrayList sonuc = new ArrayList();
        //    while (rd.EndOfStream == false)
        //    {
        //        string kayit = rd.ReadLine();
        //        string[] Alanlar = kayit.Split('=');

        //        sonuc.Add(Alanlar[1]);
        //    }
        //    rd.Close();
        //}
    }
}
