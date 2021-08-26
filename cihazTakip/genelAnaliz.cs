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
    public partial class genelAnaliz : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");
        public genelAnaliz()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        public void chart1Goster()
        {
            try
            {
                List<int> gorevliListe = new List<int>();
                List<string> gorevliAdSoyad = new List<string>();
                List<int> gorevliCalisma = new List<int>();

                baglan.Open();
                SqlCommand komut = new SqlCommand("select gorevli_id from gorevli where gorevli_id >1", baglan);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    gorevliListe.Add(Convert.ToInt32(dr[0]));
                }
                baglan.Close();

                for (int calis = 0; calis < gorevliListe.Count; calis++)
                {
                    baglan.Open();
                    SqlCommand goster = new SqlCommand("select count(cihaz_durum) from cihaz_kayit where cihaz_durum=1 and gorevli=" + gorevliListe[calis] + "", baglan);
                    Object gosterYapilmis = goster.ExecuteScalar();
                    gorevliCalisma.Add(Convert.ToInt32(gosterYapilmis));
                    baglan.Close();
                }

                for (int calis = 0; calis < gorevliListe.Count; calis++)
                {
                    baglan.Open();
                    SqlCommand goster = new SqlCommand("select gorevli_adi+' ' + gorevli_soyadi from gorevli where gorevli_id = " + gorevliListe[calis] + "", baglan);
                    Object gosterAdSoyad = goster.ExecuteScalar();
                    gorevliAdSoyad.Add(Convert.ToString(gosterAdSoyad));
                    baglan.Close();
                }

                for (int calis = 0; calis < gorevliListe.Count; calis++)
                {
                    this.chart1.Series["Toplam İş"].Points.Add(gorevliCalisma[calis]);
                    this.chart1.Series["Toplam İş"].Points[calis].AxisLabel = gorevliAdSoyad[calis];
                    this.chart1.Series["Toplam İş"].Points[calis].LegendText = gorevliAdSoyad[calis];
                    this.chart1.Series["Toplam İş"].Points[calis].Label = "" + gorevliCalisma[calis] + "";
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        public void chart2Goster()
        {
            try
            {
                List<string> sorunAdi = new List<string>();
                List<int> sorunMiktari = new List<int>();

                baglan.Open();
                SqlCommand komut = new SqlCommand("select TOP 5 cihaz_gelis_nedeni,count(cihaz_gelis_nedeni) AS 'Miktar' from cihaz_kayit group by cihaz_gelis_nedeni  ORDER BY 'Miktar' desc ", baglan);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    sorunAdi.Add(Convert.ToString(dr[0]));
                }
                baglan.Close();

                baglan.Open();
                SqlCommand komut2 = new SqlCommand("select TOP 5 cihaz_gelis_nedeni,count(cihaz_gelis_nedeni) AS 'Miktar' from cihaz_kayit group by cihaz_gelis_nedeni  ORDER BY 'Miktar' desc ", baglan);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    sorunMiktari.Add(Convert.ToInt32(dr2[1]));
                }
                baglan.Close();

                for (int i = 0; i < 5; i++)
                {
                    this.chart2.Series["Toplam Sorun"].Points.Add(sorunMiktari[i]);
                    this.chart2.Series["Toplam Sorun"].Points[i].AxisLabel = sorunAdi[i];
                    this.chart2.Series["Toplam Sorun"].Points[i].LegendText = sorunAdi[i];
                    this.chart2.Series["Toplam Sorun"].Points[i].Label = "" + sorunMiktari[i] + "";
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
        
        private void genelAnaliz_Load(object sender, EventArgs e)
        {
            chart1Goster();
            chart2Goster();
        }
    }
}
