using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cihazTakip
{
    public partial class frmPrint : Form
    {
        cihazTeslimBilgiler _cihazTeslimBilgiler;
        public frmPrint(cihazTeslimBilgiler cihazTeslimBilgi)
        {
            InitializeComponent();
            _cihazTeslimBilgiler = cihazTeslimBilgi;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            try
            {
                cihazRapor1.SetParameterValue("pisyeri", _cihazTeslimBilgiler.cihaz_isyeri);
                cihazRapor1.SetParameterValue("pBt", _cihazTeslimBilgiler.cihaz_bt);
                cihazRapor1.SetParameterValue("pMarka", _cihazTeslimBilgiler.cihaz_marka_adi);
                cihazRapor1.SetParameterValue("pYapilanislem", _cihazTeslimBilgiler.cihaz_yapilan_is);
                cihazRapor1.SetParameterValue("pGelisNedeni", _cihazTeslimBilgiler.cihaz_gelis_nedeni);
                cihazRapor1.SetParameterValue("pGelisTarihi", _cihazTeslimBilgiler.cihaz_gelis_tarihi.ToString("dd/MM/yyyy"));
                cihazRapor1.SetParameterValue("pTarih", DateTime.Now.ToString("dd/MM/yyyy"));
                crystalReportViewer1.ReportSource = cihazRapor1;
                crystalReportViewer1.Refresh();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
