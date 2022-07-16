using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_HELPER_APP
{

    class Methods
    {
        private SqlDatabase sqlBMSDB;
        public void WRITELOG(string hata, Exception E)
        {
            try
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory + "logs\\";
                Directory.CreateDirectory(directory);
                string path = directory + DateTime.Now.ToString("yyyy.MM.dd") + ".txt";
                if (!File.Exists(path))
                    File.Create(path).Close();
                else
                    File.AppendAllText(path, Environment.NewLine + Environment.NewLine +
                        Environment.NewLine + Environment.NewLine + Environment.NewLine);
                File.AppendAllText(path, DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss") + " : " + hata +
                    Environment.NewLine + (E != null ? " ----- HATA : ----- " + E.ToString() : ""));
            }
            catch { }
        }
        public class GLOBAL
        {
            /// <summary>
            /// <para>Aciklama: Mdi yada yeni ekranda form açar. Örnek Ayarlar adında bir form oluştur</para>
            /// <para> Ornek Kod: Mdi Form:  BMS_DLL.GLOBAL.FORMAC(true, new Ayarlar(), this, false, null);</para>
            /// <para> Ornek Kod: Normal Form:  BMS_DLL.GLOBAL.FORMAC(false, new Ayarlar(), this, false, null);</para>
            /// </summary>
            public static void FORMAC(bool isMDIForm, Form parentForm, Form mainform, bool isFormBasligi, string FormBasligi)
            {
                if (isFormBasligi == true)
                {
                    parentForm.Text = FormBasligi;
                }
                if (isMDIForm == true)
                {
                    parentForm.MdiParent = mainform;
                }
                parentForm.Show();
            }
        }
    }
}
