namespace QuotationManager
{
    partial class frmQuotation
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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveQuote = new System.Windows.Forms.Button();
            this.btnCancelQuote = new System.Windows.Forms.Button();
            this.cmbExistingQuotation = new System.Windows.Forms.ComboBox();
            this.btnNewQuotation = new System.Windows.Forms.Button();
            this.btnOpenQuotation = new System.Windows.Forms.Button();
            this.txtNewQuotation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSection = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.txtCustomHeader = new System.Windows.Forms.TextBox();
            this.btnAddCustomHeader = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.btnAddQuotationSection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARKUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARKUPValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROSSPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTEPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArteValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrandTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRebalance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Level,
            this.QuotationDetailID,
            this.QuotationID,
            this.IsItem,
            this.QuoteOrder,
            this.DESCRIPTION,
            this.UNIT,
            this.QUANTITY,
            this.PRICE,
            this.TOTAL,
            this.MARKUP,
            this.MARKUPValue,
            this.GROSSPRICE,
            this.ARTEPerc,
            this.ArteValue,
            this.GrandTOTAL});
            this.dgView.Location = new System.Drawing.Point(12, 148);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(1314, 299);
            this.dgView.TabIndex = 0;
            this.dgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellContentClick);
            this.dgView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellEndEdit);
            this.dgView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgView_CellFormatting);
            this.dgView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellLeave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1226, 453);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 27);
            this.button4.TabIndex = 8;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1120, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Genrate Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveQuote);
            this.groupBox1.Controls.Add(this.btnCancelQuote);
            this.groupBox1.Controls.Add(this.cmbExistingQuotation);
            this.groupBox1.Controls.Add(this.btnNewQuotation);
            this.groupBox1.Controls.Add(this.btnOpenQuotation);
            this.groupBox1.Controls.Add(this.txtNewQuotation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quotation Section";
            // 
            // btnSaveQuote
            // 
            this.btnSaveQuote.Enabled = false;
            this.btnSaveQuote.Location = new System.Drawing.Point(510, 32);
            this.btnSaveQuote.Name = "btnSaveQuote";
            this.btnSaveQuote.Size = new System.Drawing.Size(66, 27);
            this.btnSaveQuote.TabIndex = 8;
            this.btnSaveQuote.Text = "Save";
            this.btnSaveQuote.UseVisualStyleBackColor = true;
            this.btnSaveQuote.Click += new System.EventHandler(this.btnSaveQuote_Click);
            // 
            // btnCancelQuote
            // 
            this.btnCancelQuote.Enabled = false;
            this.btnCancelQuote.Location = new System.Drawing.Point(438, 32);
            this.btnCancelQuote.Name = "btnCancelQuote";
            this.btnCancelQuote.Size = new System.Drawing.Size(66, 27);
            this.btnCancelQuote.TabIndex = 7;
            this.btnCancelQuote.Text = "Cancel";
            this.btnCancelQuote.UseVisualStyleBackColor = true;
            this.btnCancelQuote.Click += new System.EventHandler(this.btnCancelQuote_Click);
            // 
            // cmbExistingQuotation
            // 
            this.cmbExistingQuotation.FormattingEnabled = true;
            this.cmbExistingQuotation.Location = new System.Drawing.Point(5, 36);
            this.cmbExistingQuotation.Name = "cmbExistingQuotation";
            this.cmbExistingQuotation.Size = new System.Drawing.Size(274, 21);
            this.cmbExistingQuotation.TabIndex = 6;
            this.cmbExistingQuotation.SelectedIndexChanged += new System.EventHandler(this.cmbExistingQuotation_SelectedIndexChanged);
            // 
            // btnNewQuotation
            // 
            this.btnNewQuotation.Location = new System.Drawing.Point(366, 32);
            this.btnNewQuotation.Name = "btnNewQuotation";
            this.btnNewQuotation.Size = new System.Drawing.Size(66, 27);
            this.btnNewQuotation.TabIndex = 5;
            this.btnNewQuotation.Text = "New";
            this.btnNewQuotation.UseVisualStyleBackColor = true;
            this.btnNewQuotation.Click += new System.EventHandler(this.btnNewQuotation_Click);
            // 
            // btnOpenQuotation
            // 
            this.btnOpenQuotation.Location = new System.Drawing.Point(294, 32);
            this.btnOpenQuotation.Name = "btnOpenQuotation";
            this.btnOpenQuotation.Size = new System.Drawing.Size(66, 27);
            this.btnOpenQuotation.TabIndex = 4;
            this.btnOpenQuotation.Text = "Open";
            this.btnOpenQuotation.UseVisualStyleBackColor = true;
            this.btnOpenQuotation.Click += new System.EventHandler(this.btnOpenQuotation_Click);
            // 
            // txtNewQuotation
            // 
            this.txtNewQuotation.Location = new System.Drawing.Point(5, 36);
            this.txtNewQuotation.Name = "txtNewQuotation";
            this.txtNewQuotation.Size = new System.Drawing.Size(274, 20);
            this.txtNewQuotation.TabIndex = 3;
            this.txtNewQuotation.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Existing Quotation number";
            // 
            // grpSection
            // 
            this.grpSection.Controls.Add(this.label4);
            this.grpSection.Controls.Add(this.cmbGroups);
            this.grpSection.Controls.Add(this.txtCustomHeader);
            this.grpSection.Controls.Add(this.btnAddCustomHeader);
            this.grpSection.Controls.Add(this.label3);
            this.grpSection.Controls.Add(this.cmbSection);
            this.grpSection.Controls.Add(this.btnAddQuotationSection);
            this.grpSection.Controls.Add(this.label1);
            this.grpSection.Location = new System.Drawing.Point(610, 29);
            this.grpSection.Name = "grpSection";
            this.grpSection.Size = new System.Drawing.Size(719, 113);
            this.grpSection.TabIndex = 12;
            this.grpSection.TabStop = false;
            this.grpSection.Text = "Sections";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Inventory Group";
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(373, 34);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(336, 21);
            this.cmbGroups.TabIndex = 12;
            this.cmbGroups.Text = "Floor Decorations";
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // txtCustomHeader
            // 
            this.txtCustomHeader.Location = new System.Drawing.Point(16, 35);
            this.txtCustomHeader.Name = "txtCustomHeader";
            this.txtCustomHeader.Size = new System.Drawing.Size(270, 20);
            this.txtCustomHeader.TabIndex = 11;
            this.txtCustomHeader.Text = "Foyer/Entrance Hall";
            // 
            // btnAddCustomHeader
            // 
            this.btnAddCustomHeader.Location = new System.Drawing.Point(292, 31);
            this.btnAddCustomHeader.Name = "btnAddCustomHeader";
            this.btnAddCustomHeader.Size = new System.Drawing.Size(66, 27);
            this.btnAddCustomHeader.TabIndex = 10;
            this.btnAddCustomHeader.Text = "Add Section";
            this.btnAddCustomHeader.UseVisualStyleBackColor = true;
            this.btnAddCustomHeader.Click += new System.EventHandler(this.btnAddCustomHeader_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Custom Header";
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(373, 77);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(264, 21);
            this.cmbSection.TabIndex = 8;
            this.cmbSection.Text = "Floor Decorations";
            // 
            // btnAddQuotationSection
            // 
            this.btnAddQuotationSection.Location = new System.Drawing.Point(643, 73);
            this.btnAddQuotationSection.Name = "btnAddQuotationSection";
            this.btnAddQuotationSection.Size = new System.Drawing.Size(66, 27);
            this.btnAddQuotationSection.TabIndex = 7;
            this.btnAddQuotationSection.Text = "Add Section";
            this.btnAddQuotationSection.UseVisualStyleBackColor = true;
            this.btnAddQuotationSection.Click += new System.EventHandler(this.btnAddQuotationSection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Section";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1314, 16);
            this.lblInfo.TabIndex = 15;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "LevelIndex";
            this.Level.HeaderText = "";
            this.Level.Name = "Level";
            // 
            // QuotationDetailID
            // 
            this.QuotationDetailID.DataPropertyName = "QuotationDetailID";
            this.QuotationDetailID.HeaderText = "QuotationDetailID";
            this.QuotationDetailID.Name = "QuotationDetailID";
            this.QuotationDetailID.Visible = false;
            // 
            // QuotationID
            // 
            this.QuotationID.DataPropertyName = "QuotationID";
            this.QuotationID.HeaderText = "QuotationID";
            this.QuotationID.Name = "QuotationID";
            this.QuotationID.Visible = false;
            // 
            // IsItem
            // 
            this.IsItem.DataPropertyName = "IsItem";
            this.IsItem.HeaderText = "IsItem";
            this.IsItem.Name = "IsItem";
            this.IsItem.Visible = false;
            // 
            // QuoteOrder
            // 
            this.QuoteOrder.DataPropertyName = "QuoteOrder";
            this.QuoteOrder.HeaderText = "QuoteOrder";
            this.QuoteOrder.Name = "QuoteOrder";
            this.QuoteOrder.Visible = false;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            // 
            // UNIT
            // 
            this.UNIT.DataPropertyName = "UNIT";
            this.UNIT.HeaderText = "UNIT";
            this.UNIT.Name = "UNIT";
            // 
            // QUANTITY
            // 
            this.QUANTITY.DataPropertyName = "QUANTITY";
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.Name = "PRICE";
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // MARKUP
            // 
            this.MARKUP.DataPropertyName = "MarkupPercentage";
            this.MARKUP.HeaderText = "MARKUP(%)";
            this.MARKUP.Name = "MARKUP";
            // 
            // MARKUPValue
            // 
            this.MARKUPValue.DataPropertyName = "MarkupValue";
            this.MARKUPValue.HeaderText = "MARKUP(R)";
            this.MARKUPValue.Name = "MARKUPValue";
            // 
            // GROSSPRICE
            // 
            this.GROSSPRICE.DataPropertyName = "GrossPrice";
            this.GROSSPRICE.HeaderText = "GROSS PRICE";
            this.GROSSPRICE.Name = "GROSSPRICE";
            // 
            // ARTEPerc
            // 
            this.ARTEPerc.DataPropertyName = "ArtePercentage";
            this.ARTEPerc.HeaderText = "ARTE(%)";
            this.ARTEPerc.Name = "ARTEPerc";
            // 
            // ArteValue
            // 
            this.ArteValue.DataPropertyName = "ArteValue";
            this.ArteValue.HeaderText = "ARTE(R)";
            this.ArteValue.Name = "ArteValue";
            // 
            // GrandTOTAL
            // 
            this.GrandTOTAL.DataPropertyName = "TotalValue";
            this.GrandTOTAL.HeaderText = "TOTAL(R)";
            this.GrandTOTAL.Name = "GrandTOTAL";
            // 
            // btnRebalance
            // 
            this.btnRebalance.Location = new System.Drawing.Point(12, 453);
            this.btnRebalance.Name = "btnRebalance";
            this.btnRebalance.Size = new System.Drawing.Size(100, 27);
            this.btnRebalance.TabIndex = 16;
            this.btnRebalance.Text = "Refresh Grid";
            this.btnRebalance.UseVisualStyleBackColor = true;
            this.btnRebalance.Click += new System.EventHandler(this.btnRebalance_Click);
            // 
            // frmQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 487);
            this.Controls.Add(this.btnRebalance);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.grpSection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgView);
            this.Name = "frmQuotation";
            this.Text = "Quotation screen";
            this.Load += new System.EventHandler(this.frmQuotation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSection.ResumeLayout(false);
            this.grpSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNewQuotation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewQuotation;
        private System.Windows.Forms.GroupBox grpSection;
        private System.Windows.Forms.Button btnAddQuotationSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomHeader;
        private System.Windows.Forms.Button btnAddCustomHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.ComboBox cmbExistingQuotation;
        private System.Windows.Forms.Button btnCancelQuote;
        private System.Windows.Forms.Button btnSaveQuote;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOpenQuotation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARKUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARKUPValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROSSPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTEPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArteValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrandTOTAL;
        private System.Windows.Forms.Button btnRebalance;
    }
}