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
    public partial class SQLTABLEGENERATOR : DevExpress.XtraEditors.XtraForm
    {
        public SQLTABLEGENERATOR()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            memoEdit1.Text = "";
            string IMAGEFIELD = "0";
            memoEdit1.Text += "CREATE TABLE [dbo].[" + textEdit1.Text + "](" + Environment.NewLine;
            memoEdit1.Text += "[" + textEdit2.Text + "] [INT] IDENTITY(1,1) NOT NULL," + Environment.NewLine;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                string NAME = "[" + gridView1.GetRowCellValue(i, "NAME").ToString() + "]";
                string TYPE = "[" + gridView1.GetRowCellValue(i, "TYPE").ToString() + "]";
                string LENGTH = gridView1.GetRowCellValue(i, "LENGTH").ToString();
                string ISNULL = gridView1.GetRowCellValue(i, "ISNULL").ToString();
                ISNULL = ISNULL == "True" ? " NULL," : ",";
                if (IMAGEFIELD == "0")
                {
                    IMAGEFIELD = TYPE == "[Image]" ? "1" : "0";
                }
                switch (TYPE)
                {
                    case "[Datetimeoffset]": TYPE = "[DATETIMEOFFSET](7)"; break;
                    case "[Decimal]": TYPE = "[DECIMAL](18, 0)"; break;
                    case "[Nchar]": TYPE = "[NCHAR](10)"; break;
                    case "[Numeric]": TYPE = "[NUMERIC](18, 0)"; break;
                    case "[Nvarchar]": TYPE = "[NVARCHAR](50)"; break;
                    case "[Nvarchar(max)]": TYPE = "[NVARCHAR](MAX)"; break;
                    case "[Time]": TYPE = "[TIME](7)"; break;
                    case "[Varbinary]": TYPE = "[VARBINARY](50)"; break;
                    case "[Varbinary(max)]": TYPE = "[VARBINARY](MAX)"; break;
                    case "[Varchar]": TYPE = "[VARCHAR](255)"; break;
                    case "[Varchar(max)]": TYPE = "[VARCHAR](MAX)"; break;
                    default: break;
                }
                memoEdit1.Text += NAME + " " + TYPE + ISNULL;
                memoEdit1.Text += Environment.NewLine;
            }
            memoEdit1.Text += "CONSTRAINT [PK_" + textEdit1.Text + "] PRIMARY KEY CLUSTERED " + Environment.NewLine;
            memoEdit1.Text += "(" + Environment.NewLine;
            memoEdit1.Text += "[" + textEdit2.Text + "] ASC" + Environment.NewLine;
            memoEdit1.Text += ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]" + Environment.NewLine;
            memoEdit1.Text += IMAGEFIELD == "1" ? ") ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]" + Environment.NewLine : ") ON [PRIMARY] " + Environment.NewLine;
        }

        private void repositoryItemButtonEditSIL_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();

        }
    }
}