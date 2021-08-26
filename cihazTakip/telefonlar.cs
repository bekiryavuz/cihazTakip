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
    public partial class telefonlar : Form
    {
        Cihaz_Takip_Otomasyonu_Sistemi mainform;

        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");
        SqlDataAdapter da;
        DataTable dt;
        string sorgu = "";

        public void dataTelefonGoster(string sorgu)
        {
            try
            {
                if (sorgu == "")
                {
                    sorgu = "select personel_isyeri as 'Personel İşyeri', personel.personel_adi+' '+personel.personel_soyadi as 'Personel', personel_telefon as 'Telefon'  from personel order by personel_isyeri";
                }
                else
                {
                    sorgu = "select personel_isyeri as 'Personel İşyeri', personel.personel_adi+' '+personel.personel_soyadi as 'Personel', personel_telefon as 'Telefon'  from personel  where personel_adi like '%" + sorgu + "%' or personel_soyadi like '%" + sorgu + "%' or personel_isyeri like '%" + sorgu + "%' or personel_telefon like '%" + sorgu + "%' ";
                }

                da = new SqlDataAdapter(sorgu, baglan);
                dt = new DataTable();
                da.Fill(dt);
                dataTelefonlar.DataSource = dt;
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }


        public telefonlar(Cihaz_Takip_Otomasyonu_Sistemi parent)
        {
            InitializeComponent();
            mainform = parent;
            dataTelefonGoster(sorgu);
        }

        private void txtTelefonAra_TextChanged(object sender, EventArgs e)
        {
            dataTelefonGoster(txtTelefonAra.Text);
        }
    }
}
