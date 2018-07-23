using Microsoft.Reporting.WinForms;
using QuotationManager.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuotationManager.Reports.QuotationDS;

namespace QuotationManager
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quotationDS.QuotationDetail' table. You can move, or remove it, as needed.
            this.quotationDetailTableAdapter.FillBy(this.quotationDS.QuotationDetail,1);

            this.repViewer.RefreshReport();
        }

        private void repViewer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Warning[] warnings;
            string[] streamIds;
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            //string HIJRA_TODAY = "01/10/1435";
            //ReportParameter[] param = new ReportParameter[3];
            //param[0] = new ReportParameter("CUSTOMER_NUM", CUSTOMER_NUMTBX.Text);
            //param[1] = new ReportParameter("REF_CD", REF_CDTB.Text);
            //param[2] = new ReportParameter("HIJRA_TODAY", HIJRA_TODAY);

            byte[] bytes = repViewer.LocalReport.Render(
                "PDF",
                null,
                out mimeType,
                out encoding,
                out extension,
                out streamIds,
                out warnings);

            string tempPath = @"C:\Development\QuotationManager\QuotationManager\Reports";

            var saveAs = string.Format("{0}.pdf", Path.Combine(tempPath, "myfilename"));

            var idx = 0;
            while (File.Exists(saveAs))
            {
                idx++;
                saveAs = string.Format("{0}.{1}.pdf", Path.Combine(tempPath, "myfilename"), idx);
            }

            using (var stream = new FileStream(saveAs, FileMode.Create, FileAccess.Write))
            {
                stream.Write(bytes, 0, bytes.Length);
                stream.Close();
            }

     
        }
    }
}
