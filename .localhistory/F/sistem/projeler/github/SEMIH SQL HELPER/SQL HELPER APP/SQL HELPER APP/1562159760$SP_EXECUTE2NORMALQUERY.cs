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
using System.Text.RegularExpressions;

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
            ////BMS_DLL.CFGGETSET.AYARLARIYUKLE();
            //BMS_DLL.DX.DXGRID_LOADLAYOUTFROM_REGISTIRY(gridControl1, "CIU", "PERSONELLER");
            //gridControl1.DataSource = BMS_DLL.SQL.SELECT(string.Format("SELECT * FROM BM_101_PERS", BMS_DLL.CFGICERIK.FIRMNR));
            //gridView1.OptionsView.ColumnAutoWidth = false;
            //gridView1.OptionsView.ShowFooter = true;
        }

        private void PERSONELLER_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  BMS_DLL.DX.DXGRID_SAVELAYOUTTO_REGISTIRY(gridControl1, "CIU", "PERSONELLER");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var sql = @" "+memoEdit1.Text+"  ";
            memoEdit2.Text = ConvertSql(sql);
        }
        public static string ConvertSql(string origSql)
        {
            var re = new Regex(@"exec*\s*sp_executesql\s+N'([\s\S]*)',\s*N'(@[\s\S]*?)',\s*([\s\S]*)", RegexOptions.IgnoreCase); // 1: the sql, 2: the declare, 3: the setting
            var match = re.Match(origSql);
            if (match.Success)
            {
                var sql = match.Groups[1].Value.Replace("''", "'");
                //var declare = match.Groups[2].Value;
                var setting = match.Groups[3].Value + ',';

                // to deal with comma or single quote in variable values, we can use the variable name to split
                var re2 = new Regex(@"@[^',]*?\s*=");
                var variables = re2.Matches(setting).Cast<Match>().Select(m => m.Value).ToArray();
                var values = re2.Split(setting).Where(s => !string.IsNullOrWhiteSpace(s)).Select(m => m.Trim(',').Trim().Trim(';')).ToArray();
                for (int i = variables.Length - 1; i >= 0; i--)
                {
                    sql = Regex.Replace(sql, "(" + variables[i].Replace("=", "") + ")", values[i], RegexOptions.Singleline);
                }
                return sql;
            }

            return @"Unknown sql query format.";

        }
    }
}