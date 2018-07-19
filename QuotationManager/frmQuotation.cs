using QuotationManager.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuotationManager.Factory.CommonModule;

namespace QuotationManager
{
    public partial class frmQuotation : Form
    {

        System.Windows.Forms.BindingSource bindingSource = new System.Windows.Forms.BindingSource();
        public frmQuotation()
        {
            InitializeComponent();

            LoadinventoryGroups();
            LoadExistingQuotes();
            ClearQuoteDetail();



        }

        private void LoadExistingQuotes()
        {
            cmbExistingQuotation.DataSource = null;
            cmbExistingQuotation.Items.Clear();
            List<Quotation> quoteList = new List<Quotation>();
            Quotation quote = new Quotation();
            quoteList = quote.GetQuoteList();
            cmbExistingQuotation.DisplayMember = "Description";
            cmbExistingQuotation.ValueMember = "QuotationID";
            cmbExistingQuotation.DataSource = quoteList;
        }

        private void ClearQuoteDetail()
        {
            dgView.DataSource = null;
            dgView.Rows.Clear();
            dgView.DataSource = null;
        }


        List<QuotationDetail> quoteList = new List<QuotationDetail>();
        private void LoadExistingQuoteDetail(int QuoteItemID)
        {
            quoteList = QuotationDetail.GetQuoteList(QuoteItemID);
            bindingSource = new System.Windows.Forms.BindingSource { DataSource = quoteList };
            dgView.DataSource = bindingSource;
        }


        private void frmQuotation_Load(object sender, EventArgs e)
        {


            LoadExistingQuoteDetail(-1);




            // DataGridViewRow row = (DataGridViewRow)dgView.Rows[0].Clone();

            // dgView.DataSource = new List<QuotationDetail>();

            // row.Cells[0].Value = "1";
            // row.Cells[1].Value = "Foyer/Entrance Hall";
            // row.Cells[8].Value = "1,433.60";
            //row.Cells[9].Value = "143.36";
            // row.Cells[10].Value = "1,576.96";

            // dgView.Rows.Add(row);
            //row = (DataGridViewRow)dgView.Rows[0].Clone();
            //row.Cells[0].Value = "2";
            //row.Cells[1].Value = "FLOOR DECORATIONS";
            //row.Cells[8].Value = "281.60";
            //row.Cells[9].Value = "28.16";
            //row.Cells[10].Value = "309.76";



            //dgView.Rows.Add(row);

            //row = (DataGridViewRow)dgView.Rows[0].Clone();
            //row.Cells[0].Value = "3";
            //row.Cells[1].Value = "LOOSE RUGS";
            //row.Cells[8].Value = "64.00";
            //row.Cells[9].Value = "6.40";
            //row.Cells[10].Value = "70.40";

            //dgView.Rows.Add(row);

            //row = (DataGridViewRow)dgView.Rows[0].Clone();
            //row.Cells[0].Value = "";
            //row.Cells[1].Value = "Rug(s)";
            //row.Cells[2].Value = "ea";
            //row.Cells[3].Value = 1;
            //row.Cells[4].Value = 10;
            //row.Cells[5].Value = 10;
            //row.Cells[6].Value = "28";
            //row.Cells[7].Value = "2.80";
            //row.Cells[8].Value = "12.80";
            //row.Cells[9].Value = "1.28";
            //row.Cells[10].Value = "14.08";

            //dgView.Rows.Add(row);
            //row = (DataGridViewRow)dgView.Rows[0].Clone();
            //row.Cells[0].Value = "";
            //row.Cells[1].Value = "Underveldt";
            //row.Cells[2].Value = "ea";
            //row.Cells[3].Value = 1;
            //row.Cells[4].Value = 10;
            //row.Cells[5].Value = 10;
            //row.Cells[6].Value = "28";
            //row.Cells[7].Value = "2.80";
            //row.Cells[8].Value = "12.80";
            //row.Cells[9].Value = "1.28";
            //row.Cells[10].Value = "14.08";

            //dgView.Rows.Add(row);
            //row = (DataGridViewRow)dgView.Rows[0].Clone();
            //row.Cells[0].Value = "";
            //row.Cells[1].Value = "Wrapping";
            //row.Cells[2].Value = "ea";
            //row.Cells[3].Value = 1;
            //row.Cells[4].Value = 10;
            //row.Cells[5].Value = 10;
            //row.Cells[6].Value = "28";
            //row.Cells[7].Value = "2.80";
            //row.Cells[8].Value = "12.80";
            //row.Cells[9].Value = "1.28";
            //row.Cells[10].Value = "14.08";

            //dgView.Rows.Add(row);
        }

        private void LoadinventoryGroups()
        {
            cmbGroups.DataSource = null;
            cmbGroups.Items.Clear();
            List<Inventory> invList = new List<Inventory>();
            Inventory inv = new Inventory();
            invList = inv.GetInventoryList();
            cmbGroups.DisplayMember = "Description";
            cmbGroups.ValueMember = "InventoryID";

            //foreach (Inventory item in invList)
            //{
            //    cmbGroups.Items.Add(new { Text = item.Description, Value = item.InventoryID });
            //}
            cmbGroups.DataSource = invList;
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewQuotation_Click(object sender, EventArgs e)
        {

            cmbExistingQuotation.Visible = false;
            txtNewQuotation.Visible = true;

            btnOpenQuotation.Enabled = false;
            btnCancelQuote.Enabled = true;
            btnSaveQuote.Enabled = true;

        }



        private void btnCancelQuote_Click(object sender, EventArgs e)
        {
            cmbExistingQuotation.Visible = true;
            txtNewQuotation.Visible = false;

            btnOpenQuotation.Enabled = true;
            btnCancelQuote.Enabled = false;
            btnSaveQuote.Enabled = false;
        }

        private void btnSaveQuote_Click(object sender, EventArgs e)
        {
            if (txtNewQuotation.Text == "")
            {
                showLableInfo("No new quotation exist", InfoType.Error);
            }

            Quotation item = new Quotation();
            item.Description = txtNewQuotation.Text;
            if (item.Save(true) > 0)
            {
                LoadExistingQuotes();
                ClearQuoteDetail();
            }

            cmbExistingQuotation.Visible = true;
            txtNewQuotation.Visible = false;

            btnOpenQuotation.Enabled = true;
            btnCancelQuote.Enabled = false;
            btnSaveQuote.Enabled = false;
        }


        BackgroundWorker _worker = new BackgroundWorker();

        private void showLableInfo(string text, InfoType infoType)
        {

            lblInfo.Text = text.ToUpper();

            if (infoType == InfoType.Warning)
            {
                lblInfo.ForeColor = Color.Yellow;
            }
            if (infoType == InfoType.Error)
            {
                lblInfo.ForeColor = Color.Red;
            }
            if (infoType == InfoType.Success)
            {
                lblInfo.ForeColor = Color.Green;
            }
            lblInfo.Visible = true;
            lblInfo.Refresh();

            _worker.WorkerReportsProgress = true;
            _worker.DoWork += new System.ComponentModel.DoWorkEventHandler(showLableInfo);
            _worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(showLableInfoCompleted);
            _worker.RunWorkerAsync();
        }

        private void showLableInfo(object sender, DoWorkEventArgs e)
        {
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }

        private void showLableInfoCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void cmbExistingQuotation_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btnOpenQuotation_Click(object sender, EventArgs e)
        {





            if (cmbExistingQuotation.SelectedIndex >= 0 && cmbExistingQuotation.SelectedItem != null)
            {
                Quotation item = new Quotation();
                item = (Quotation)cmbExistingQuotation.SelectedItem;

                LoadExistingQuoteDetail(item.QuotationID);

            }
        }

        private void btnAddCustomHeader_Click(object sender, EventArgs e)
        {

            addHeader(txtCustomHeader.Text);
            bindingSource = new System.Windows.Forms.BindingSource { DataSource = quoteList };
            dgView.DataSource = bindingSource;

        }



        private void dgView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (quoteList.Count > 0 && (e.RowIndex <= quoteList.Count - 1))
            {
                QuotationDetail detail = quoteList[e.RowIndex];
                if (detail.IsItem == false)
                {
                    dgView.Rows[e.RowIndex].ReadOnly = true;
                    foreach (DataGridViewCell cell in dgView.Rows[e.RowIndex].Cells)
                    {
                        cell.Style.BackColor = Color.LightGray;
                    }
                }
                else if (detail.IsItem == true)
                {
                    dgView.Rows[e.RowIndex].Cells["Level"].ReadOnly = true;
                    dgView.Rows[e.RowIndex].Cells["Level"].Style.BackColor = Color.LightYellow;

                    dgView.Rows[e.RowIndex].Cells["Description"].ReadOnly = true;
                    dgView.Rows[e.RowIndex].Cells["Description"].Style.BackColor = Color.LightYellow;

                    dgView.Rows[e.RowIndex].Cells["Unit"].ReadOnly = true;
                    dgView.Rows[e.RowIndex].Cells["Unit"].Style.BackColor = Color.LightYellow;

                    dgView.Rows[e.RowIndex].Cells["Total"].ReadOnly = true;
                    dgView.Rows[e.RowIndex].Cells["Total"].Style.BackColor = Color.LightYellow;

                    dgView.Rows[e.RowIndex].Cells["MarkupValue"].ReadOnly = true;
                    dgView.Rows[e.RowIndex].Cells["MarkupValue"].Style.BackColor = Color.LightYellow;

                    dgView.Rows[e.RowIndex].Cells["GROSSPRICE"].ReadOnly = true;
                    dgView.Rows[e.RowIndex].Cells["GROSSPRICE"].Style.BackColor = Color.LightYellow;

                    dgView.Rows[e.RowIndex].Cells["ArteValue"].ReadOnly = true;
                    dgView.Rows[e.RowIndex].Cells["ArteValue"].Style.BackColor = Color.LightYellow;

                    dgView.Rows[e.RowIndex].Cells["GrandTOTAL"].ReadOnly = true;
                    dgView.Rows[e.RowIndex].Cells["GrandTOTAL"].Style.BackColor = Color.LightYellow;
                }




            }


        }

      
        private void dgView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (quoteList.Count > 0 && (e.RowIndex <= quoteList.Count - 1))
            {
                QuotationDetail detail = quoteList[e.RowIndex];

                if (detail.IsItem == true)
                {
                    dgView.Rows[e.RowIndex].Cells["Total"].Value = (int)dgView.Rows[e.RowIndex].Cells["Quantity"].Value * (decimal)dgView.Rows[e.RowIndex].Cells["Price"].Value;
                    dgView.Rows[e.RowIndex].Cells["MarkupValue"].Value = ((decimal)dgView.Rows[e.RowIndex].Cells["MARKUP"].Value / 100) * (decimal)dgView.Rows[e.RowIndex].Cells["Total"].Value;
                    dgView.Rows[e.RowIndex].Cells["GROSSPRICE"].Value = (decimal)dgView.Rows[e.RowIndex].Cells["MarkupValue"].Value + (decimal)dgView.Rows[e.RowIndex].Cells["Total"].Value;

                    dgView.Rows[e.RowIndex].Cells["ArteValue"].Value = ((decimal)dgView.Rows[e.RowIndex].Cells["ARTEPerc"].Value / 100) * (decimal)dgView.Rows[e.RowIndex].Cells["GROSSPRICE"].Value;
                    dgView.Rows[e.RowIndex].Cells["GrandTOTAL"].Value = (decimal)dgView.Rows[e.RowIndex].Cells["GROSSPRICE"].Value + (decimal)dgView.Rows[e.RowIndex].Cells["ArteValue"].Value;

                   
             

                }
            }


        }









    private void dgView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (quoteList.Count > 0 && (e.RowIndex <= quoteList.Count - 1))
            {
                QuotationDetail detail = quoteList[e.RowIndex];

                if (detail.IsItem == true)
                {
                    object colValue = dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;

                    if (dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "QUANTITY")
                    {
                        int origVal = (int)dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        int objVal = (int)dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (Int32.TryParse(colValue.ToString(), out objVal) == false)
                        {
                            dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = origVal;
                        }

                    }
                    else if (dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name.ToUpper() == "PRICE" || dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name.ToUpper() == "MARKUP" || dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name.ToUpper() == "ARTEPERC")
                    {
                        decimal origVal = (decimal)dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        decimal objVal = 0;
                        if (Decimal.TryParse(colValue.ToString(), out objVal) == false)
                        {
                            dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = origVal;
                        }

                    }
                }
            }
        }


        List<InventoryItem> currentInventoryItems = new List<InventoryItem>();
        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInventoryItems = new List<InventoryItem>();
            if (cmbGroups.SelectedIndex >= 0 && cmbGroups.SelectedItem != null)
            {


                Inventory grpItem = (Inventory)cmbGroups.SelectedItem;

                currentInventoryItems = InventoryItem.GetInventoryItems(grpItem.InventoryID);

                cmbSection.DataSource = null;
                cmbSection.Items.Clear();

                cmbSection.DisplayMember = "Description";
                cmbSection.ValueMember = "InventoryItemID";
                cmbSection.DataSource = currentInventoryItems;
            }
        }



        private void addHeader(string headerName)
        {
            QuotationDetail detail = new QuotationDetail();
            detail.QuotationDetailID = 2;
            detail.QuotationID = 3;
            detail.ArtePercentage = 0;
            detail.ArteValue = 0;
            detail.Description = headerName;
            detail.GrossPrice = 0;
            detail.IsItem = false;
            int levelIndex = 1;
            if (quoteList.Count >= 1 && quoteList[quoteList.Count - 1].IsItem == false)
            {
                levelIndex = quoteList[quoteList.Count - 1].LevelIndex + 1;
            }

            detail.LevelIndex = levelIndex;
            detail.MarkupPercentage = 0;
            detail.MarkupValue = 0;
            detail.Price = 0;
            detail.Quantity = 0;
            detail.QuoteOrder = dgView.Rows.Count;
            detail.Total = 0;
            detail.TotalValue = 0;
            detail.Unit = "";
            quoteList.Add(detail);
        }

        private void addItemDetail(InventoryItem invItem)
        {
            QuotationDetail detail = new QuotationDetail();
            detail.QuotationDetailID = 2;
            detail.QuotationID = 3;
            detail.ArtePercentage = invItem.ArtePercentage;
            detail.ArteValue = 0;
            detail.Description = invItem.Description;
            detail.GrossPrice = 0;
            detail.IsItem = invItem.IsItem;
            int levelIndex = 0;


            detail.LevelIndex = levelIndex;
            detail.MarkupPercentage = invItem.MarkupPercentage;
            detail.MarkupValue = 0;
            detail.Price = invItem.Price;
            detail.Quantity = 0;
            detail.QuoteOrder = dgView.Rows.Count;
            detail.Total = 0;
            detail.TotalValue = 0;
            detail.Unit = invItem.Unit;
            quoteList.Add(detail);
        }

        private void btnAddQuotationSection_Click(object sender, EventArgs e)
        {
            if (cmbSection.SelectedIndex >= 0 && cmbSection.SelectedItem != null)
            {
                bool addAddisional = false;
                InventoryItem grpItem = (InventoryItem)cmbSection.SelectedItem;
                foreach (InventoryItem item in currentInventoryItems)
                {
                    if (item.InventoryItemID == grpItem.InventoryItemID || addAddisional)
                    {

                        if (item.IsItem == false)
                        {
                            addHeader(item.Description);
                        }
                        else
                        {
                            addItemDetail(item);
                        }


                        addAddisional = true;
                    }
                }

                bindingSource = new System.Windows.Forms.BindingSource { DataSource = quoteList };
                dgView.DataSource = bindingSource;


            }
        }






        private void RebalanceGrid()
        {
            int quotationHeaderStart = -1;
            int qoutationHeaderEnd = -1;
            bool firstHeader = false;
            bool firstItem = true;
            int quoteCC = 0;
            Dictionary<string, decimal> sumTotals = new Dictionary<string, decimal>();

            foreach (QuotationDetail item in quoteList)
            {
                if (item.IsItem == false)
                {
                    if (firstItem == false)
                    {
                        foreach (KeyValuePair<string, decimal> valuePair in sumTotals)
                        {

                            for (int valStart = quotationHeaderStart; valStart <= qoutationHeaderEnd; valStart++)
                            {
                                if (valuePair.Key == "Total")
                                {
                                    quoteList[valStart].Total = valuePair.Value;
                                }

                                if (valuePair.Key == "TotalValue")
                                {
                                    quoteList[valStart].TotalValue = valuePair.Value;
                                }

                                if (valuePair.Key == "GrossPrice")
                                {
                                    quoteList[valStart].GrossPrice = valuePair.Value;
                                }
                            }



                        }
                        quotationHeaderStart = -1;
                        qoutationHeaderEnd = -1;
                    }


                    if (firstHeader == false)
                    {
                        quotationHeaderStart = quoteCC;
                    }
                    qoutationHeaderEnd = quoteCC;



                    firstHeader = true;
                    firstItem = true;
                }
                else if (item.IsItem)
                {
                    if (firstItem)
                    {
                        sumTotals = new Dictionary<string, decimal>();
                        sumTotals.Add("Total", item.Total);

                        sumTotals.Add("TotalValue", item.TotalValue);
                        sumTotals.Add("GrossPrice", item.GrossPrice);
                    }
                    else
                    {
                        sumTotals["Total"] = sumTotals["Total"] + item.Total;
                        sumTotals["TotalValue"] = sumTotals["TotalValue"] + item.TotalValue;
                        sumTotals["GrossPrice"] = sumTotals["GrossPrice"] + item.GrossPrice;
                    }


                    firstItem = false;
                    firstHeader = false;



                }
                quoteCC += 1;
            }

            if (firstItem == false)
            {
                foreach (KeyValuePair<string, decimal> valuePair in sumTotals)
                {
                    for (int valStart = quotationHeaderStart; valStart <= qoutationHeaderEnd; valStart++)
                    {
                        if (valuePair.Key == "Total")
                        {
                            quoteList[valStart].Total = valuePair.Value;
                        }

                        if (valuePair.Key == "TotalValue")
                        {
                            quoteList[valStart].TotalValue = valuePair.Value;
                        }

                        if (valuePair.Key == "GrossPrice")
                        {
                            quoteList[valStart].GrossPrice = valuePair.Value;
                        }
                    }
                }
                quotationHeaderStart = -1;
                qoutationHeaderEnd = -1;
            }


        }

        BackgroundWorker _workerRebalance = new BackgroundWorker();
        private void btnRebalance_Click(object sender, EventArgs e)
        {
           
            _worker.WorkerReportsProgress = true;
            _worker.DoWork += new System.ComponentModel.DoWorkEventHandler(rebalanceStart);
            _worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(rebalanceCompleted);
            _worker.RunWorkerAsync();
        }

        private void rebalanceStart(object sender, DoWorkEventArgs e)
        {
            //int milliseconds = 2;
            //Thread.Sleep(milliseconds);
            RebalanceGrid();
        }

        private void rebalanceCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bindingSource = new System.Windows.Forms.BindingSource { DataSource = quoteList };
            dgView.DataSource = bindingSource;
        }

    }
}
