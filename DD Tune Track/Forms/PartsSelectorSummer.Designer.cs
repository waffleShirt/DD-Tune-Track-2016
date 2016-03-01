namespace DD_Tune_Track.Forms
{
    partial class PartsSelectorSummer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsSelectorSummer));
            this.lstParts = new System.Windows.Forms.ListBox();
            this.lblBarcodeNum = new System.Windows.Forms.Label();
            this.txtBarcodeNumber = new System.Windows.Forms.TextBox();
            this.lblPartsListForBike = new System.Windows.Forms.Label();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.dgvPartsListForBike = new System.Windows.Forms.DataGridView();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsListForBike)).BeginInit();
            this.SuspendLayout();
            // 
            // lstParts
            // 
            this.lstParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstParts.FormattingEnabled = true;
            this.lstParts.ItemHeight = 20;
            this.lstParts.Items.AddRange(new object[] {
            "#1016 -    SRAM Guide Pads",
            "#199 -      Shift Cable",
            "#495 -      Maxxis Minion DHF 27.5",
            "#496 -      Maxxis Minion DHR 27.5",
            "#LAB15 - 15 Minutes Labour",
            "#LAB30 - 30 Minutes Labour",
            "#LAB45 - 45 Minutes Labour",
            "#LAB60 - 60 Minutes Labour"});
            this.lstParts.Location = new System.Drawing.Point(13, 13);
            this.lstParts.Name = "lstParts";
            this.lstParts.Size = new System.Drawing.Size(458, 224);
            this.lstParts.Sorted = true;
            this.lstParts.TabIndex = 0;
            // 
            // lblBarcodeNum
            // 
            this.lblBarcodeNum.AutoSize = true;
            this.lblBarcodeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcodeNum.Location = new System.Drawing.Point(8, 249);
            this.lblBarcodeNum.Name = "lblBarcodeNum";
            this.lblBarcodeNum.Size = new System.Drawing.Size(179, 25);
            this.lblBarcodeNum.TabIndex = 1;
            this.lblBarcodeNum.Text = "Barcode Number:";
            // 
            // txtBarcodeNumber
            // 
            this.txtBarcodeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcodeNumber.Location = new System.Drawing.Point(193, 246);
            this.txtBarcodeNumber.Name = "txtBarcodeNumber";
            this.txtBarcodeNumber.Size = new System.Drawing.Size(278, 31);
            this.txtBarcodeNumber.TabIndex = 2;
            // 
            // lblPartsListForBike
            // 
            this.lblPartsListForBike.AutoSize = true;
            this.lblPartsListForBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsListForBike.Location = new System.Drawing.Point(8, 293);
            this.lblPartsListForBike.Name = "lblPartsListForBike";
            this.lblPartsListForBike.Size = new System.Drawing.Size(241, 25);
            this.lblPartsListForBike.TabIndex = 3;
            this.lblPartsListForBike.Text = "Parts List For This Bike:";
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.Location = new System.Drawing.Point(294, 477);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(177, 39);
            this.btnSaveAndClose.TabIndex = 5;
            this.btnSaveAndClose.Text = "Save And Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            // 
            // dgvPartsListForBike
            // 
            this.dgvPartsListForBike.AllowUserToAddRows = false;
            this.dgvPartsListForBike.AllowUserToDeleteRows = false;
            this.dgvPartsListForBike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsListForBike.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarcode,
            this.colDescription,
            this.colQuantity,
            this.colRemove,
            this.colAdd});
            this.dgvPartsListForBike.Location = new System.Drawing.Point(13, 321);
            this.dgvPartsListForBike.Name = "dgvPartsListForBike";
            this.dgvPartsListForBike.ReadOnly = true;
            this.dgvPartsListForBike.RowHeadersVisible = false;
            this.dgvPartsListForBike.Size = new System.Drawing.Size(458, 150);
            this.dgvPartsListForBike.TabIndex = 7;
            this.dgvPartsListForBike.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colBarcode
            // 
            this.colBarcode.HeaderText = "Bar Code";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle1;
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "-";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 5;
            // 
            // colAdd
            // 
            this.colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAdd.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAdd.HeaderText = "";
            this.colAdd.Name = "colAdd";
            this.colAdd.ReadOnly = true;
            this.colAdd.Text = "+";
            this.colAdd.UseColumnTextForButtonValue = true;
            this.colAdd.Width = 5;
            // 
            // PartsSelectorSummer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 527);
            this.Controls.Add(this.dgvPartsListForBike);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.lblPartsListForBike);
            this.Controls.Add(this.txtBarcodeNumber);
            this.Controls.Add(this.lblBarcodeNum);
            this.Controls.Add(this.lstParts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartsSelectorSummer";
            this.ShowInTaskbar = false;
            this.Text = "Parts Selector";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsListForBike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstParts;
        private System.Windows.Forms.Label lblBarcodeNum;
        private System.Windows.Forms.TextBox txtBarcodeNumber;
        private System.Windows.Forms.Label lblPartsListForBike;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.DataGridView dgvPartsListForBike;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.DataGridViewButtonColumn colAdd;
    }
}