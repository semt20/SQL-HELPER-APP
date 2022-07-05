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
    public partial class SP_CLASSTOCONVERTER : DevExpress.XtraEditors.XtraForm
    {
        public SP_CLASSTOCONVERTER()
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
            var sql = @" " + memoEdit1.Text + "  ";
            {
                List<ResultList> RL = ConvertModelToConverterClass(sql);
                memoEdit2.Text = "";
                foreach (var item in RL)
                {
                    memoEdit2.Text = memoEdit2.Text + item.Line + Environment.NewLine;
                }
            }
            {
                List<ResultList> RL = ConvertModelToConverterClass(sql, true);
                //memoEdit2.Text = "";
                foreach (var item in RL)
                {
                    memoEdit2.Text = memoEdit2.Text + item.Line + Environment.NewLine;
                }
            }
        }
        public class ResultList
        {
            public string Line { get; set; }
        }
        public static List<ResultList> ConvertModelToConverterClass(string model, bool isDataRow = false)
        {
            var lines = model.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            var sb = new StringBuilder();
            List<ResultList> RL = new List<ResultList>();
            string className = "";
            foreach (string line in lines)
            {
                ResultList r = new ResultList();
                string realLine = line.Trim();
                if (line.Contains("public class"))
                {
                    r.Line = className = realLine.Replace("public class", "").Trim();
                    if (!isDataRow) r.Line = "List<" + r.Line + "> " + r.Line + "_CONVERT_FROM_DATATABLE(DataTable dt)";
                    if (isDataRow) r.Line = r.Line + " " + r.Line + "_CONVERT_FROM_DATAROW(DataRow r)";
                    RL.Add(r);
                    if (isDataRow == false)
                    {
                        RL.Add(new ResultList() { Line = "{" });
                        RL.Add(new ResultList() { Line = "List<" + className + "> L = new List<" + className + ">();" });
                        RL.Add(new ResultList() { Line = "foreach (DataRow r in dt.Rows)" });
                    }
                    RL.Add(new ResultList() { Line = "{" });
                    RL.Add(new ResultList() { Line = className + " B = new " + className + "();" });
                }
                if (realLine == "{") continue;
                if (realLine.Contains("{ get; set; }"))
                {
                    realLine = realLine.Replace("{ get; set; }", "");
                    realLine = realLine.Replace("= string.Empty;", "");

                    if (realLine.Contains("public int "))
                    {
                        realLine = realLine.Replace("public int ", "").Trim();
                        realLine = "try { B." + realLine + " = (int)r[\"" + realLine + "\"]; } catch { }";
                    }
                    if (realLine.Contains("public DateTime "))
                    {
                        realLine = realLine.Replace("public DateTime ", "").Trim();
                        realLine = "try { B." + realLine + " = (DateTime)r[\"" + realLine + "\"]; } catch { }";
                    }

                    if (realLine.Contains("public string "))
                    {
                        realLine = realLine.Replace("public string ", "").Trim();
                        realLine = "try { B." + realLine + " = (string)r[\"" + realLine + "\"]; } catch { }";
                    }

                    if (realLine.Contains("public double "))
                    {
                        realLine = realLine.Replace("public double ", "").Trim();
                        realLine = "try { B." + realLine + " = (double)r[\"" + realLine + "\"]; } catch { }";
                    }

                    if (realLine.Contains("public short "))
                    {
                        realLine = realLine.Replace("public short ", "").Trim();
                        realLine = "try { B." + realLine + " = (short)r[\"" + realLine + "\"]; } catch { }";
                    }
                    RL.Add(new ResultList() { Line = realLine }); ;
                }

            }
            if (isDataRow == false)
            {
                RL.Add(new ResultList() { Line = "L.Add(B);" }); ;
                RL.Add(new ResultList() { Line = "};" }); ;
                RL.Add(new ResultList() { Line = "return L;" }); ;
                RL.Add(new ResultList() { Line = "}" });
            }
            else
            {
                RL.Add(new ResultList() { Line = "return B;" }); ;
                RL.Add(new ResultList() { Line = "}" });
            }
            return RL;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}