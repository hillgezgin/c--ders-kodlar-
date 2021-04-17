using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        

        void griddoldur() // şuan programın ilk açışılında var olan kayıtları tabloya getirir
        {
            
            con = new SqlConnection("server=DESKTOP-QA00UU8; Initial Catalog=okul; Integrated Security=SSPI");
            da = new SqlDataAdapter("Select * from ogrenci",con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            con.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand();
            con.Open();
            komut.Connection = con;
            komut.CommandText = "insert into ogrenci(ogrenci_no,ogrenci_adi,ogrenci_soyadi,ogrenci_sehir) values ("+ogrno.Text+",'"+ograd.Text+"','"+ogrsoyad.Text+"','"+ogrsehir.Text+"')";
            komut.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand();
            con.Open();
            komut.Connection = con;
            komut.CommandText = "update ogrenci set ogrenci_adi='"+ograd.Text+"',ogrenci_soyadi='"+ogrsoyad.Text+"',ogrenci_sehir='"+ogrsehir.Text+"' where ogrenci_no="+ogrno.Text+"";
            komut.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand();
            con.Open();
            komut.Connection = con;
            komut.CommandText = "delete from ogrenci where ogrenci_no="+ogrno.Text+"";
            komut.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }
    }
}
