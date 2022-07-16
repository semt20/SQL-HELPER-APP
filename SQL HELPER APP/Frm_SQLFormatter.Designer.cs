namespace SQL_HELPER_APP
{
    partial class Frm_SQLFormatter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SQLFormatter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ce_htmlColoring = new DevExpress.XtraEditors.CheckEdit();
            this.ce_uppercaseKeywords = new DevExpress.XtraEditors.CheckEdit();
            this.ce_breakJoinOnSections = new DevExpress.XtraEditors.CheckEdit();
            this.ce_expandBetweenConditions = new DevExpress.XtraEditors.CheckEdit();
            this.ce_expandCaseStatements = new DevExpress.XtraEditors.CheckEdit();
            this.ce_expandBooleanExpressions = new DevExpress.XtraEditors.CheckEdit();
            this.ce_spaceAfterExpandedComma = new DevExpress.XtraEditors.CheckEdit();
            this.ce_trailingCommas = new DevExpress.XtraEditors.CheckEdit();
            this.ce_expandCommaLists = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.se_spacesPerTab = new DevExpress.XtraEditors.SpinEdit();
            this.lc_SDFPath = new DevExpress.XtraEditors.LabelControl();
            this.sb_FormatSql = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.me_SQLSource = new DevExpress.XtraEditors.MemoEdit();
            this.rec_SQLDestination = new DevExpress.XtraRichEdit.RichEditControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ce_htmlColoring.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_uppercaseKeywords.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_breakJoinOnSections.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_expandBetweenConditions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_expandCaseStatements.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_expandBooleanExpressions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_spaceAfterExpandedComma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_trailingCommas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_expandCommaLists.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_spacesPerTab.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.me_SQLSource.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ce_htmlColoring);
            this.panel1.Controls.Add(this.ce_uppercaseKeywords);
            this.panel1.Controls.Add(this.ce_breakJoinOnSections);
            this.panel1.Controls.Add(this.ce_expandBetweenConditions);
            this.panel1.Controls.Add(this.ce_expandCaseStatements);
            this.panel1.Controls.Add(this.ce_expandBooleanExpressions);
            this.panel1.Controls.Add(this.ce_spaceAfterExpandedComma);
            this.panel1.Controls.Add(this.ce_trailingCommas);
            this.panel1.Controls.Add(this.ce_expandCommaLists);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.se_spacesPerTab);
            this.panel1.Controls.Add(this.lc_SDFPath);
            this.panel1.Controls.Add(this.sb_FormatSql);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 121);
            this.panel1.TabIndex = 2;
            // 
            // ce_htmlColoring
            // 
            this.ce_htmlColoring.EditValue = true;
            this.ce_htmlColoring.Location = new System.Drawing.Point(225, 95);
            this.ce_htmlColoring.Name = "ce_htmlColoring";
            this.ce_htmlColoring.Properties.Caption = "html Coloring";
            this.ce_htmlColoring.Size = new System.Drawing.Size(161, 20);
            this.ce_htmlColoring.TabIndex = 12;
            // 
            // ce_uppercaseKeywords
            // 
            this.ce_uppercaseKeywords.Location = new System.Drawing.Point(225, 74);
            this.ce_uppercaseKeywords.Name = "ce_uppercaseKeywords";
            this.ce_uppercaseKeywords.Properties.Caption = "uppercase Keywords";
            this.ce_uppercaseKeywords.Size = new System.Drawing.Size(161, 20);
            this.ce_uppercaseKeywords.TabIndex = 11;
            // 
            // ce_breakJoinOnSections
            // 
            this.ce_breakJoinOnSections.Location = new System.Drawing.Point(225, 55);
            this.ce_breakJoinOnSections.Name = "ce_breakJoinOnSections";
            this.ce_breakJoinOnSections.Properties.Caption = "break Join On Sections";
            this.ce_breakJoinOnSections.Size = new System.Drawing.Size(161, 20);
            this.ce_breakJoinOnSections.TabIndex = 10;
            // 
            // ce_expandBetweenConditions
            // 
            this.ce_expandBetweenConditions.Location = new System.Drawing.Point(225, 34);
            this.ce_expandBetweenConditions.Name = "ce_expandBetweenConditions";
            this.ce_expandBetweenConditions.Properties.Caption = "expand Between Conditions";
            this.ce_expandBetweenConditions.Size = new System.Drawing.Size(161, 20);
            this.ce_expandBetweenConditions.TabIndex = 9;
            // 
            // ce_expandCaseStatements
            // 
            this.ce_expandCaseStatements.Location = new System.Drawing.Point(225, 12);
            this.ce_expandCaseStatements.Name = "ce_expandCaseStatements";
            this.ce_expandCaseStatements.Properties.Caption = "expand Case Statements";
            this.ce_expandCaseStatements.Size = new System.Drawing.Size(161, 20);
            this.ce_expandCaseStatements.TabIndex = 8;
            // 
            // ce_expandBooleanExpressions
            // 
            this.ce_expandBooleanExpressions.Location = new System.Drawing.Point(12, 95);
            this.ce_expandBooleanExpressions.Name = "ce_expandBooleanExpressions";
            this.ce_expandBooleanExpressions.Properties.Caption = "expand Boolean Expressions";
            this.ce_expandBooleanExpressions.Size = new System.Drawing.Size(179, 20);
            this.ce_expandBooleanExpressions.TabIndex = 7;
            // 
            // ce_spaceAfterExpandedComma
            // 
            this.ce_spaceAfterExpandedComma.Location = new System.Drawing.Point(12, 74);
            this.ce_spaceAfterExpandedComma.Name = "ce_spaceAfterExpandedComma";
            this.ce_spaceAfterExpandedComma.Properties.Caption = "space After Expanded Comma";
            this.ce_spaceAfterExpandedComma.Size = new System.Drawing.Size(179, 20);
            this.ce_spaceAfterExpandedComma.TabIndex = 6;
            // 
            // ce_trailingCommas
            // 
            this.ce_trailingCommas.Location = new System.Drawing.Point(12, 55);
            this.ce_trailingCommas.Name = "ce_trailingCommas";
            this.ce_trailingCommas.Properties.Caption = "trailing Commas";
            this.ce_trailingCommas.Size = new System.Drawing.Size(137, 20);
            this.ce_trailingCommas.TabIndex = 5;
            // 
            // ce_expandCommaLists
            // 
            this.ce_expandCommaLists.Location = new System.Drawing.Point(12, 34);
            this.ce_expandCommaLists.Name = "ce_expandCommaLists";
            this.ce_expandCommaLists.Properties.Caption = "expand Comma Lists";
            this.ce_expandCommaLists.Size = new System.Drawing.Size(137, 20);
            this.ce_expandCommaLists.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Spaces Per Tab:";
            // 
            // se_spacesPerTab
            // 
            this.se_spacesPerTab.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_spacesPerTab.Location = new System.Drawing.Point(96, 12);
            this.se_spacesPerTab.Name = "se_spacesPerTab";
            this.se_spacesPerTab.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_spacesPerTab.Size = new System.Drawing.Size(53, 20);
            this.se_spacesPerTab.TabIndex = 2;
            // 
            // lc_SDFPath
            // 
            this.lc_SDFPath.Location = new System.Drawing.Point(115, 15);
            this.lc_SDFPath.Name = "lc_SDFPath";
            this.lc_SDFPath.Size = new System.Drawing.Size(0, 13);
            this.lc_SDFPath.TabIndex = 1;
            // 
            // sb_FormatSql
            // 
            this.sb_FormatSql.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sb_FormatSql.ImageOptions.SvgImage")));
            this.sb_FormatSql.Location = new System.Drawing.Point(526, 66);
            this.sb_FormatSql.Name = "sb_FormatSql";
            this.sb_FormatSql.Size = new System.Drawing.Size(98, 35);
            this.sb_FormatSql.TabIndex = 0;
            this.sb_FormatSql.Text = "Format Sql";
            this.sb_FormatSql.Click += new System.EventHandler(this.sb_FormatSql_Click);
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
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1019, 550);
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
            this.splitContainerControl1.Panel1.Controls.Add(this.me_SQLSource);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.rec_SQLDestination);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1019, 550);
            this.splitContainerControl1.SplitterPosition = 470;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // me_SQLSource
            // 
            this.me_SQLSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.me_SQLSource.EditValue = resources.GetString("me_SQLSource.EditValue");
            this.me_SQLSource.Location = new System.Drawing.Point(0, 0);
            this.me_SQLSource.Name = "me_SQLSource";
            this.me_SQLSource.Properties.WordWrap = false;
            this.me_SQLSource.Size = new System.Drawing.Size(470, 550);
            this.me_SQLSource.TabIndex = 0;
            // 
            // rec_SQLDestination
            // 
            this.rec_SQLDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rec_SQLDestination.Location = new System.Drawing.Point(0, 0);
            this.rec_SQLDestination.Name = "rec_SQLDestination";
            this.rec_SQLDestination.Options.DocumentCapabilities.ParagraphBorders = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.rec_SQLDestination.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.rec_SQLDestination.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.rec_SQLDestination.Size = new System.Drawing.Size(539, 550);
            this.rec_SQLDestination.TabIndex = 0;
            this.rec_SQLDestination.Text = "SQL Formatted";
            this.rec_SQLDestination.Views.SimpleView.WordWrap = false;
            // 
            // Frm_SQLFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_SQLFormatter";
            this.Text = "SQL Formatter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ce_htmlColoring.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_uppercaseKeywords.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_breakJoinOnSections.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_expandBetweenConditions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_expandCaseStatements.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_expandBooleanExpressions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_spaceAfterExpandedComma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_trailingCommas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_expandCommaLists.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_spacesPerTab.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.me_SQLSource.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton sb_FormatSql;
        private DevExpress.XtraEditors.LabelControl lc_SDFPath;
        private DevExpress.XtraEditors.MemoEdit me_SQLSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit se_spacesPerTab;
        private DevExpress.XtraEditors.CheckEdit ce_expandCommaLists;
        private DevExpress.XtraEditors.CheckEdit ce_trailingCommas;
        private DevExpress.XtraEditors.CheckEdit ce_spaceAfterExpandedComma;
        private DevExpress.XtraEditors.CheckEdit ce_expandBooleanExpressions;
        private DevExpress.XtraEditors.CheckEdit ce_expandCaseStatements;
        private DevExpress.XtraEditors.CheckEdit ce_expandBetweenConditions;
        private DevExpress.XtraEditors.CheckEdit ce_breakJoinOnSections;
        private DevExpress.XtraEditors.CheckEdit ce_uppercaseKeywords;
        private DevExpress.XtraEditors.CheckEdit ce_htmlColoring;
        private DevExpress.XtraRichEdit.RichEditControl rec_SQLDestination;
    }
}

