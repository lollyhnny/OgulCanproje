namespace Projee
{
    partial class FrmMusteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnVerileriGoster = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.CbCinsiyet = new System.Windows.Forms.ComboBox();
            this.LblCinsiyet = new System.Windows.Forms.Label();
            this.TxtUcret1 = new System.Windows.Forms.TextBox();
            this.LblUcret = new System.Windows.Forms.Label();
            this.DtpCıkısTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.MtbTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.TxtKimlikNo = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Textİsim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnKalıcıSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tc";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "OdaNo";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ücret";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "G.Tarihi";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ç.Tarihi";
            this.columnHeader12.Width = 150;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listView1.Location = new System.Drawing.Point(0, 408);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1404, 253);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // BtnVerileriGoster
            // 
            this.BtnVerileriGoster.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVerileriGoster.Location = new System.Drawing.Point(1149, 34);
            this.BtnVerileriGoster.Name = "BtnVerileriGoster";
            this.BtnVerileriGoster.Size = new System.Drawing.Size(200, 38);
            this.BtnVerileriGoster.TabIndex = 1;
            this.BtnVerileriGoster.Text = "Verileri Göster";
            this.BtnVerileriGoster.UseVisualStyleBackColor = true;
            this.BtnVerileriGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuncelle.Location = new System.Drawing.Point(1149, 78);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(200, 41);
            this.BtnGuncelle.TabIndex = 2;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSil.Location = new System.Drawing.Point(1149, 129);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(200, 38);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAra.Location = new System.Drawing.Point(1149, 273);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(200, 38);
            this.BtnAra.TabIndex = 4;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // CbCinsiyet
            // 
            this.CbCinsiyet.FormattingEnabled = true;
            this.CbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CbCinsiyet.Location = new System.Drawing.Point(164, 162);
            this.CbCinsiyet.Name = "CbCinsiyet";
            this.CbCinsiyet.Size = new System.Drawing.Size(258, 28);
            this.CbCinsiyet.TabIndex = 62;
            // 
            // LblCinsiyet
            // 
            this.LblCinsiyet.AutoSize = true;
            this.LblCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCinsiyet.Location = new System.Drawing.Point(55, 162);
            this.LblCinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCinsiyet.Name = "LblCinsiyet";
            this.LblCinsiyet.Size = new System.Drawing.Size(87, 25);
            this.LblCinsiyet.TabIndex = 61;
            this.LblCinsiyet.Text = "Cinsiyet :";
            // 
            // TxtUcret1
            // 
            this.TxtUcret1.Location = new System.Drawing.Point(608, 164);
            this.TxtUcret1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUcret1.Name = "TxtUcret1";
            this.TxtUcret1.Size = new System.Drawing.Size(258, 27);
            this.TxtUcret1.TabIndex = 60;
            // 
            // LblUcret
            // 
            this.LblUcret.AutoSize = true;
            this.LblUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUcret.Location = new System.Drawing.Point(520, 164);
            this.LblUcret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUcret.Name = "LblUcret";
            this.LblUcret.Size = new System.Drawing.Size(66, 25);
            this.LblUcret.TabIndex = 59;
            this.LblUcret.Text = "Ücret :";
            // 
            // DtpCıkısTarihi
            // 
            this.DtpCıkısTarihi.Location = new System.Drawing.Point(608, 256);
            this.DtpCıkısTarihi.Name = "DtpCıkısTarihi";
            this.DtpCıkısTarihi.Size = new System.Drawing.Size(258, 27);
            this.DtpCıkısTarihi.TabIndex = 58;
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Location = new System.Drawing.Point(608, 211);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(258, 27);
            this.DtpGirisTarihi.TabIndex = 57;
            // 
            // MtbTelefonNo
            // 
            this.MtbTelefonNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MtbTelefonNo.Location = new System.Drawing.Point(164, 207);
            this.MtbTelefonNo.Margin = new System.Windows.Forms.Padding(4);
            this.MtbTelefonNo.Mask = "(999) 000-0000";
            this.MtbTelefonNo.Name = "MtbTelefonNo";
            this.MtbTelefonNo.Size = new System.Drawing.Size(258, 31);
            this.MtbTelefonNo.TabIndex = 56;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.Location = new System.Drawing.Point(608, 114);
            this.TxtOdaNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(258, 27);
            this.TxtOdaNo.TabIndex = 55;
            // 
            // TxtKimlikNo
            // 
            this.TxtKimlikNo.Location = new System.Drawing.Point(608, 66);
            this.TxtKimlikNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKimlikNo.MaxLength = 11;
            this.TxtKimlikNo.Name = "TxtKimlikNo";
            this.TxtKimlikNo.Size = new System.Drawing.Size(258, 27);
            this.TxtKimlikNo.TabIndex = 54;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(164, 256);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(258, 27);
            this.TxtMail.TabIndex = 53;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.Location = new System.Drawing.Point(164, 116);
            this.TxtSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(258, 27);
            this.TxtSoyadi.TabIndex = 52;
            // 
            // TxtAdi
            // 
            this.TxtAdi.Location = new System.Drawing.Point(164, 68);
            this.TxtAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(258, 27);
            this.TxtAdi.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(479, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Çıkış Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(479, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Giriş Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(447, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Oda Numarası :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(456, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "T.C Kimlik No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(85, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Adı :";
            // 
            // Textİsim
            // 
            this.Textİsim.Location = new System.Drawing.Point(1150, 318);
            this.Textİsim.Margin = new System.Windows.Forms.Padding(4);
            this.Textİsim.Name = "Textİsim";
            this.Textİsim.Size = new System.Drawing.Size(200, 27);
            this.Textİsim.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1008, 317);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 63;
            this.label9.Text = "Aranacak İsim :";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTemizle.Location = new System.Drawing.Point(1150, 225);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(200, 38);
            this.BtnTemizle.TabIndex = 65;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnKalıcıSil
            // 
            this.BtnKalıcıSil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnKalıcıSil.Location = new System.Drawing.Point(1149, 176);
            this.BtnKalıcıSil.Name = "BtnKalıcıSil";
            this.BtnKalıcıSil.Size = new System.Drawing.Size(200, 38);
            this.BtnKalıcıSil.TabIndex = 66;
            this.BtnKalıcıSil.Text = "Kalıcı Olarak Sil";
            this.BtnKalıcıSil.UseVisualStyleBackColor = true;
            this.BtnKalıcıSil.Click += new System.EventHandler(this.BtnKalıcıSil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1264, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 50);
            this.button1.TabIndex = 67;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1388, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnKalıcıSil);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.Textİsim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CbCinsiyet);
            this.Controls.Add(this.LblCinsiyet);
            this.Controls.Add(this.TxtUcret1);
            this.Controls.Add(this.LblUcret);
            this.Controls.Add(this.DtpCıkısTarihi);
            this.Controls.Add(this.DtpGirisTarihi);
            this.Controls.Add(this.MtbTelefonNo);
            this.Controls.Add(this.TxtOdaNo);
            this.Controls.Add(this.TxtKimlikNo);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtSoyadi);
            this.Controls.Add(this.TxtAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnVerileriGoster);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.FrmMusteriler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader12;
        private ListView listView1;
        private Button BtnVerileriGoster;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnAra;
        private ComboBox CbCinsiyet;
        private Label LblCinsiyet;
        private TextBox TxtUcret1;
        private Label LblUcret;
        private DateTimePicker DtpCıkısTarihi;
        private DateTimePicker DtpGirisTarihi;
        private MaskedTextBox MtbTelefonNo;
        private TextBox TxtOdaNo;
        private TextBox TxtKimlikNo;
        private TextBox TxtMail;
        private TextBox TxtSoyadi;
        private TextBox TxtAdi;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Textİsim;
        private Label label9;
        private Button BtnTemizle;
        private Button BtnKalıcıSil;
        private Button button1;
    }
}