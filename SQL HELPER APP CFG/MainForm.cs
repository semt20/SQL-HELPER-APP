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
using System.Security.Cryptography;
using System.IO;
using System.Xml;

namespace SQL_HELPER_APP_CFG
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            BMS_DLL.CFGGETSET.AYARLARIYUKLE();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            BMS_DLL.GLOBAL.FORMAC(true, new Ayarlar(), this, false, null);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            BMS_DLL.CFGGETSET.AYARLARIYUKLE();
            // BMS_DLL.GLOBAL.NUMARATOR();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string[] LG_TABLES =  {
              @"CREATE TABLE [BM_S_POSITIONS](
	[ID] [INT] IDENTITY(1,1) NOT NULL,
	[LOGICALREF] [INT] NOT NULL,
	[CODE] [NVARCHAR](128) NOT NULL,
    [DESCRIPTION] [VARCHAR](250) NULL,
	[DEPTNAME_ENG] [VARCHAR](250) NULL,
 CONSTRAINT [PK_BM_S_POSITIONS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
",

                                  };

            BMS_DLL.SQL.TABLOLARIOLUSTUR(typeof(PROGRESSFORM), this, LG_TABLES, false, null);
        }
    }
}