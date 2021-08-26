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
    public partial class genelDurum : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");
        
        SqlCommand goster;
        public genelDurum()
        {
            InitializeComponent();
        }

        public void toplamRakamlar()
        {
            try
            {
                baglan.Open();
                goster = new SqlCommand("select count(*) from cihaz_kayit where cihaz_durum='0'", baglan);
                Object gosterAktif = goster.ExecuteScalar();
                labelAktif.Text = gosterAktif.ToString();
                baglan.Close();
                baglan.Open();
                goster = new SqlCommand("select count(*) from cihaz_kayit where cihaz_durum='1'", baglan);
                Object gosterYapilmis = goster.ExecuteScalar();
                labelYapilmis.Text = gosterYapilmis.ToString();
                baglan.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void genelDurum_Load(object sender, EventArgs e)
        {
            toplamRakamlar();
        }
    }
}
