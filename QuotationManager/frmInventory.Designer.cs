namespace QuotationManager
{
    partial class frmInventory
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Rug(s)");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Underveldt");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Wrapping");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Loose Rugs", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("LOOSE RUGS-CMT", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            this.treeInventory = new System.Windows.Forms.TreeView();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.chkItem = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmArte = new System.Windows.Forms.NumericUpDown();
            this.nmMarkup = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cntMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewGroup = new System.Windows.Forms.Button();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnCancelGroup = new System.Windows.Forms.Button();
            this.grpTreeControls = new System.Windows.Forms.GroupBox();
            this.btnAddParent = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmArte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMarkup)).BeginInit();
            this.cntMenu.SuspendLayout();
            this.grpTreeControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeInventory
            // 
            this.treeInventory.Location = new System.Drawing.Point(22, 63);
            this.treeInventory.Name = "treeInventory";
            treeNode19.Name = "Node3";
            treeNode19.Text = "Rug(s)";
            treeNode20.Name = "Node4";
            treeNode20.Text = "Underveldt";
            treeNode21.Name = "Node5";
            treeNode21.Text = "Wrapping";
            treeNode22.Name = "Node0";
            treeNode22.Text = "Loose Rugs";
            treeNode23.Name = "Node6";
            treeNode23.Text = "Node6";
            treeNode24.Name = "Node1";
            treeNode24.Text = "LOOSE RUGS-CMT";
            this.treeInventory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode24});
            this.treeInventory.Size = new System.Drawing.Size(439, 316);
            this.treeInventory.TabIndex = 0;
            this.treeInventory.Click += new System.EventHandler(this.treeInventory_Click);
            this.treeInventory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeInventory_MouseDown);
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(21, 36);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(440, 21);
            this.cmbGroups.TabIndex = 4;
            this.cmbGroups.Text = "Floor Decorations";
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inventory Group";
            // 
            // grpItem
            // 
            this.grpItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpItem.Controls.Add(this.btnCancelItem);
            this.grpItem.Controls.Add(this.chkItem);
            this.grpItem.Controls.Add(this.label7);
            this.grpItem.Controls.Add(this.txtDescription);
            this.grpItem.Controls.Add(this.label2);
            this.grpItem.Controls.Add(this.nmArte);
            this.grpItem.Controls.Add(this.nmMarkup);
            this.grpItem.Controls.Add(this.btnSave);
            this.grpItem.Controls.Add(this.label6);
            this.grpItem.Controls.Add(this.label5);
            this.grpItem.Controls.Add(this.txtPrice);
            this.grpItem.Controls.Add(this.label4);
            this.grpItem.Controls.Add(this.txtUnit);
            this.grpItem.Enabled = false;
            this.grpItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpItem.Location = new System.Drawing.Point(467, 66);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(450, 323);
            this.grpItem.TabIndex = 6;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "EDIT ITEM";
            this.grpItem.Enter += new System.EventHandler(this.grpItem_Enter);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Location = new System.Drawing.Point(344, 280);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(100, 27);
            this.btnCancelItem.TabIndex = 16;
            this.btnCancelItem.Text = "Cancel";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // chkItem
            // 
            this.chkItem.AutoSize = true;
            this.chkItem.Location = new System.Drawing.Point(15, 69);
            this.chkItem.Name = "chkItem";
            this.chkItem.Size = new System.Drawing.Size(46, 17);
            this.chkItem.TabIndex = 15;
            this.chkItem.Text = "Item";
            this.chkItem.UseVisualStyleBackColor = true;
            this.chkItem.CheckedChanged += new System.EventHandler(this.chkItem_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Unit";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 43);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(429, 20);
            this.txtDescription.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // nmArte
            // 
            this.nmArte.Location = new System.Drawing.Point(15, 239);
            this.nmArte.Name = "nmArte";
            this.nmArte.Size = new System.Drawing.Size(116, 20);
            this.nmArte.TabIndex = 11;
            // 
            // nmMarkup
            // 
            this.nmMarkup.Location = new System.Drawing.Point(15, 186);
            this.nmMarkup.Name = "nmMarkup";
            this.nmMarkup.Size = new System.Drawing.Size(116, 20);
            this.nmMarkup.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Arte (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Markup (%)";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(147, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(116, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Text = "10";
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price (R)";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(15, 141);
            this.txtUnit.MaxLength = 500;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(116, 20);
            this.txtUnit.TabIndex = 1;
            this.txtUnit.Text = "ea";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(817, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 27);
            this.button4.TabIndex = 7;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cntMenu
            // 
            this.cntMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.addSubToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.cntMenu.Name = "cntMenu";
            this.cntMenu.Size = new System.Drawing.Size(134, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addToolStripMenuItem.Text = "Add Parent";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addSubToolStripMenuItem
            // 
            this.addSubToolStripMenuItem.Name = "addSubToolStripMenuItem";
            this.addSubToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addSubToolStripMenuItem.Text = "Add Child";
            this.addSubToolStripMenuItem.Click += new System.EventHandler(this.addSubToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.Location = new System.Drawing.Point(467, 33);
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(66, 27);
            this.btnNewGroup.TabIndex = 9;
            this.btnNewGroup.Text = "New";
            this.btnNewGroup.UseVisualStyleBackColor = true;
            this.btnNewGroup.Click += new System.EventHandler(this.btnNewGroup_Click);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(21, 37);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(440, 20);
            this.txtGroup.TabIndex = 10;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(539, 33);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(66, 27);
            this.btnAddGroup.TabIndex = 11;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Visible = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnCancelGroup
            // 
            this.btnCancelGroup.Location = new System.Drawing.Point(611, 33);
            this.btnCancelGroup.Name = "btnCancelGroup";
            this.btnCancelGroup.Size = new System.Drawing.Size(66, 27);
            this.btnCancelGroup.TabIndex = 12;
            this.btnCancelGroup.Text = "Cancel";
            this.btnCancelGroup.UseVisualStyleBackColor = true;
            this.btnCancelGroup.Visible = false;
            this.btnCancelGroup.Click += new System.EventHandler(this.btnCancelGroup_Click);
            // 
            // grpTreeControls
            // 
            this.grpTreeControls.Controls.Add(this.btnAddParent);
            this.grpTreeControls.Controls.Add(this.btnRemove);
            this.grpTreeControls.Controls.Add(this.btnEdit);
            this.grpTreeControls.Controls.Add(this.btnAddChild);
            this.grpTreeControls.Enabled = false;
            this.grpTreeControls.Location = new System.Drawing.Point(21, 385);
            this.grpTreeControls.Name = "grpTreeControls";
            this.grpTreeControls.Size = new System.Drawing.Size(439, 50);
            this.grpTreeControls.TabIndex = 13;
            this.grpTreeControls.TabStop = false;
            // 
            // btnAddParent
            // 
            this.btnAddParent.Location = new System.Drawing.Point(221, 16);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(103, 27);
            this.btnAddParent.TabIndex = 12;
            this.btnAddParent.Text = "Add Parent";
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(9, 16);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(66, 27);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(81, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 27);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(330, 16);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(103, 27);
            this.btnAddChild.TabIndex = 9;
            this.btnAddChild.Text = "Add Child";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(22, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(895, 15);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 452);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.grpTreeControls);
            this.Controls.Add(this.btnCancelGroup);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnNewGroup);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.treeInventory);
            this.Controls.Add(this.txtGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInventory";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory Screen";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmArte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMarkup)).EndInit();
            this.cntMenu.ResumeLayout(false);
            this.grpTreeControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeInventory;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip cntMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nmArte;
        private System.Windows.Forms.NumericUpDown nmMarkup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkItem;
        private System.Windows.Forms.ToolStripMenuItem addSubToolStripMenuItem;
        private System.Windows.Forms.Button btnNewGroup;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnCancelGroup;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.GroupBox grpTreeControls;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Label lblInfo;
    }
}