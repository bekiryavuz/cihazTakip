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
    public partial class dokumanlar : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");
        public dokumanlar()
        {
            InitializeComponent();
        }

        private void butonDokuman_Click(object sender, EventArgs e)
        {
            try
            {
                string dosya = comboDokumanSec.SelectedItem + ".pdf";
                axAcroPDF1.src = @"C:\\Users\bekiryavuz.culsuz\\Desktop\\Documents\\" + dosya + "";
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void dokumanlar_Load(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select dokuman_adi from dokuman", baglan);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comboDokumanSec.Items.Add(dr[0]);

                }
                baglan.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
