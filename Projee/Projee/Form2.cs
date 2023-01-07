using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnMüsteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTarıh.Text = DateTime.Now.ToLongDateString();
            LblSaat.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pansiyon Kayıt Uygulaması--Kırıkkale Üniversitesi--Proje1--İhsan Oğulcan Karabacal--200255055");
        }

        private void BtnGelirGider_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void BtnStoklar_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();
        }

        private void BtnMusteriMesajlari_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm= new FrmMesajlar();
            frm.Show();
        }

        private void LblTarıh_Click(object sender, EventArgs e)
        {

        }
    }
}
