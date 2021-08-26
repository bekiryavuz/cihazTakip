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
using Dapper;
using System.Net.Mail;

namespace cihazTakip
{
    public partial class cihazTeslim : Form
    {
        Cihaz_Takip_Otomasyonu_Sistemi mainform;
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;");
        string getir = "";
        
        public cihazTeslim(Cihaz_Takip_Otomasyonu_Sistemi parent)
        {
            InitializeComponent();
            mainform = parent;
            veriGetir(getir);
        }

        private void cihazTeslim_Load(object sender, EventArgs e)
        {
            
        }

        public void veriGetir(string getir)
        {
            try
            {
                if (getir == "")
                {
                    getir = "select cihaz_bt,cihaz_marka_adi,cihaz_isyeri,cihaz_gelis_nedeni,cihaz_yapilan_is,cihaz_gelis_tarihi from cihaz_kayit order by cihaz_id desc";
                }
                else
                {
                    getir = "select cihaz_bt,cihaz_marka_adi,cihaz_isyeri,cihaz_gelis_nedeni,cihaz_yapilan_is,cihaz_gelis_tarihi from cihaz_kayit where cihaz_bt like '%" + getir + "%' or cihaz_marka_adi like '%" + getir + "%' or cihaz_isyeri like '%" + getir + "%' or cihaz_gelis_nedeni like '%" + getir + "%' or cihaz_yapilan_is like '%" + getir + "%' or cihaz_gelis_tarihi like  '%" + getir + "%' order by cihaz_id desc ";
                }
                cihazTeslimBilgilerBindingSource.DataSource = baglan.Query<cihazTeslimBilgiler>(getir, commandType: CommandType.Text);
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void butonTutanak_Click(object sender, EventArgs e)
        {
            try 
            {
                cihazTeslimBilgiler obj = cihazTeslimBilgilerBindingSource.Current as cihazTeslimBilgiler;
                if (obj != null)
                {
                    using (IDbConnection db = new SqlConnection(@"Data Source=DESKTOP-HUU8UV5\SQLEXPRESS;Initial Catalog=cihazTakip;Integrated Security=True;"))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        string query = "select cihaz_bt,cihaz_marka_adi,cihaz_isyeri,cihaz_gelis_nedeni,cihaz_yapilan_is,cihaz_gelis_tarihi from cihaz_kayit,gorevli where cihaz_kayit.gorevli=gorevli.gorevli_id order by cihaz_id desc";
                        cihazTeslimBilgilerBindingSource.DataSource = db.Query<cihazTeslimBilgiler>(query, commandType: CommandType.Text);
                        using (frmPrint frm = new frmPrint(obj))
                        {
                            frm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
            veriGetir(getir);
        }


        private void butonMail_Click(object sender, EventArgs e)
        {
            try
            {
                string[] tarihGelis = mainform.dataCihazlar.CurrentRow.Cells[10].Value.ToString().Split(' ');
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress("***@gmail.com");//Mail giriniz
                message.To.Add(textMailAdresi.Text);
                message.Body = tarihGelis[0] + " tarihinde teslim ettiğiniz " + mainform.dataCihazlar.CurrentRow.Cells[2].Value.ToString() + " " + "bt numaralı cihazınız hazırdır. ";
                message.Subject = "TCDD 2.Bölge Destek Hizmetleri";
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("***@gmail.com", "****"); //Mail ve Password giriniz
                client.Send(message);
                message = null;
                MessageBox.Show("Mesaj Gönderildi!","İşlem başarılı!");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message,"Mesaj gönderilemedi!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            veriGetir(textBox1.Text);
        }
    }
}
