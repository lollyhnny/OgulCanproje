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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Projee
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-F13V9TB;Initial Catalog=OkyanusOtel;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklarr", baglantı);
            SqlDataReader oku= komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gıda"].ToString();
                ekle.SubItems.Add(oku["Icecekler"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);

            }
            baglantı.Close();

        }

        private void veriler2()
        {
            listView2.Items.Clear();
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from Faturalar", baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                ListViewItem ekle1 = new ListViewItem();
                ekle1.Text = oku1["Elektrik"].ToString();
                ekle1.SubItems.Add(oku1["Su"].ToString());
                ekle1.SubItems.Add(oku1["Doğalgaz"].ToString());
                ekle1.SubItems.Add(oku1["Internet"].ToString());
                listView2.Items.Add(ekle1);

            }
            baglantı.Close();

        }


        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void BtnKaydet1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1= new SqlCommand("insert into Faturalar (Elektrik,Su,Doğalgaz,Internet) values ('" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + TxtDogalgaz.Text + "','" + TxtInternet.Text + "')", baglantı);
            komut1.ExecuteNonQuery();
            baglantı.Close();
            veriler2();
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklarr (Gıda,Icecekler,Cerezler) values ('" + TxtGıdalar.Text + "','" + TxtIcecekler.Text + "','" + TxtAtıstırmalıklar.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            veriler();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
