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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-F13V9TB;Initial Catalog=OkyanusOtel;Integrated Security=True");

        private void verilerGoster()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from YeniMusteri", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MüsteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle); 

            }
            baglantı.Close();


        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerGoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id= int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MtbTelefonNo.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret1.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCıkısTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "101")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "102")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "103")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Odaa103", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "104")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "105")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "206")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda206", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "207")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda207", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "208")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda208", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "209")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda209", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "210")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda210", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "311")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda311", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "312")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda312", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "313")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda313", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "314")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda314", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }

            if (TxtOdaNo.Text == "315")
            {

                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from Oda315", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                verilerGoster();
            }





        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CbCinsiyet.Text = "";
            MtbTelefonNo.Clear();
            TxtMail.Text = "";
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret1.Clear();
            DtpCıkısTarihi.Text = "";
            DtpGirisTarihi.Text = "";

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update YeniMusteri set Adi='"+TxtAdi.Text+"',Soyadi='"+TxtSoyadi.Text+"',Cinsiyet='"+CbCinsiyet.Text+ "',Telefon='"+MtbTelefonNo.Text+"', Mail='"+TxtMail.Text+"',Tc='"+TxtKimlikNo.Text+"',OdaNo='"+TxtOdaNo.Text+"',Ucret='"+TxtUcret1.Text+"',GirisTarihi='"+DtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"',CıkısTarihi='"+DtpCıkısTarihi.Value.ToString("yyyy-MM-dd")+"'where MüsteriID="+id+"",baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerGoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from YeniMusteri where Adi like '%"+Textİsim.Text+"%'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MüsteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglantı.Close();
        }

        private void BtnKalıcıSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from YeniMusteri where MüsteriID=(" + id + ")", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerGoster();

        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
