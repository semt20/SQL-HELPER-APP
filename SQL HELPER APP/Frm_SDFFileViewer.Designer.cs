namespace SQL_HELPER_APP
{
    partial class Frm_SDFFileViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SDFFileViewer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lc_SDFPath = new DevExpress.XtraEditors.LabelControl();
            this.sb_OpenSdf = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lbc_SDFTableNames = new DevExpress.XtraEditors.ListBoxControl();
            this.grc_SDFData = new DevExpress.XtraGrid.GridControl();
            this.grv_SDFData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbc_SDFTableNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_SDFData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_SDFData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lc_SDFPath);
            this.panel1.Controls.Add(this.sb_OpenSdf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 53);
            this.panel1.TabIndex = 2;
            // 
            // lc_SDFPath
            // 
            this.lc_SDFPath.Location = new System.Drawing.Point(116, 23);
            this.lc_SDFPath.Name = "lc_SDFPath";
            this.lc_SDFPath.Size = new System.Drawing.Size(0, 13);
            this.lc_SDFPath.TabIndex = 1;
            // 
            // sb_OpenSdf
            // 
            this.sb_OpenSdf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sb_OpenSdf.ImageOptions.SvgImage")));
            this.sb_OpenSdf.Location = new System.Drawing.Point(12, 12);
            this.sb_OpenSdf.Name = "sb_OpenSdf";
            this.sb_OpenSdf.Size = new System.Drawing.Size(98, 35);
            this.sb_OpenSdf.TabIndex = 0;
            this.sb_OpenSdf.Text = "Open Sdf";
            this.sb_OpenSdf.Click += new System.EventHandler(this.sb_OpenSdf_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 671);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 29);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainerControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1019, 618);
            this.panel3.TabIndex = 4;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.lbc_SDFTableNames);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.grc_SDFData);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1019, 618);
            this.splitContainerControl1.SplitterPosition = 253;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // lbc_SDFTableNames
            // 
            this.lbc_SDFTableNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbc_SDFTableNames.Location = new System.Drawing.Point(0, 0);
            this.lbc_SDFTableNames.Name = "lbc_SDFTableNames";
            this.lbc_SDFTableNames.Size = new System.Drawing.Size(253, 618);
            this.lbc_SDFTableNames.TabIndex = 0;
            this.lbc_SDFTableNames.SelectedIndexChanged += new System.EventHandler(this.lbc_SDFTableNames_SelectedIndexChanged);
            // 
            // grc_SDFData
            // 
            this.grc_SDFData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_SDFData.Location = new System.Drawing.Point(0, 0);
            this.grc_SDFData.MainView = this.grv_SDFData;
            this.grc_SDFData.Name = "grc_SDFData";
            this.grc_SDFData.Size = new System.Drawing.Size(756, 618);
            this.grc_SDFData.TabIndex = 0;
            this.grc_SDFData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_SDFData});
            // 
            // grv_SDFData
            // 
            this.grv_SDFData.GridControl = this.grc_SDFData;
            this.grv_SDFData.Name = "grv_SDFData";
            this.grv_SDFData.OptionsView.ShowFooter = true;
            this.grv_SDFData.OptionsView.ShowGroupPanel = false;
            this.grv_SDFData.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.grv_SDFData_PopupMenuShowing);
            // 
            // Frm_SDFFileViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_SDFFileViewer";
            this.Text = "SDF Viewer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbc_SDFTableNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_SDFData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_SDFData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl grc_SDFData;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_SDFData;
        private DevExpress.XtraEditors.SimpleButton sb_OpenSdf;
        private DevExpress.XtraEditors.LabelControl lc_SDFPath;
        private DevExpress.XtraEditors.ListBoxControl lbc_SDFTableNames;
    }
}

