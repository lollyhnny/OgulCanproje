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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-F13V9TB;Initial Catalog=OkyanusOtel;Integrated Security=True");



        private void FrmOdalar_Load(object sender, EventArgs e)
        {

            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglantı);
            SqlDataReader oku1= komut1.ExecuteReader();

            while(oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglantı.Close();
            if(BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
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
            }





        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
