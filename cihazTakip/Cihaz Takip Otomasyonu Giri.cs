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

namespace cihazTakip
{
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");

        public Form1()
        {
            InitializeComponent();
        }

        private void butonGirisAc_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select gorevli_adi,gorevli_soyadi,gorevli_numarasi,gorevli_sifre from gorevli where gorevli_numarasi= '" + txtGirisAd.Text + "'", baglan);
                var reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    string adi = reader.GetString(0);
                    string soyadi = reader.GetString(1);
                    string numara = reader.GetString(2);
                    string sifre = reader.GetString(3);
                    string adSoyad = adi + ' ' + soyadi;
                    if (sifre == txtGirisSifre.Text)
                    {
                        this.Hide();
                        Cihaz_Takip_Otomasyonu_Sistemi ctos = new Cihaz_Takip_Otomasyonu_Sistemi();
                        ctos.labelKullanici.Text = adSoyad;
                        ctos.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Şifre Girdiniz!", "Giriş Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                baglan.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void txtGirisZiyaretci_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Cihaz_Takip_Otomasyonu_Sistemi ctos = new Cihaz_Takip_Otomasyonu_Sistemi();
                ctos.labelKullanici.Text = "Ziyaretci";
                ctos.Show();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
