using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cihazTakip
{
    public partial class telefonDuzenle : Form
    {

        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");
        SqlDataAdapter da;
        DataTable dt;
        string txtAd = "Personel Adı";
        string txtSoyad = "Personel Soyadı";
        string txtTelefon = "Personel Telefon";
        string txtisyeri = "Personel İşyeri";

        public void dataTelefonGoster(string sorgu)
        {
            try
            {
                if (sorgu == "")
                {
                    sorgu = "select personel_isyeri as 'Personel İşyeri', personel.personel_adi+' '+personel.personel_soyadi as 'Personel', personel_telefon as 'Telefon', personel_id as 'ID'  from personel order by personel_isyeri";
                }
                else
                {
                    sorgu = "select personel_isyeri as 'Personel İşyeri', personel.personel_adi+' '+personel.personel_soyadi as 'Personel', personel_telefon as 'Telefon', personel_id as 'ID'  from personel  where personel_adi like '%" + sorgu + "%' or personel_soyadi like '%" + sorgu + "%' or personel_isyeri like '%" + sorgu + "%' or personel_telefon like '%" + sorgu + "%' ";
                }
                da = new SqlDataAdapter(sorgu, baglan);
                dt = new DataTable();
                da.Fill(dt);
                dataTelefon.DataSource = dt;
                DataGridViewColumn column = dataTelefon.Columns[3];
                column.Visible = false;
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
                txtPersonelisyeri.Text = txtisyeri;
                txtPersonelAd.Text = txtAd;
                txtPersonelSoyad.Text = txtSoyad;
                txtPersonelTelefon.Text = txtTelefon;
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }


        public telefonDuzenle()
        {
            InitializeComponent();
            dataTelefonGoster("");
            txtTemizle();
            
        }   

        private void butonPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand ekle = new SqlCommand();
                baglan.Open();
                ekle.Connection = baglan;
                ekle.CommandText = "insert into personel(personel_adi,personel_soyadi,personel_isyeri,personel_telefon) values ('" + txtPersonelAd.Text + "','" + txtPersonelSoyad.Text + "','" + txtPersonelisyeri.Text + "','" + txtPersonelTelefon.Text + "')";
                ekle.ExecuteNonQuery();
                baglan.Close();
                dataTelefonGoster("");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
            txtTemizle();
        }

        private void butonPersonelGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand guncelle = new SqlCommand();
                baglan.Open();
                guncelle.Connection = baglan;
                guncelle.CommandText = "update  personel set personel_adi='" + txtPersonelAd.Text + "',personel_soyadi='" + txtPersonelSoyad.Text + "',personel_isyeri='" + txtPersonelisyeri.Text + "',personel_telefon='" + txtPersonelTelefon.Text + "' where personel_id=" + labelPersonelid.Text + "";
                guncelle.ExecuteNonQuery();
                baglan.Close();
                txtTemizle();
                dataTelefonGoster("");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void butonPersonelSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sil = new SqlCommand();
                baglan.Open();
                sil.Connection = baglan;
                sil.CommandText = "delete from personel where personel_id=" + labelPersonelid.Text + "";
                sil.ExecuteNonQuery();
                baglan.Close();
                txtTemizle();
                dataTelefonGoster("");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void txtPersonelAd_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtPersonelAd.Text == txtAd)
                {
                    txtPersonelAd.Text = "";
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void txtPersonelAd_Leave(object sender, EventArgs e)
        {
            if (txtPersonelAd.Text == "")
            {
                txtPersonelAd.Text = txtAd;
            }
        }
        private void txtPersonelSoyad_Enter(object sender, EventArgs e)
        {
            if (txtPersonelSoyad.Text == txtSoyad)
            {
                txtPersonelSoyad.Text = "";
            }
        }

        private void txtPersonelSoyad_Leave(object sender, EventArgs e)
        {
            if (txtPersonelSoyad.Text == "")
            {
                txtPersonelSoyad.Text = txtSoyad;
            }
        }
        private void txtPersonelisyeri_Enter(object sender, EventArgs e)
        {
            if (txtPersonelisyeri.Text == txtisyeri)
            {
                txtPersonelisyeri.Text = "";
            }
        }

        private void txtPersonelisyeri_Leave(object sender, EventArgs e)
        {
            if (txtPersonelisyeri.Text == "")
            {
                txtPersonelisyeri.Text = txtisyeri;
            }
        }
        private void txtPersonelTelefon_Enter(object sender, EventArgs e)
        {
            if (txtPersonelTelefon.Text == txtTelefon)
            {
                txtPersonelTelefon.Text = "";
            }
        }

        private void txtPersonelTelefon_Leave(object sender, EventArgs e)
        {
            if (txtPersonelTelefon.Text == "")
            {
                txtPersonelTelefon.Text = txtTelefon;
            }
        }

        private void dataTelefon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelPersonelid.Text = dataTelefon.CurrentRow.Cells[3].Value.ToString();
                string[] bilgiler = dataTelefon.CurrentRow.Cells[1].Value.ToString().Split(' ');
                if (bilgiler.Length < 3)
                {
                    txtPersonelAd.Text = bilgiler[0];
                    txtPersonelSoyad.Text = bilgiler[1];
                }
                else
                {
                    txtPersonelAd.Clear();
                    for (int i = 0; i < bilgiler.Length - 1; i++)
                    {
                        txtPersonelAd.Text += bilgiler[i] + " ";
                    }

                    txtPersonelSoyad.Text = bilgiler[bilgiler.Length - 1];
                }

                txtPersonelisyeri.Text = dataTelefon.CurrentRow.Cells[0].Value.ToString();
                txtPersonelTelefon.Text = dataTelefon.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void txtTelefonAra_TextChanged(object sender, EventArgs e)
        {
            dataTelefonGoster(txtTelefonAra.Text);
        }

        private void butonTemizle_Click(object sender, EventArgs e)
        {
            txtTemizle();
        }
    }
}
