namespace SQL_HELPER_APP
{
    partial class SP_EXECUTE2NORMALQUERY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SP_EXECUTE2NORMALQUERY));
            this.bMBORDROLEVENTMOTORDataSetBindingSource = new System.Windows.Forms.BindingSource();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bMBORDROLEVENTMOTORDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.AutoSize = true;
            this.simpleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(0, 497);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(741, 36);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "CONVERT";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.memoEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 243);
            this.panel1.TabIndex = 6;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(741, 243);
            this.memoEdit1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.memoEdit2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 228);
            this.panel2.TabIndex = 7;
            // 
            // memoEdit2
            // 
            this.memoEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit2.Location = new System.Drawing.Point(0, 0);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(741, 228);
            this.memoEdit2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "SP EXECUTE QUERY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CONVERTED:";
            // 
            // SP_EXECUTE2NORMALQUERY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SP_EXECUTE2NORMALQUERY";
            this.Text = "SP_EXECUTE>NORMAL QUERY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PERSONELLER_FormClosing);
            this.Load += new System.EventHandler(this.PERSONELLER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bMBORDROLEVENTMOTORDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bMBORDROLEVENTMOTORDataSetBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}