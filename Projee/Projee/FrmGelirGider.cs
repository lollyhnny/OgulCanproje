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
using System.Windows.Forms.VisualStyles;

namespace Projee
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-F13V9TB;Initial Catalog=OkyanusOtel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            int personel;
            personel = Convert.ToInt16(TxtPersonelSayısı.Text);
            LblPersonelMaas.Text = (personel*8506).ToString();

            int sonuc;

            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(LblPersonelMaas.Text) + Convert.ToInt32(LblAlınanGıdalar.Text) + Convert.ToInt32(LblAlınanIcecekler.Text) + Convert.ToInt32(LblAlınanCerezler.Text) + Convert.ToInt32(LblElektrık.Text) + Convert.ToInt32(LblSu.Text) + Convert.ToInt32(LblDogalgaz.Text) + Convert.ToInt32(LblInternet.Text));
            LblSonuc.Text=sonuc.ToString();



        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from YeniMusteri", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select sum(Gıda) as toplam1 from Stoklarr", baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                LblAlınanGıdalar.Text = oku1["toplam1"].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Icecekler) as toplam2 from Stoklarr", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlınanIcecekler.Text = oku2["toplam2"].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Cerezler) as toplam3 from Stoklarr", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlınanCerezler.Text = oku3["toplam3"].ToString();
            }
            baglantı.Close();
            //
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Elektrik) as toplam4 from Faturalar", baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblElektrık.Text = oku4["toplam4"].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", baglantı);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblSu.Text = oku5["toplam5"].ToString();
            }
            baglantı.Close();

            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Doğalgaz) as toplam6 from Faturalar", baglantı);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblDogalgaz.Text = oku6["toplam6"].ToString();
            }
            baglantı.Close();



            baglantı.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Internet) as toplam7 from Faturalar", baglantı);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblInternet.Text = oku7["toplam7"].ToString();
            }
            baglantı.Close();




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LblPersonelMaas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
