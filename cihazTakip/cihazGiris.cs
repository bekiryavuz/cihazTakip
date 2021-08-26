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
using System.Globalization;

namespace cihazTakip
{
    public partial class cihazGiris : Form
    {
        Cihaz_Takip_Otomasyonu_Sistemi mainform;
        CultureInfo provider = CultureInfo.InvariantCulture;
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");
        SqlCommand komut;
        SqlDataReader dr;
        public string cihazid = "";
        


        public cihazGiris(Cihaz_Takip_Otomasyonu_Sistemi parent)
        {
            
            InitializeComponent(); 
            mainform = parent;
            
        }

        public void txtDoldur()
        {
            try
            {
                if (mainform.dataCihazlar.SelectedRows.Count > 0)
                {
                    string[] tarihGelis = mainform.dataCihazlar.CurrentRow.Cells[10].Value.ToString().Split(' ');
                    string[] tarihTeslim = mainform.dataCihazlar.CurrentRow.Cells[11].Value.ToString().Split(' ');
                    string comboDurum = "True";
                    if (mainform.dataCihazlar.CurrentRow.Cells[0].Value.ToString() == comboDurum)
                    {
                        comboDurum = "Hazır";
                    }
                    else
                    {
                        comboDurum = "Hazır Değil";
                    }
                    txtBtNumarasi.Text = mainform.dataCihazlar.CurrentRow.Cells[2].Value.ToString();
                    txtDomainAdi.Text = mainform.dataCihazlar.CurrentRow.Cells[3].Value.ToString();
                    txtisyeri.Text = mainform.dataCihazlar.CurrentRow.Cells[4].Value.ToString();
                    txtCihazTuru.Text = mainform.dataCihazlar.CurrentRow.Cells[5].Value.ToString();
                    txtMarkaAdi.Text = mainform.dataCihazlar.CurrentRow.Cells[6].Value.ToString();
                    txtGelisNedeni.Text = mainform.dataCihazlar.CurrentRow.Cells[7].Value.ToString();
                    txtYapilanis.Text = mainform.dataCihazlar.CurrentRow.Cells[8].Value.ToString();
                    comboGorevli.SelectedItem = mainform.dataCihazlar.CurrentRow.Cells[9].Value.ToString();
                    dateGelisTarihi.Value = Convert.ToDateTime(tarihGelis[0]);
                    dateTeslimTarihi.Value = Convert.ToDateTime(tarihTeslim[0]);
                    txtCihazSahibi.Text = mainform.dataCihazlar.CurrentRow.Cells[12].Value.ToString();
                    comboCihazDurum.SelectedItem = comboDurum;
                }
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
                txtBtNumarasi.Text = "";
                txtDomainAdi.Text = "";
                txtisyeri.Text = "";
                txtCihazTuru.Text = "";
                txtMarkaAdi.Text = "";
                txtGelisNedeni.Text = "";
                txtYapilanis.Text = "";
                comboGorevli.SelectedIndex = -1;
                dateGelisTarihi.Value = DateTime.Now;
                dateTeslimTarihi.Value = DateTime.Now;
                txtCihazSahibi.Text = "";
                comboCihazDurum.SelectedIndex = -1;
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void butonCihazKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                cihazid = mainform.labelCihazid.Text;
                SqlCommand kaydet = new SqlCommand();
                baglan.Open();
                kaydet.Connection = baglan;
                kaydet.CommandText = "insert into cihaz_kayit (cihaz_bt,cihaz_domain,cihaz_isyeri,cihaz_turu,cihaz_marka_adi,cihaz_gelis_nedeni,cihaz_yapilan_is,gorevli,cihaz_gelis_tarihi,cihaz_teslim_tarihi,cihaz_sahibi,cihaz_durum) values ('" + txtBtNumarasi.Text + "','" + txtDomainAdi.Text + "','" + txtisyeri.Text + "','" + txtCihazTuru.Text + "','" + txtMarkaAdi.Text + "','" + txtGelisNedeni.Text + "','" + txtYapilanis.Text + "',(select gorevli_id from gorevli where gorevli.gorevli_adi+' '+gorevli.gorevli_soyadi='" + comboGorevli.GetItemText(comboGorevli.SelectedItem) + "'),'" + dateGelisTarihi.Value.Date.ToString("yyyyMMdd") + "','" + dateTeslimTarihi.Value.Date.ToString("yyyyMMdd") + "','" + txtCihazSahibi.Text + "',(select durum from durum where durum.durum_adi='" + comboCihazDurum.GetItemText(comboCihazDurum.SelectedItem) + "'))";
                kaydet.ExecuteNonQuery();
                baglan.Close();
                txtTemizle();
                mainform.dataCihazlarGoster("");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void butonCihazGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                cihazid = mainform.labelCihazid.Text;
                SqlCommand guncelle = new SqlCommand();
                baglan.Open();
                guncelle.Connection = baglan;
                guncelle.CommandText = "update  cihaz_kayit set cihaz_bt='" + txtBtNumarasi.Text + "',cihaz_domain='" + txtDomainAdi.Text + "',cihaz_isyeri='" + txtisyeri.Text + "',cihaz_turu='" + txtCihazTuru.Text + "',cihaz_marka_adi='" + txtMarkaAdi.Text + "',cihaz_gelis_nedeni='" + txtGelisNedeni.Text + "',cihaz_yapilan_is='" + txtYapilanis.Text + "',gorevli=(select gorevli_id from gorevli where gorevli.gorevli_adi+' '+gorevli.gorevli_soyadi='" + comboGorevli.GetItemText(comboGorevli.SelectedItem) + "'),cihaz_gelis_tarihi='" + dateGelisTarihi.Value.Date.ToString("yyyyMMdd") + "',cihaz_teslim_tarihi='" + dateTeslimTarihi.Value.Date.ToString("yyyyMMdd") + "',cihaz_sahibi='" + txtCihazSahibi.Text + "',cihaz_durum=(select durum from durum where durum.durum_adi='" + comboCihazDurum.GetItemText(comboCihazDurum.SelectedItem) + "') where cihaz_id=" + cihazid + "";
                guncelle.ExecuteNonQuery();
                baglan.Close();
                txtTemizle();
                mainform.dataCihazlarGoster("");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void butonCihazSil_Click(object sender, EventArgs e)
        {
            try
            {
                cihazid = mainform.labelCihazid.Text;
                SqlCommand sil = new SqlCommand();
                baglan.Open();
                sil.Connection = baglan;
                sil.CommandText = "delete from cihaz_kayit where cihaz_id=" + cihazid + "";
                sil.ExecuteNonQuery();
                baglan.Close();
                txtTemizle();
                mainform.dataCihazlarGoster("");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
        
        
        

        private void cihazGiris_Load(object sender, EventArgs e)
        {
            try
            {
                butonCihazSil.Enabled = false;
                if (mainform.labelKullanici.Text == "Administrator ")
                {
                    butonCihazSil.Enabled = true;
                }

                baglan.Open();
                komut = new SqlCommand("select gorevli_adi+' '+gorevli_soyadi from gorevli where gorevli_id>1", baglan);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comboGorevli.Items.Add(dr[0]);
                }
                baglan.Close();

                baglan.Open();
                komut = new SqlCommand("select durum_adi from durum", baglan);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comboCihazDurum.Items.Add(dr[0]);
                }
                baglan.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void butonGetir_Click(object sender, EventArgs e)
        {
            txtDoldur();
        }

        private void butonTemizle_Click(object sender, EventArgs e)
        {
            txtTemizle();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
