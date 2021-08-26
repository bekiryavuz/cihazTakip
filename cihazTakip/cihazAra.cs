using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cihazTakip
{
    public partial class cihazAra : Form
    {
        Cihaz_Takip_Otomasyonu_Sistemi mainform;

        public cihazAra(Cihaz_Takip_Otomasyonu_Sistemi parent)
        {
            InitializeComponent();
            mainform = parent;
        }
       
        private void txtCihazAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mainform.dataCihazlarGoster(txtCihazAra.Text);
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
