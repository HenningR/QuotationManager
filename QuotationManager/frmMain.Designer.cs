namespace QuotationManager
{
    partial class frmMain
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
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.mnuQuotation = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuInventory = new System.Windows.Forms.ToolStripLabel();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuotation,
            this.toolStripSeparator1,
            this.mnuInventory});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1108, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // mnuQuotation
            // 
            this.mnuQuotation.Image = global::QuotationManager.Properties.Resources.Report_Design24R;
            this.mnuQuotation.Name = "mnuQuotation";
            this.mnuQuotation.Size = new System.Drawing.Size(77, 22);
            this.mnuQuotation.Text = "Quotation";
            this.mnuQuotation.Click += new System.EventHandler(this.mnuQuotation_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuInventory
            // 
            this.mnuInventory.Image = global::QuotationManager.Properties.Resources.Configuration_Tools24R;
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(73, 22);
            this.mnuInventory.Text = "Inventory";
            this.mnuInventory.Click += new System.EventHandler(this.mnuInventory_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 617);
            this.Controls.Add(this.mainToolStrip);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Quotation Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripLabel mnuQuotation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel mnuInventory;
    }
}

