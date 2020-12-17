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
using DevExpress.XtraGrid.Views.Grid;

namespace SQL_HELPER_APP {
    public partial class SQLTABLEGENERATOR : DevExpress.XtraEditors.XtraForm {
        public SQLTABLEGENERATOR() {
            InitializeComponent();
 
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            memoEdit1.Text = "";
            string IMAGEFIELD = "0";
            memoEdit1.Text += "CREATE TABLE [dbo].[" + textEdit1.Text + "](" + Environment.NewLine;
            memoEdit1.Text += "[" + textEdit2.Text + "] [INT] IDENTITY(1,1) NOT NULL," + Environment.NewLine;
            for (int i = 0; i < gridView1.RowCount; i++) {
                string NAME = "[" + gridView1.GetRowCellValue(i, "NAME").ToString() + "]";
                string TYPE = "[" + gridView1.GetRowCellValue(i, "TYPE").ToString().ToLower() + "]";
                string LENGTH = gridView1.GetRowCellValue(i, "LENGTH").ToString();
                string ISNULL = gridView1.GetRowCellValue(i, "ISNULL").ToString();
                ISNULL = ISNULL == "True" ? " NULL," : ",";
                if (IMAGEFIELD == "0") {
                    IMAGEFIELD = TYPE == "[Image]" ? "1" : "0";
                }
                switch (TYPE) {
                    case "[datetimeoffset]": TYPE = "[DATETIMEOFFSET](7)"; break;
                    case "[decimal]": TYPE = "[DECIMAL](18, 0)"; break;
                    case "[nchar]": TYPE = "[NCHAR](10)"; break;
                    case "[numeric]": TYPE = "[NUMERIC](18, 0)"; break;
                    case "[nvarchar]": TYPE = "[NVARCHAR](255)"; break;
                    case "[nvarchar(max)]": TYPE = "[NVARCHAR](MAX)"; break;
                    case "[time]": TYPE = "[TIME](7)"; break;
                    case "[varbinary]": TYPE = "[VARBINARY](50)"; break;
                    case "[varbinary(max)]": TYPE = "[VARBINARY](MAX)"; break;
                    case "[varchar]": TYPE = "[VARCHAR](255)"; break;
                    case "[varchar(max)]": TYPE = "[VARCHAR](MAX)"; break;
                    default: break;
                }
                memoEdit1.Text += NAME + " " + TYPE + ISNULL;
                memoEdit1.Text += Environment.NewLine;
            }
            if (CE_P1.Checked == true) {
                memoEdit1.Text += "[" + TE_P1NAME.Text + "] [" + TE_P1TYPE.Text + "] NULL, " + Environment.NewLine;
            }

            if (CE_P2.Checked == true) {
                memoEdit1.Text += "[" + TE_P2NAME.Text + "] [" + TE_P2TYPE.Text + "] NULL, " + Environment.NewLine;
            }
            memoEdit1.Text += "[created_day] [datetime] NULL, " + Environment.NewLine;
            memoEdit1.Text += "[created_by] [int] NULL, " + Environment.NewLine;
            memoEdit1.Text += "[modified_day] [datetime] NULL, " + Environment.NewLine;
            memoEdit1.Text += "[modified_by] [int] NULL, " + Environment.NewLine;
            memoEdit1.Text += "CONSTRAINT [PK_" + textEdit1.Text + "] PRIMARY KEY CLUSTERED " + Environment.NewLine;
            memoEdit1.Text += "(" + Environment.NewLine;
            memoEdit1.Text += "[" + textEdit2.Text + "] ASC" + Environment.NewLine;
            memoEdit1.Text += ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]" + Environment.NewLine;
            memoEdit1.Text += IMAGEFIELD == "1" ? ") ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]" + Environment.NewLine : ") ON [PRIMARY] " + Environment.NewLine;
        }

        private void repositoryItemButtonEditSIL_Click(object sender, EventArgs e) {
            gridView1.DeleteSelectedRows();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            if (e.Column.FieldName == "NAME") {
                string NAME = gridView1.GetFocusedRowCellValue(colNAME).ToString();
                string TYPE = "nvarchar";
                TYPE = NAME.StartsWith("Id_") ? "int" : TYPE;
                //TYPE = NAME.EndsWith("edDay") ? "datetime" : TYPE;
                gridView1.SetFocusedRowCellValue(colTYPE, TYPE);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            for (int i = 0; i < gridView1.RowCount;) {
                gridView1.DeleteRow(i);
            }
        }
   
 
        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e) {
         
        }
    }
}