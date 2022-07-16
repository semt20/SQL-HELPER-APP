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
            Methods.GLOBAL.FORMAC(true, new SP_EXECUTE2NORMALQUERY(), this, false, null);
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Methods.GLOBAL.FORMAC(true, new SQLTABLEGENERATOR(), this, false, null);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Methods.GLOBAL.FORMAC(true, new SP_CLASSTOCONVERTER(), this, false, null);
        }

        private void bbi_SdfFileViewer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Methods.GLOBAL.FORMAC(true, new Frm_SDFFileViewer(), this, false, null);
        }

        private void bbi_SqlFormatter_ItemClick(object sender, ItemClickEventArgs e)
        {
            Methods.GLOBAL.FORMAC(true, new Frm_SQLFormatter(), this, false, null);

        }
    }
}