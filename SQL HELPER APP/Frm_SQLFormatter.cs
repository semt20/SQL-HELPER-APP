using DevExpress.XtraEditors;
using PoorMansTSqlFormatterLib.Formatters;
using PoorMansTSqlFormatterLib.Interfaces;
using PoorMansTSqlFormatterLib.Parsers;
using PoorMansTSqlFormatterLib.Tokenizers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_HELPER_APP
{
    public partial class Frm_SQLFormatter : XtraForm
    {
        public Frm_SQLFormatter()
        {
            InitializeComponent();
        }

        private void sb_FormatSql_Click(object sender, EventArgs e)
        {
            ISqlTokenizer tokenizer = new TSqlStandardTokenizer();
            ISqlTokenParser parser = new TSqlStandardParser();
            ISqlTreeFormatter formatter = new TSqlStandardFormatter()
            {
                SpacesPerTab = (int)se_spacesPerTab.Value,
                ExpandCommaLists = ce_expandCommaLists.Checked,
                TrailingCommas = ce_trailingCommas.Checked,
                SpaceAfterExpandedComma = ce_spaceAfterExpandedComma.Checked,
                ExpandBooleanExpressions = ce_expandCommaLists.Checked,
                ExpandCaseStatements = ce_expandCaseStatements.Checked,
                ExpandBetweenConditions = ce_expandBetweenConditions.Checked,
                BreakJoinOnSections = ce_breakJoinOnSections.Checked,
                UppercaseKeywords = ce_uppercaseKeywords.Checked,
                HTMLColoring = ce_htmlColoring.Checked
            };
            PoorMansTSqlFormatterLib.SqlFormattingManager fullFormatter = new PoorMansTSqlFormatterLib.SqlFormattingManager(new PoorMansTSqlFormatterLib.Formatters.HtmlPageWrapper(formatter));
            rec_SQLDestination.HtmlText = fullFormatter.Format(me_SQLSource.Text);
        }
    }
}
