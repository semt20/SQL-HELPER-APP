using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SQL_HELPER_APP
{
    public partial class SP_EXECUTE2NORMALQUERY : DevExpress.XtraEditors.XtraForm
    {
        public SP_EXECUTE2NORMALQUERY()
        {
            InitializeComponent();
        }

        private void PERSONELLER_Load(object sender, EventArgs e)
        {
            //BMS_DLL.CFGGETSET.AYARLARIYUKLE();
            BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(gridControl1, "CIU", "PERSONELLER");
            gridControl1.DataSource = BMS_DLL.SQL.SELECT(string.Format("SELECT * FROM BM_101_PERS", BMS_DLL.CFGICERIK.FIRMNR));
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.ShowFooter = true;
        }

        private void PERSONELLER_FormClosing(object sender, FormClosingEventArgs e)
        {
            BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(gridControl1, "CIU", "PERSONELLER");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BMS_DLL.DX.DXGRIDEXCELEKAYDET(gridView1, true);
        }
    }
}