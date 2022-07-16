using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_HELPER_APP
{
    public partial class Frm_SDFFileViewer : XtraForm
    {
        string sdfFile = "";


        public Frm_SDFFileViewer()
        {
            InitializeComponent();
        }
        private void sb_OpenSdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();   
            using (fd)
            { 
                fd.Filter = "Sdf Files (*.sdf)|*.sdf|All Files (*.*)|*.*"; 
                fd.ShowDialog();
                sdfFile = lc_SDFPath.Text = fd.FileName;
                if (string.IsNullOrEmpty(sdfFile)) return;
                SqlCeConnection con = new SqlCeConnection("Data Source=" + sdfFile);
                try
                {
                    con.Open();
                    SqlCeCommand cmd = new SqlCeCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", con);
                    SqlCeDataReader reader = cmd.ExecuteReader();
                    lbc_SDFTableNames.Items.Clear();
                    while (reader.Read())
                    {
                        lbc_SDFTableNames.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                    con.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void lbc_SDFTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection("Data Source=" + sdfFile);
                con.Open();
                grc_SDFData.DataSource = null;
                grv_SDFData.PopulateColumns();
                SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM " + lbc_SDFTableNames.SelectedItem.ToString(), con);
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grc_SDFData.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void grv_SDFData_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            //add export to excel to menu
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Export to Excel", new EventHandler(ExportToExcel_Click)));
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Export to Pdf", new EventHandler(ExportToPdf_Click)));
            }
        }

        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            //export gridcontrol to excel
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xls)|*.xls";
            sfd.FileName = "SDFData.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                grc_SDFData.ExportToXls(sfd.FileName);
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
        private void ExportToPdf_Click(object sender, EventArgs e)
        {
            //export gridcontrol to excel
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xls)|*.xls";
            sfd.FileName = "SDFData.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                grc_SDFData.ExportToPdf(sfd.FileName);
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
    }
}
