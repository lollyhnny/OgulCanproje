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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-F13V9TB;Initial Catalog=OkyanusOtel;Integrated Security=True");

        private void verilerGoster()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["Adsoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
               

                listView1.Items.Add(ekle);

            }
            baglantı.Close();
        }

            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilerGoster();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            baglantı.Open(); 
            SqlCommand komut = new SqlCommand("insert into Mesajlar  (Mesajid,Adsoyad,Mesaj) values ('" + textBox2.Text + "','" + textBox1.Text + "','" + richTextBox1.Text + "')" ,baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerGoster();


        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text=(listView1.SelectedItems[0].SubItems[1].Text);
            richTextBox1.Text= (listView1.SelectedItems[0].SubItems[2].Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
