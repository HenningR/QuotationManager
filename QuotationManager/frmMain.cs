using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuotationManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuQuotation_Click(object sender, EventArgs e)
        {
            frmQuotation frm = new frmQuotation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuInventory_Click(object sender, EventArgs e)
        {
            frmInventory frm = new frmInventory();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
