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
    public partial class dokumanDuzenle : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");
        public dokumanDuzenle()
        {
            InitializeComponent();
            dokumanGoster();
        }

        public void dokumanGoster()
        {
            try 
            {
                string sorgu = "select dokuman_id,dokuman_adi as 'Dökümanlar' from dokuman";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataDokuman.DataSource = dt;
                DataGridViewColumn dokumanID = dataDokuman.Columns[0];
                dokumanID.Visible = false;
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
                txtDokumanAra.Text = "";
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void dokumanDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void dokumanEkle_Click(object sender, EventArgs e)
        {
            try 
            {
                baglan.Open();
                SqlCommand ekle = new SqlCommand();
                ekle.Connection = baglan;
                ekle.CommandText = "insert into dokuman(dokuman_adi) values('" + txtDokumanAra.Text + "')";
                ekle.ExecuteNonQuery();
                baglan.Close();
                dokumanGoster();
                txtTemizle();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void dokumanGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand guncelle = new SqlCommand();
                guncelle.Connection = baglan;
                guncelle.CommandText = "update  dokuman set dokuman_adi='" + txtDokumanAra.Text + "' where dokuman_id=" + dataDokuman.CurrentRow.Cells[0].Value.ToString() + "";
                guncelle.ExecuteNonQuery();
                baglan.Close();
                dokumanGoster();
                txtTemizle();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void dokumanSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand ekle = new SqlCommand();
                ekle.Connection = baglan;
                ekle.CommandText = "delete from dokuman where dokuman_id=" + dataDokuman.CurrentRow.Cells[0].Value.ToString() + "";
                ekle.ExecuteNonQuery();
                baglan.Close();
                dokumanGoster();
                txtTemizle();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void dataDokuman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDokumanAra.Text = dataDokuman.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
