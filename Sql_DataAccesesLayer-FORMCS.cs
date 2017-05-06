using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DAL DB = new DAL();

            //DB.BaglantiHatasi += DB_BaglantiHatasi;
            //DB.SorguHatasi += DB_SorguHatasi;
            //DB.karsilayanBaglanti_Adresi = "Data Source=.;Initial Catalog=OgrenciDB;User ID=sa;Password=123";

            ////SqlDataReader _dr = DB.GetDataReader(DB.ReturnSQL("OgrenciListesi", "Ad","Soyad"), false);
            ////if (_dr != null)
            ////{
            ////    while (_dr.Read())
            ////    {
            ////        listBox1.Items.Add(_dr["Ad"].ToString());
            ////    }
            ////}


            //List<TBLFilitre> flt = new List<TBLFilitre>
            //{
            //    new TBLFilitre("Ad",TBLFilitre.SartTipi.Eþittir,"abc",TBLFilitre.AND_OR.AND),
            //    new TBLFilitre("OgrenciID",TBLFilitre.SartTipi.KüçükEþittir,"3",TBLFilitre.AND_OR.OR)
            //};


            //string ddd = DB.ReturnSQL("OgrenciListesi", flt, "Ad,Soyad,OgrenciID,Deneme");

            //MessageBox.Show(ddd);

        }

        void DB_SorguHatasi(string HataMesaji)
        {
            MessageBox.Show(HataMesaji);
        }

        void DB_BaglantiHatasi(string HataMesaji)
        {
            MessageBox.Show(HataMesaji);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=MyOgrenciDB;User ID=sa;Password=casper1akk");
            #region GetDataReaderKullanýmý
            //DAL DB = new DAL("Data Source=.;Initial Catalog=MyOgrenciDB;User ID=sa;Password=casper1akk");
            //DB.BaglantiDurum(DAL.BaglantiIslem.BaglantiyiAc);

            //SqlDataReader dr = DB.GetDataReader("Select *from OgrenciListesi", false);

            //while (dr.Read())
            //{
            //    listBox1.Items.Add(dr["Ad"].ToString() + dr["Soyad"].ToString());
            //}
            //DB.BaglantiDurum(DAL.BaglantiIslem.BaglantýyýKapat);
	        #endregion

            #region GetDataReaderKullanýmý-Procedure
            // DAL DB2 = new DAL("Data Source=.;Initial Catalog=MyOgrenciDB;User ID=sa;Password=casper1akk");
            //DB2.BaglantiDurum(DAL.BaglantiIslem.BaglantiyiAc);

            //SqlDataReader dr2 = DB2.GetDataReader("ex", true,/*SQLPARAMETRESÝ NASIL EKLÝYCEZ*/);

            //while (dr2.Read())
            //{
            //    listBox1.Items.Add(dr2["Ad"].ToString() + dr2["Soyad"].ToString());
            //}
            //DB2.BaglantiDurum(DAL.BaglantiIslem.BaglantýyýKapat);
            #endregion//SORU VAR BURADA
            #region DataTableKullanýmý
            //DAL orn = new DAL("Data Source=.;Initial Catalog=MyOgrenciDB;User ID=sa;Password=casper1akk");
            //orn.BaglantiDurum(DAL.BaglantiIslem.BaglantiyiAc);
            //DataTable dt = orn.GetDataTable("Select *from OgrenciListesi", false);
            //dataGridView2.DataSource = dt;
            //BAÐLANTI KAPATMANA GEREK YOK O DataTable fonksiyonumun içinde kapatýlýyor finally durumunda.
            #endregion
            #region DataSetKullanýmý
            //DAL orn3 = new DAL("Data Source=.;Initial Catalog=MyOgrenciDB;User ID=sa;Password=casper1akk");
            //orn3.BaglantiDurum(DAL.BaglantiIslem.BaglantiyiAc);
            //DataSet ds = orn3.GetDataSet("Select *from OgrenciListesi Select *from DersListesi Select *from SinavListesi", false);
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView2.DataSource = ds.Tables[1];
            //dataGridView3.DataSource = ds.Tables[2];
            #endregion

            #region ReturnSQL-Olayý
            //DAL DB = new DAL("Data Source=.;Initial Catalog=MyOgrenciDB;User ID=sa;Password=casper1akk");
            //DB.BaglantiDurum(DAL.BaglantiIslem.BaglantiyiAc);

            //SqlDataReader dr = DB.GetDataReader(DB.ReturnSQL("SinavListesi", "OgrenciGUIID", "Not1", "Not2", "Not3"), false);

            //while (dr.Read())
            //{
            //    listBox1.Items.Add(dr["OgrenciGUIID"].ToString() + dr["Not1"].ToString() + "   " + dr["Not2"].ToString() + "  " + dr["Not3"].ToString());
            //}
            //DB.BaglantiDurum(DAL.BaglantiIslem.BaglantýyýKapat);
            #endregion
            #region ReturnSQL-Olayý-Filtreli
            DAL DB = new DAL("Data Source=.;Initial Catalog=MyOgrenciDB;User ID=sa;Password=casper1akk");
            DB.BaglantiDurum(DAL.BaglantiIslem.BaglantiyiAc);
           List<TBLFilitre> ft=new List<TBLFilitre>
           {
              new TBLFilitre("Ad",TBLFilitre.SartTipi.Ýçeriðinde,"ka",TBLFilitre.AND_OR.AND)
           };
            SqlDataReader dr = DB.GetDataReader(DB.ReturnSQL("OgrenciListesi",ft,"Ad","Soyad"), false);

            while (dr.Read())
            {
                listBox1.Items.Add(dr["Ad"].ToString());
            }
            DB.BaglantiDurum(DAL.BaglantiIslem.BaglantýyýKapat);
            #endregion
         


           
        }
    }
}
