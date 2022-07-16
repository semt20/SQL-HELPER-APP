namespace SQL_HELPER_APP
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemReportDesigner = new DevExpress.XtraBars.BarButtonItem();
            this.Skins = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_SdfFileViewer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.bbi_SqlFormatter = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItemReportDesigner,
            this.Skins,
            this.barButtonItem1,
            this.barButtonItem3,
            this.barButtonItem4,
            this.bbi_SdfFileViewer,
            this.bbi_SqlFormatter});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.Skins);
            this.ribbonControl1.Size = new System.Drawing.Size(841, 150);
            // 
            // barButtonItemReportDesigner
            // 
            this.barButtonItemReportDesigner.Caption = "SP_EXECUTE>NORMAL QUERY";
            this.barButtonItemReportDesigner.Id = 1;
            this.barButtonItemReportDesigner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemReportDesigner.ImageOptions.Image")));
            this.barButtonItemReportDesigner.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemReportDesigner.ImageOptions.LargeImage")));
            this.barButtonItemReportDesigner.Name = "barButtonItemReportDesigner";
            this.barButtonItemReportDesigner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemReportDesigner_ItemClick);
            // 
            // Skins
            // 
            this.Skins.Caption = "Skins";
            this.Skins.Id = 2;
            this.Skins.Name = "Skins";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "TEMAYI KAYDET";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "SQL TABLE SCRIPT GENERATOR";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "CLASS TO CONVERTER";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bbi_SdfFileViewer
            // 
            this.bbi_SdfFileViewer.Caption = "SDF File Viewer(WinCE)";
            this.bbi_SdfFileViewer.Id = 8;
            this.bbi_SdfFileViewer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbi_SdfFileViewer.ImageOptions.SvgImage")));
            this.bbi_SdfFileViewer.Name = "bbi_SdfFileViewer";
            this.bbi_SdfFileViewer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_SdfFileViewer_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "SQL HELPER";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbi_SqlFormatter);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemReportDesigner);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbi_SdfFileViewer);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "SQL HELPER";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // bbi_SqlFormatter
            // 
            this.bbi_SqlFormatter.Caption = "SQL FORMATTER";
            this.bbi_SqlFormatter.Id = 10;
            this.bbi_SqlFormatter.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbi_SqlFormatter.ImageOptions.SvgImage")));
            this.bbi_SqlFormatter.Name = "bbi_SqlFormatter";
            this.bbi_SqlFormatter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_SqlFormatter_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 516);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL HELPER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReportDesigner;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem Skins;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem bbi_SdfFileViewer;
        private DevExpress.XtraBars.BarButtonItem bbi_SqlFormatter;
    }
}