namespace QuotationManager
{
    partial class frmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.repViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quotationDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotationDS = new QuotationManager.Reports.QuotationDS();
            this.quotationDetailTableAdapter = new QuotationManager.Reports.QuotationDSTableAdapters.QuotationDetailTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quotationDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationDS)).BeginInit();
            this.SuspendLayout();
            // 
            // repViewer
            // 
            this.repViewer.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource1.Name = "QuotationDS";
            reportDataSource1.Value = this.quotationDetailBindingSource;
            this.repViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.repViewer.LocalReport.ReportEmbeddedResource = "QuotationManager.Reports.DetailQuotationRep.rdlc";
            this.repViewer.Location = new System.Drawing.Point(0, 0);
            this.repViewer.Name = "repViewer";
            this.repViewer.Size = new System.Drawing.Size(284, 229);
            this.repViewer.TabIndex = 0;
            this.repViewer.Load += new System.EventHandler(this.repViewer_Load);
            // 
            // quotationDetailBindingSource
            // 
            this.quotationDetailBindingSource.DataMember = "QuotationDetail";
            this.quotationDetailBindingSource.DataSource = this.quotationDS;
            // 
            // quotationDS
            // 
            this.quotationDS.DataSetName = "QuotationDS";
            this.quotationDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quotationDetailTableAdapter
            // 
            this.quotationDetailTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.repViewer);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quotationDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repViewer;
        private Reports.QuotationDS quotationDS;
        private System.Windows.Forms.BindingSource quotationDetailBindingSource;
        private Reports.QuotationDSTableAdapters.QuotationDetailTableAdapter quotationDetailTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}