namespace SQL_HELPER_APP
{
    partial class Departmanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departmanlar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridLOGICALREF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDEPTNAME_ENG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bMBORDROLEVENTMOTORDataSetBindingSource = new System.Windows.Forms.BindingSource();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMBORDROLEVENTMOTORDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "B_CAPIFIRM";
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 400);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridLOGICALREF,
            this.gridCODE,
            this.gridDESCRIPTION,
            this.gridDEPTNAME_ENG});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.ShowFooterItem = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            // 
            // gridLOGICALREF
            // 
            this.gridLOGICALREF.Caption = "LOGICALREF";
            this.gridLOGICALREF.FieldName = "LOGICALREF";
            this.gridLOGICALREF.Name = "gridLOGICALREF";
            this.gridLOGICALREF.OptionsColumn.ReadOnly = true;
            this.gridLOGICALREF.Visible = true;
            this.gridLOGICALREF.VisibleIndex = 0;
            // 
            // gridCODE
            // 
            this.gridCODE.Caption = "CODE";
            this.gridCODE.FieldName = "CODE";
            this.gridCODE.Name = "gridCODE";
            this.gridCODE.OptionsColumn.ReadOnly = true;
            this.gridCODE.Visible = true;
            this.gridCODE.VisibleIndex = 1;
            // 
            // gridDESCRIPTION
            // 
            this.gridDESCRIPTION.Caption = "DESCRIPTION";
            this.gridDESCRIPTION.FieldName = "DESCRIPTION";
            this.gridDESCRIPTION.Name = "gridDESCRIPTION";
            this.gridDESCRIPTION.OptionsColumn.ReadOnly = true;
            this.gridDESCRIPTION.Visible = true;
            this.gridDESCRIPTION.VisibleIndex = 2;
            // 
            // gridDEPTNAME_ENG
            // 
            this.gridDEPTNAME_ENG.Caption = "DEPTNAME_ENG";
            this.gridDEPTNAME_ENG.FieldName = "DEPTNAME_ENG";
            this.gridDEPTNAME_ENG.Name = "gridDEPTNAME_ENG";
            this.gridDEPTNAME_ENG.Visible = true;
            this.gridDEPTNAME_ENG.VisibleIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AutoSize = true;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(0, 438);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(784, 38);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "DEĞİŞİKLİKLERİ KAYDET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.AutoSize = true;
            this.simpleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(0, 400);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(784, 38);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "EXCELE KAYDET";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Departmanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 476);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Departmanlar";
            this.Text = "Departmanlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Grid_FormClosing);
            this.Load += new System.EventHandler(this.Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMBORDROLEVENTMOTORDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

        private System.Windows.Forms.BindingSource bMBORDROLEVENTMOTORDataSetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridLOGICALREF;
        private DevExpress.XtraGrid.Columns.GridColumn gridCODE;
        private DevExpress.XtraGrid.Columns.GridColumn gridDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn gridDEPTNAME_ENG;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}