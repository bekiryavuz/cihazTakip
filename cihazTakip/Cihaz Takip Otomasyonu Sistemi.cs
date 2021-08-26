using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.CompilerServices;


namespace cihazTakip
{
    public partial class Cihaz_Takip_Otomasyonu_Sistemi : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");
        SqlDataAdapter da;
        DataTable dt;
        public static string bul="";
        
        

        
        public void yetkiKontrol()
        {
            try
            {
                butonCihazGiris.Enabled = false;
                butonCihazTeslim.Enabled = false;
                butonTelefonDuzenle.Enabled = false;
                butonGorevliDuzenle.Enabled = false;
                butonDokumanDuzenle.Enabled = false;

                if (labelKullanici.Text == "Administrator ")
                {
                    butonCihazGiris.Enabled = true;
                    butonCihazTeslim.Enabled = true;
                    butonTelefonDuzenle.Enabled = true;
                    butonGorevliDuzenle.Enabled = true;
                    butonDokumanDuzenle.Enabled = true;
                    panelAc(new cihazGiris(this));
                }
                if (labelKullanici.Text == "Ziyaretci")
                {

                }
                else
                {
                    butonCihazGiris.Enabled = true;
                    butonCihazTeslim.Enabled = true;
                    panelAc(new cihazGiris(this));
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
        
        public void dataCihazlarGoster(string sorgu)
        {
            try
            {
                if (sorgu == "")
                {
                    sorgu = "select cihaz_durum,cihaz_id, cihaz_bt as 'Bt Numarası',cihaz_domain as 'Domain Adı',cihaz_isyeri as 'İşyeri',cihaz_turu as 'Cihaz Türü',cihaz_marka_adi as 'Marka Adı',cihaz_gelis_nedeni as 'Geliş Nedeni',cihaz_yapilan_is as 'Yapılan İş',gorevli.gorevli_adi+' '+gorevli.gorevli_soyadi as 'Görevli',cihaz_gelis_tarihi as 'Geliş Tarihi',cihaz_teslim_tarihi as 'Teslim Tarihi',cihaz_sahibi as 'Cihaz Sahibi' from cihaz_kayit,gorevli where cihaz_kayit.gorevli=gorevli.gorevli_id order by cihaz_id desc";
                }
                else
                {
                    sorgu = "select  cihaz_durum,cihaz_id, cihaz_bt as 'Bt Numarası',cihaz_domain as 'Domain Adı',cihaz_isyeri as 'İşyeri',cihaz_turu as 'Cihaz Türü',cihaz_marka_adi as 'Marka Adı',cihaz_gelis_nedeni as 'Geliş Nedeni',cihaz_yapilan_is as 'Yapılan İş',gorevli.gorevli_adi + ' ' + gorevli.gorevli_soyadi as 'Görevli',cihaz_gelis_tarihi as 'Geliş Tarihi',cihaz_teslim_tarihi as 'Teslim Tarihi',cihaz_sahibi as 'Cihaz Sahibi' from cihaz_kayit, gorevli where cihaz_kayit.gorevli = gorevli.gorevli_id and(cihaz_id like '%" + sorgu + "%' or cihaz_durum like '%" + sorgu + "%' or cihaz_domain like '%" + sorgu + "%' or cihaz_bt like '%" + sorgu + "%' or cihaz_isyeri like '%" + sorgu + "%' or cihaz_turu like '%" + sorgu + "%' or cihaz_marka_adi like '%" + sorgu + "%' or cihaz_gelis_nedeni like '%" + sorgu + "%' or cihaz_yapilan_is like '%" + sorgu + "%' or cihaz_gelis_tarihi like '%" + sorgu + "%' or cihaz_teslim_tarihi like '%" + sorgu + "%' or cihaz_sahibi like '%" + sorgu + "%' or gorevli_adi like '%" + sorgu + "%'or gorevli_soyadi like '%" + sorgu + "%') order by cihaz_id desc";
                }
                da = new SqlDataAdapter(sorgu, baglan);
                dt = new DataTable();
                da.Fill(dt);
                dataCihazlar.DataSource = dt;
                DataGridViewColumn cihazDurumCheck = dataCihazlar.Columns[0];
                cihazDurumCheck.Visible = false;
                DataGridViewColumn cihazidCheck = dataCihazlar.Columns[1];
                cihazidCheck.Visible = false;
                cihazDurumGoster();
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        public void cihazDurumGoster()
        {
            try
            {
                foreach (DataGridViewRow row in dataCihazlar.Rows)
                {
                    if ((row.Cells[0].Value) == DBNull.Value)
                    {
                        row.Cells[0].Value = 0;
                    }
                    else if (Convert.ToInt32(row.Cells[0].Value) == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Gainsboro;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
        
        

        public Cihaz_Takip_Otomasyonu_Sistemi()
        {
            try
            {
                InitializeComponent();
                dataCihazlarGoster(bul);
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
        private void Cihaz_Takip_Otomasyonu_Sistemi_Load(object sender, EventArgs e)
        {
            try
            {
                cihazDurumGoster();
                yetkiKontrol();
                labelCihazid.Text = dataCihazlar.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }



        public void panelAc(object yeniForm)
        {
            try
            {
                this.panel1.Controls.Clear();
                Form cls = yeniForm as Form;
                cls.TopLevel = false;
                cls.Dock = DockStyle.Fill;
                cls.FormBorderStyle = FormBorderStyle.None;
                this.panel1.Controls.Add((Control)cls);
                this.panel1.Tag = cls;
                cls.BringToFront();
                cls.Show();
                dataCihazlarGoster(bul);
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }
            
        }
        

        
        private void butonCihazGiris_Click(object sender, EventArgs e)
        {
            panelAc(new cihazGiris(this));
        }

        private void butonCihazTeslim_Click(object sender, EventArgs e)
        {
            panelAc(new cihazTeslim(this));
        }

        private void butonCihazAra_Click(object sender, EventArgs e)
        {
            panelAc(new cihazAra(this));
        }

        private void butonGenelAnaliz_Click(object sender, EventArgs e)
        {
            panelAc(new genelAnaliz());
        }

        private void butonGenelDurum_Click(object sender, EventArgs e)
        {
            panelAc(new genelDurum());
        }

        private void butonDokumanlar_Click(object sender, EventArgs e)
        {
            panelAc(new dokumanlar());
        }

        private void butonTelefonlar_Click(object sender, EventArgs e)
        {
            panelAc(new telefonlar(this));
        }

        private void butonTelefonDuzenle_Click(object sender, EventArgs e)
        {
            panelAc(new telefonDuzenle());
        }

        private void butonDokumanDuzenle_Click(object sender, EventArgs e)
        {
            panelAc(new dokumanDuzenle());
        }
        private void butonGorevliDuzenle_Click(object sender, EventArgs e)
        {
            panelAc(new gorevliDuzenle());
        }




        private void butonOturumKapat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form1 giris = new Form1();
                giris.Show();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void dataCihazlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelCihazid.Text = dataCihazlar.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void Cihaz_Takip_Otomasyonu_Sistemi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
