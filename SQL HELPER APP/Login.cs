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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void sb_LOGIN_Click(object sender, EventArgs e)
        {
            if (te_USERNAME.Text == "1" && te_PASSWORD.Text == "1")
            {
                BMS_DLL.DX.TEMAREGISTRYYUKLE("XtraReportDesigner");

                BMS_DLL.GLOBAL.FORMAC(false, new MainForm(), this, false, null);
                Hide();
            }
            else MessageBox.Show("Kullanıcı Adı / Şifre Hatalı");

            //GLOBAL._FormAc(true,new EXCEL2APP(), this, false, null);
            // BMS_DLL.DX.TEMAYUKLEFOLDERUSERS("TEST");



        }
    }
}