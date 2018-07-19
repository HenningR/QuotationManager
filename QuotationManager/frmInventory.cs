using QuotationManager.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuotationManager.Factory.CommonModule;

namespace QuotationManager
{
    public enum windowState
    {
        AddMain
        , AddSub
        , Edit
        , Remove
        , None
    }



    public partial class frmInventory : Form
    {
        #region Declarations
        private windowState currentState = windowState.None;
        private InventoryItem currenInventoryItems = new InventoryItem();
        #endregion

        #region Constructor
        public frmInventory()
        {
            InitializeComponent();

            treeInventory.Nodes.Clear();
            LoadinventoryGroups();

        }
        #endregion

        #region Methods
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

        private void clearItemGrp(bool checkItem)
        {
            chkItem.Checked = checkItem;
            txtDescription.Text = "";
            txtUnit.Enabled = checkItem;
            txtUnit.Text = "";
            txtPrice.Enabled = checkItem;
            txtPrice.Text = "0.00";
            nmMarkup.Enabled = checkItem;
            nmMarkup.Value = 0;
            nmArte.Enabled = checkItem;
            nmArte.Value = 0;
        }

        private void AddParentItem()
        {
            currentState = windowState.AddMain;
            clearItemGrp(false);
            grpItem.Text = "Add";
            grpItem.Enabled = true;
        }

        private void AddChildItem()
        {
            currentState = windowState.AddSub;
            clearItemGrp(false);
            grpItem.Text = "Add";
            grpItem.Enabled = true;
        }

        private void EditItem()
        {
            currentState = windowState.Edit;
            grpItem.Text = "Edit";

            grpItem.Enabled = true;
            if (treeInventory.SelectedNode != null)
            {
                InventoryItem item = new InventoryItem();
                item = (InventoryItem)treeInventory.SelectedNode.Tag;

                txtDescription.Text = item.Description;

                chkItem.Checked = item.IsItem;
                if (chkItem.Checked)
                {
                    txtUnit.Text = item.Unit;
                    txtPrice.Text = item.Price.ToString();
                    nmMarkup.Value = item.MarkupPercentage;
                    nmArte.Value = item.ArtePercentage;
                }
                else
                {
                    txtUnit.Text = "";
                    txtPrice.Text = "0";
                    nmMarkup.Value = 0;
                    nmArte.Value = 0;
                }
                EnableItem();
                treeInventory.Focus();



            }
        }

        private void RemoveItem()
        {
            currentState = windowState.Remove;
            if (treeInventory.SelectedNode != null)
            {
                currenInventoryItems = (InventoryItem)treeInventory.SelectedNode.Tag;
                if (currenInventoryItems.Delete() > 0)
                {
                    treeInventory.SelectedNode.Remove();
                }

            }else
            {
                 showLableInfo("No tree node was selected to remove", InfoType.Warning);
            }
            showTreeButtons();
            currentState = windowState.None;
        }

        private void populateInventoryItem(ref string validationMessage,TreeNode currentNode = null)
        {


            currenInventoryItems = new InventoryItem();

            if (cmbGroups.SelectedIndex < 0)
            {
                validationMessage = "No group selected";
            }
            currenInventoryItems.InventoryID = cmbGroups.SelectedIndex;
            currenInventoryItems.InventoryItemID = -1;
            if (currentNode != null)
            {
                InventoryItem invItem = new InventoryItem();

                invItem = (InventoryItem)currentNode.Tag;
                currenInventoryItems.ParentInventoryItemID = invItem.InventoryItemID;
                currenInventoryItems.LevelIndex = invItem.LevelIndex + 1;
            }
            else
            {
                currenInventoryItems.LevelIndex = 0;
            }

            if (txtDescription.Text == "")
            {
                validationMessage = "Description cannot be empty";
            }

            currenInventoryItems.Description = txtDescription.Text;
            currenInventoryItems.IsItem = chkItem.Checked;

     
            currenInventoryItems.MarkupPercentage = nmMarkup.Value;

            decimal decVal = 0;
            Decimal.TryParse(txtPrice.Text, out decVal);
            currenInventoryItems.Price = decVal;

            if (txtUnit.Text == "")
            {
                validationMessage = "Unit cannot be empty";
            }
            currenInventoryItems.Unit = txtUnit.Text;
            currenInventoryItems.ArtePercentage = nmArte.Value;

        }

        private void SaveInventory(bool isNew, int treeLevel)
        {
            if (isNew)
            {
                currenInventoryItems.Save(true);
            }
        }

        private void EnableItem()
        {

            bool checkItem = chkItem.Checked;
            txtUnit.Enabled = checkItem;
            txtPrice.Enabled = checkItem;
            nmMarkup.Enabled = checkItem;
            nmArte.Enabled = checkItem;

        }

        private void showTreeButtons()
        {
            if (treeInventory.Nodes.Count > 0)
            {
                treeInventory.ExpandAll();
                btnRemove.Enabled = true;
                btnEdit.Enabled = true;
                btnAddChild.Enabled = true;
                cntMenu.Items["addSubToolStripMenuItem"].Enabled = true;
                cntMenu.Items["editToolStripMenuItem"].Enabled = true;
                cntMenu.Items["removeToolStripMenuItem"].Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
                btnEdit.Enabled = false;
                btnAddChild.Enabled = false;
                cntMenu.Items["addSubToolStripMenuItem"].Enabled = false;
                cntMenu.Items["editToolStripMenuItem"].Enabled = false;
                cntMenu.Items["removeToolStripMenuItem"].Enabled = false;
            }
        }

        private void LoadInventoryItemsTree(IEnumerable<InventoryItem> AllItems, IEnumerable<InventoryItem> Items, int levelInd, TreeNode existingNode = null)
        {

            IEnumerable<InventoryItem> SubItems = new List<InventoryItem>();
            int tempLevelInd = -1;
            foreach (InventoryItem item in Items.Where(p => p.LevelIndex.Equals(levelInd)))
            {

                TreeNode newNode = new TreeNode();
                newNode.Text = item.Description;
                newNode.Tag = item;

                if (existingNode == null)
                {
                    treeInventory.Nodes.Add(newNode);
                }
                else
                {
                    existingNode.Nodes.Add(newNode);

                }

                SubItems = new List<InventoryItem>();
                tempLevelInd = levelInd + 1;
                SubItems = AllItems.Where(p => p.LevelIndex.Equals(tempLevelInd) && p.ParentInventoryItemID.Equals(item.InventoryItemID));
                if (SubItems.Count() > 0)
                {
                    LoadInventoryItemsTree(AllItems, SubItems, tempLevelInd, newNode);
                }
            }

        }

        private void clearItemSelected()
        {
            clearItemGrp(false);
            grpItem.Enabled = false;
            showTreeButtons();
            currentState = windowState.None;
        }

        #endregion

        #region Events

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddParentItem();
        }

        private void addSubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddChildItem();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EditItem();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void treeInventory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            // Select this node.
            TreeNode node_here = treeInventory.GetNodeAt(e.X, e.Y);
            treeInventory.SelectedNode = node_here;
            cntMenu.Show(treeInventory, new Point(e.X, e.Y));
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currenInventoryItems = new InventoryItem();
            string validationMessage = "";
            if (currentState == windowState.AddMain)
            {
                if (txtDescription.Text == "")
                {
                    showLableInfo("No item description was entered", InfoType.Warning);
                    return;
                }

               
                if (treeInventory.SelectedNode != null && treeInventory.SelectedNode.Parent != null)
                {
                    populateInventoryItem(ref validationMessage, treeInventory.SelectedNode.Parent);

                    if (validationMessage != "")
                    {
                        showLableInfo(validationMessage, InfoType.Warning);
                        return;
                    }


                    SaveInventory(true, treeInventory.SelectedNode.Level);
                    int lastInserted = currenInventoryItems.getLastInventoryItemCount();

                    TreeNode node = new TreeNode();
                    currenInventoryItems.InventoryItemID = lastInserted;
                    node.Text = txtDescription.Text;
                    node.Tag = currenInventoryItems;
                    treeInventory.SelectedNode.Parent.Nodes.Add(node);
                    treeInventory.SelectedNode.Parent.ExpandAll();



                }
                else
                {
                    populateInventoryItem(ref validationMessage);

                    if (validationMessage != "")
                    {
                        showLableInfo(validationMessage, InfoType.Warning);
                        return;
                    }


                    SaveInventory(true, 0);
                    int lastInserted = currenInventoryItems.getLastInventoryItemCount();

                    TreeNode node = new TreeNode();
                    currenInventoryItems.InventoryItemID = lastInserted;
                    node.Text = txtDescription.Text;
                    node.Tag = currenInventoryItems;
                    treeInventory.Nodes.Add(node);


                }



            }
            else if (currentState == windowState.AddSub)
            {
                if (txtDescription.Text == "")
                {
                    showLableInfo("No item description was entered", InfoType.Warning);
                    return;
                }

                if (treeInventory.SelectedNode != null)
                {
                    populateInventoryItem(ref validationMessage,treeInventory.SelectedNode);

                    if (validationMessage != "")
                    {
                        showLableInfo(validationMessage, InfoType.Warning);
                        return;
                    }

                    SaveInventory(true, treeInventory.SelectedNode.Level + 1);

                    int lastInserted = currenInventoryItems.getLastInventoryItemCount();

                    TreeNode node = new TreeNode();
                    currenInventoryItems.InventoryItemID = lastInserted;
                    node.Text = txtDescription.Text;
                    node.Tag = currenInventoryItems;
                    treeInventory.SelectedNode.Nodes.Add(node);
                    treeInventory.SelectedNode.ExpandAll();

                }
                else
                {
                    populateInventoryItem(ref validationMessage);

                    if (validationMessage != "")
                    {
                        showLableInfo(validationMessage, InfoType.Warning);
                        return;
                    }

                    SaveInventory(true, 0);

                    int lastInserted = currenInventoryItems.getLastInventoryItemCount();

                    TreeNode node = new TreeNode();
                    currenInventoryItems.InventoryItemID = lastInserted;
                    node.Text = txtDescription.Text;
                    node.Tag = currenInventoryItems;
                    treeInventory.Nodes.Add(node);
                }

            }
            else if (currentState == windowState.Edit)
            {
                if (txtDescription.Text == "")
                {
                    showLableInfo("Item description cannot be empty", InfoType.Error);
                    return;
                }

                if (treeInventory.SelectedNode != null)
                {
                    treeInventory.SelectedNode.Text = txtDescription.Text;
                    InventoryItem item = new InventoryItem();
                    item = (InventoryItem)treeInventory.SelectedNode.Tag;
                    item.Description = txtDescription.Text;

                    if (txtDescription.Text == "")
                    {
                        showLableInfo("Description cannot be empty", InfoType.Warning);
                        return;
                    }

                    if (chkItem.Checked)
                    {
                        item.IsItem = chkItem.Checked;
                        item.Unit = txtUnit.Text;
                        if (txtUnit.Text == "")
                        {
                            showLableInfo("Unit cannot be empty", InfoType.Warning);
                            return;
                        }

                        decimal val = 0;
                        Decimal.TryParse(txtPrice.Text, out val);
                        item.Price = val;
                        item.MarkupPercentage = nmMarkup.Value;
                        item.ArtePercentage = nmArte.Value;
                    }
                    else
                    {
                        item.IsItem = chkItem.Checked;
                        item.Unit = "";
                        item.Price = 0;
                        item.MarkupPercentage = 0;
                        item.ArtePercentage = 0;
                    }
                    if (item.Save(false) > 0)
                    {
                        treeInventory.SelectedNode.Tag = item;
                    }

                }
            }

            clearItemGrp(false);
            grpItem.Enabled = false;
            showTreeButtons();
            currentState = windowState.None;
        }

        private void chkItem_CheckedChanged(object sender, EventArgs e)
        {
            EnableItem();
        }

        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            cmbGroups.Visible = false;
            txtGroup.Visible = true;
            btnNewGroup.Enabled = false;
            btnAddGroup.Visible = true;
            btnCancelGroup.Visible = true;
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (txtGroup.Text != "")
            {
                Inventory inv = new Inventory();
                inv.Description = txtGroup.Text;
                inv.Save(true);
                LoadinventoryGroups();
                btnNewGroup.Enabled = true;
                txtGroup.Visible = false;
                cmbGroups.Visible = true;
                btnAddGroup.Visible = false;
                btnCancelGroup.Visible = false;
            }
            else
            {
                showLableInfo("No group was entered", InfoType.Warning);
            }

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

        private void  showLableInfo(object sender, DoWorkEventArgs e)
        {
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }

        private void showLableInfoCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblInfo.Visible = false;
        }



        private void btnCancelGroup_Click(object sender, EventArgs e)
        {
            btnNewGroup.Enabled = true;
            txtGroup.Visible = false;
            cmbGroups.Visible = true;
            btnAddGroup.Visible = false;
            btnCancelGroup.Visible = false;
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpTreeControls.Enabled = false;
            if (cmbGroups.SelectedIndex >= 0 && cmbGroups.SelectedItem != null)
            {
                clearItemSelected();
                treeInventory.Nodes.Clear();
                int grpItem = cmbGroups.SelectedIndex;
                List<InventoryItem> items = new List<InventoryItem>();
                items = InventoryItem.GetInventoryItems(grpItem);
                LoadInventoryItemsTree(items, items, 0);
                if (treeInventory.Nodes.Count > 0)
                {
                    treeInventory.ExpandAll();

                }
                showTreeButtons();



                grpTreeControls.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            AddParentItem();

        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            AddChildItem();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void grpItem_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            clearItemSelected();
        }

        private void treeInventory_Click(object sender, EventArgs e)
        {
            clearItemSelected();
        }

        #endregion

        private void frmInventory_Load(object sender, EventArgs e)
        {

        }
    }
}
