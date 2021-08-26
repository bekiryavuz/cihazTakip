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
    public partial class gorevliDuzenle : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");
        SqlDataAdapter da;
        DataTable dt;

        public void dataGorevliGoster()
        {
            try
            {
                string komut = "select gorevli_id,gorevli_numarasi 'Personel Numarası',gorevli.gorevli_adi+' '+gorevli.gorevli_soyadi as Görevli ,gorevli_telefon Telefon,gorevli_sifre Şifre from gorevli";
                da = new SqlDataAdapter(komut, baglan);
                dt = new DataTable();
                da.Fill(dt);
                dataGorevli.DataSource = dt;
                DataGridViewColumn personelID = dataGorevli.Columns[0];
                personelID.Visible = false;
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
        public void txtTemizle()
        {
            try
            {
                txtGorevliAd.Text = "";
                txtGorevliSoyad.Text = "";
                txtGorevliTelefon.Text = "";
                txtGorevliNumara.Text = "";
                txtGorevliSifre.Text = "";
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }


        public gorevliDuzenle()
        {
            InitializeComponent();
            dataGorevliGoster();
        }

        private void butonGorevliEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand ekle = new SqlCommand();
                ekle.Connection = baglan;
                ekle.CommandText = "insert into gorevli(gorevli_numarasi, gorevli_adi, gorevli_soyadi, gorevli_telefon, gorevli_sifre) values('" + txtGorevliNumara.Text + "', '" + txtGorevliAd.Text + "', '" + txtGorevliSoyad.Text + "', '" + txtGorevliTelefon.Text + "', '" + txtGorevliSifre.Text + "')";
                ekle.ExecuteNonQuery();
                baglan.Close();
                dataGorevliGoster();
                txtTemizle();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void butonGorevliGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand guncelle = new SqlCommand();
                guncelle.Connection = baglan;
                guncelle.CommandText = "update  gorevli set gorevli_numarasi='" + txtGorevliNumara.Text + "',gorevli_adi='" + txtGorevliAd.Text + "',gorevli_soyadi='" + txtGorevliSoyad.Text + "',gorevli_telefon='" + txtGorevliTelefon.Text + "',gorevli_sifre='" + txtGorevliSifre.Text + "' where gorevli_id=" + labelGorevliid.Text + "";
                guncelle.ExecuteNonQuery();
                baglan.Close();
                dataGorevliGoster();
                txtTemizle();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void butonGorevliSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand guncelle = new SqlCommand();
                guncelle.Connection = baglan;
                guncelle.CommandText = "delete from gorevli where gorevli_id=" + labelGorevliid.Text + "";
                guncelle.ExecuteNonQuery();
                baglan.Close();
                dataGorevliGoster();
                txtTemizle();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void dataGorevli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelGorevliid.Text = dataGorevli.CurrentRow.Cells[0].Value.ToString();

                string[] bilgiler = dataGorevli.CurrentRow.Cells[2].Value.ToString().Split(' ');
                if (bilgiler.Length < 3)
                {
                    txtGorevliAd.Text = bilgiler[0];
                    txtGorevliSoyad.Text = bilgiler[1];
                }
                else
                {
                    txtGorevliAd.Clear();
                    for (int i = 0; i < bilgiler.Length - 1; i++)
                    {
                        txtGorevliAd.Text += bilgiler[i] + " ";
                    }

                    txtGorevliSoyad.Text = bilgiler[bilgiler.Length - 1];
                }

                txtGorevliNumara.Text = dataGorevli.CurrentRow.Cells[1].Value.ToString();
                txtGorevliTelefon.Text = dataGorevli.CurrentRow.Cells[3].Value.ToString();
                txtGorevliSifre.Text = dataGorevli.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
