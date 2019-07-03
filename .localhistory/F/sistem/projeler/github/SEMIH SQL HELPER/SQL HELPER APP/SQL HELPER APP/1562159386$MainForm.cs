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
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting.Preview;
using SQL_HELPER_APP.Properties;
using DevExpress.LookAndFeel;
using System.IO;

namespace SQL_HELPER_APP
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void barButtonItemReportDesigner_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //BMS_DLL.DX.XTRAREPORT_AC("select * from BM_219_SIPARIS", null, true);
            BMS_DLL.GLOBAL.FORMAC(true, new PERSONELLER(), this, false, null);
        }
        public static void TEMAKAYDETFOLDERUSERS(string USERNAME)
        {

        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //  BMS_DLL.DX.TEMAKAYDETFOLDERUSERS("TEST");


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BMS_DLL.CFGGETSET.AYARLARIYUKLE();
        }

        private void Skins_Gallery_PopupClose(object sender, InplaceGalleryEventArgs e)
        {
            BMS_DLL.DX.TEMAREGISTRYKAYDET("XtraReportDesigner");
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            BMS_DLL.GLOBAL.FORMAC(true, new Departmanlar(), this, false, null);

        }
    }
}