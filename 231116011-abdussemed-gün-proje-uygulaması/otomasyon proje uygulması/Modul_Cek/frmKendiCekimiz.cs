using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon_proje_uygulması.Modul_Cek
{
    public partial class frmKendiCekimiz : DevExpress.XtraEditors.XtraForm
    {
        public frmKendiCekimiz()
        {
            InitializeComponent();
        }

        private void frmKendiCekimiz_Load(object sender, EventArgs e)
        {
            txtVadeTarıhı.Text = DateTime.Now.ToShortDateString();

        }
    }
}