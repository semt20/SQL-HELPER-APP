using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SQL_HELPER_APP_CFG
{
    public partial class Ayarlar : DevExpress.XtraEditors.XtraForm
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void simpleButtonKAYDET_Click(object sender, EventArgs e)
        {
            BMS_DLL.CFGGETSET.AYARLARIKAYDET(textEditLS_KULLANICIADI.Text, textEditLS_PAROLA.Text, textEditLS_SUNUCU.Text, textEditLS_VERITABANI.Text, textEditLS_RESTAPIURL.Text, comboBoxEditBS_VERITABANITIPI.SelectedIndex, textEditBS_KULLANICIADI.Text, textEditBS_PAROLA.Text, textEditBS_SUNUCU.Text, textEditBS_VERITABANI.Text, textEditFB_FIRMANO.Text, textEditFB_PERIOD.Text, textEditFB_ONCEKIFIRMANO.Text, textEditFB_ONCEKIPERIOD.Text, textEditKB_BMSKULLANICIKODU.Text, textEditKB_BMSPAROLA.Text, textEditKB_LOKULLANICIKODU.Text, textEditKB_LOPAROLA.Text, textEditWS_SERVISSURE.Text, comboBoxEditWS_SURECINSI.SelectedIndex, comboBoxEditWS_SERVISVERITABANIKONTROLTABLOSU.SelectedIndex);

        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {

        }

        private void Ayarlar_Shown(object sender, EventArgs e)
        {
            BMS_DLL.CFGGETSET.AYARLARIYUKLE();
            //BMS_DLL.CFGGETSET SQL_HELPER_APP_CFG = new BMS_DLL.CFGGETSET();
            try { textEditLS_KULLANICIADI.Text = BMS_DLL.CFGICERIK.LGDBUSERNAME; } catch { }
            try { textEditLS_PAROLA.Text = BMS_DLL.CFGICERIK.LGDBPASSWORD; } catch { }
            try { textEditLS_SUNUCU.Text = BMS_DLL.CFGICERIK.LGDBSERVER; } catch { }
            try { textEditLS_VERITABANI.Text = BMS_DLL.CFGICERIK.LGDBDATABASE; } catch { }
            try { textEditLS_RESTAPIURL.Text = BMS_DLL.CFGICERIK.RESTURL; } catch { }

            try { comboBoxEditBS_VERITABANITIPI.SelectedIndex = BMS_DLL.CFGICERIK.BMSDBSERVERTYPE; } catch { }
            try { textEditBS_KULLANICIADI.Text = BMS_DLL.CFGICERIK.BMSDBUSERNAME; } catch { }
            try { textEditBS_PAROLA.Text = BMS_DLL.CFGICERIK.BMSDBPASSWORD; } catch { }
            try { textEditBS_SUNUCU.Text = BMS_DLL.CFGICERIK.BMSDBSERVER; } catch { }
            try { textEditBS_VERITABANI.Text = BMS_DLL.CFGICERIK.BMSDBDATABASE; } catch { }

            try { textEditFB_FIRMANO.Text = BMS_DLL.CFGICERIK.FIRMNR; } catch { }
            try { textEditFB_PERIOD.Text = BMS_DLL.CFGICERIK.PERIOD; } catch { }
            try { textEditFB_ONCEKIFIRMANO.Text = BMS_DLL.CFGICERIK.PREVIOUSFIRMNR; } catch { }
            try { textEditFB_ONCEKIPERIOD.Text = BMS_DLL.CFGICERIK.PREVIOUSPERIOD; } catch { }

            try { textEditKB_BMSKULLANICIKODU.Text = BMS_DLL.CFGICERIK.BMSDEFAULTUSERNAME; } catch { }
            try { textEditKB_BMSPAROLA.Text = BMS_DLL.CFGICERIK.BMSDEFAULTPASSWORD; } catch { }
            try { textEditKB_LOKULLANICIKODU.Text = BMS_DLL.CFGICERIK.LOBJECTDEFAULTUSERNAME; } catch { }
            try { textEditKB_LOPAROLA.Text = BMS_DLL.CFGICERIK.LOBJECTDEFAULTPASSWORD; } catch { }

            try { textEditWS_SERVISSURE.Text = BMS_DLL.CFGICERIK.SERVICEPERIOD.ToString(); } catch { }
            try { comboBoxEditWS_SURECINSI.SelectedIndex = BMS_DLL.CFGICERIK.SERVICEPERIODTYPE; } catch { }
            try { comboBoxEditWS_SERVISVERITABANIKONTROLTABLOSU.SelectedIndex = BMS_DLL.CFGICERIK.SERVICETABLESDBCHOICE; } catch { }
        }
    }
}