using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Projee
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-F13V9TB;Initial Catalog=OkyanusOtel;Integrated Security=True");

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCıkısTarihi.Text);
            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            LblGunFarkı.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(LblGunFarkı.Text)*1000;
            TxtUcret1.Text = Ucret.ToString();

           
        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
           
                TxtOdaNo.Text = "101";
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
          
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Odaa103 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "206";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda206 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "207";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda207 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "208";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda208 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "209";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda209 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void TxtUcret1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into YeniMusteri (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CıkısTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + CbCinsiyet.Text + "','" + MtbTelefonNo.Text + "','" + TxtMail.Text + "','" + TxtKimlikNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret1.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCıkısTarihi.Value.ToString("yyyy-MM-dd") + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }

        private void BtnOda210_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "210";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda210 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "311";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda311 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda312_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "312";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda312 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda313_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "313";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda313 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda314_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "314";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda314 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnOda315_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "315";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Oda315 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select * from Odaa103", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglantı);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda206", baglantı);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda206.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda206.Text != "206")
            {
                BtnOda206.BackColor = Color.Red;
                BtnOda206.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda207", baglantı);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda207.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda207.Text != "207")
            {
                BtnOda207.BackColor = Color.Red;
                BtnOda207.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda208", baglantı);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda208.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda208.Text != "208")
            {
                BtnOda208.BackColor = Color.Red;
                BtnOda208.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda209", baglantı);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda209.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda209.Text != "209")
            {
                BtnOda209.BackColor = Color.Red;
                BtnOda209.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut10 = new SqlCommand("select * from Oda210", baglantı);
            SqlDataReader oku10 = komut10.ExecuteReader();

            while (oku10.Read())
            {
                BtnOda210.Text = oku10["Adi"].ToString() + " " + oku10["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda210.Text != "210")
            {
                BtnOda210.BackColor = Color.Red;
                BtnOda210.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut11 = new SqlCommand("select * from Oda311", baglantı);
            SqlDataReader oku11 = komut11.ExecuteReader();

            while (oku11.Read())
            {
                BtnOda311.Text = oku11["Adi"].ToString() + " " + oku11["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda311.Text != "311")
            {
                BtnOda311.BackColor = Color.Red;
                BtnOda311.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut12 = new SqlCommand("select * from Oda312", baglantı);
            SqlDataReader oku12 = komut12.ExecuteReader();

            while (oku12.Read())
            {
                BtnOda312.Text = oku12["Adi"].ToString() + " " + oku12["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda312.Text != "312")
            {
                BtnOda312.BackColor = Color.Red;
                BtnOda312.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut13 = new SqlCommand("select * from Oda313", baglantı);
            SqlDataReader oku13 = komut13.ExecuteReader();

            while (oku13.Read())
            {
                BtnOda313.Text = oku13["Adi"].ToString() + " " + oku13["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda313.Text != "313")
            {
                BtnOda313.BackColor = Color.Red;
                BtnOda313.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut14 = new SqlCommand("select * from Oda314", baglantı);
            SqlDataReader oku14 = komut14.ExecuteReader();

            while (oku14.Read())
            {
                BtnOda314.Text = oku14["Adi"].ToString() + " " + oku14["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda314.Text != "314")
            {
                BtnOda314.BackColor = Color.Red;
                BtnOda314.Enabled = false;
            }


            baglantı.Open();
            SqlCommand komut15 = new SqlCommand("select * from Oda315", baglantı);
            SqlDataReader oku15 = komut15.ExecuteReader();

            while (oku15.Read())
            {
                BtnOda315.Text = oku15["Adi"].ToString() + " " + oku15["Soyadi"].ToString();
            }
            baglantı.Close();
            if (BtnOda315.Text != "315")
            {
                BtnOda315.BackColor = Color.Red;
                BtnOda315.Enabled = false;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//Data Source=DESKTOP-F13V9TB;Initial Catalog=OkyanusOtel;Integrated Security=True

/*if (TxtAdi != null && TxtSoyadi != null && CbCinsiyet != null && MtbTelefonNo != null && TxtKimlikNo != null && TxtOdaNo != null && TxtUcret1 != null && DtpGirisTarihi != null && DtpCıkısTarihi != null)
            {
                TxtOdaNo.Text = "101";
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
            }
            else
            {
                BtnOda101.Enabled = false;
                MessageBox.Show("Lütfen Bütün Alanları Eksiksiz Doldurunuz");
            }*/