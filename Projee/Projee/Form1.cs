using Projee;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Projee
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglant� = new SqlConnection("Data Source=DESKTOP-F13V9TB;Initial Catalog=OkyanusOtel;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == "admin" && TxtSifre.Text == "12345")
            {

                FrmAnaSayfa fr = new FrmAnaSayfa();

                fr.Show();

                this.Hide();

            }

            else

            {
                MessageBox.Show("Kullanici Ada veya Sifre Hatal�");

            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
/*try
{
    baglant�.Open();
    string sql = "selecet * from AdminGiris Kullan�c�Ad�=@Kullaniciadi AND Sifre=@Sifresi ";
    SqlParameter prm1 = new SqlParameter("Kullaniciadi", TxtKullaniciAdi.Text.Trim());
    SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
    SqlCommand komut = new SqlCommand(sql, baglant�);
    komut.Parameters.Add(prm1);
    komut.Parameters.Add(prm2);

    DataTable dt = new DataTable();
    SqlDataAdapter da = new SqlDataAdapter(komut);

    da.Fill(dt);

    if (dt.Rows.Count > 0)
    {
        FrmAnaSayfa fr = new FrmAnaSayfa();
        fr.Show();
        this.Hide();

    }

}
            catch (Exception)
{
    MessageBox.Show("Hatal� Giri�");
}
baglant�.Close(); */