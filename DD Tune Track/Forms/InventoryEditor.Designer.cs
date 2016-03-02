namespace DD_Tune_Track.Forms
{
    partial class InventoryEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBarcodeNumber = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBarcodeNumber = new System.Windows.Forms.TextBox();
            this.dgvInventoryList = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.TextBox();
            this.lblBarcodeNumberError = new System.Windows.Forms.Label();
            this.lblDescriptionEditor = new System.Windows.Forms.Label();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.colBarcodeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarcodeNumber
            // 
            this.lblBarcodeNumber.AutoSize = true;
            this.lblBarcodeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcodeNumber.Location = new System.Drawing.Point(12, 86);
            this.lblBarcodeNumber.Name = "lblBarcodeNumber";
            this.lblBarcodeNumber.Size = new System.Drawing.Size(179, 25);
            this.lblBarcodeNumber.TabIndex = 22;
            this.lblBarcodeNumber.Text = "Barcode Number:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(65, 123);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 25);
            this.lblDescription.TabIndex = 23;
            this.lblDescription.Text = "Description:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(402, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 37);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(291, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 37);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtBarcodeNumber
            // 
            this.txtBarcodeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcodeNumber.Location = new System.Drawing.Point(197, 83);
            this.txtBarcodeNumber.Name = "txtBarcodeNumber";
            this.txtBarcodeNumber.Size = new System.Drawing.Size(310, 31);
            this.txtBarcodeNumber.TabIndex = 27;
            // 
            // dgvInventoryList
            // 
            this.dgvInventoryList.AllowUserToAddRows = false;
            this.dgvInventoryList.AllowUserToDeleteRows = false;
            this.dgvInventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarcodeNumber,
            this.colDescription,
            this.colRemove});
            this.dgvInventoryList.EnableHeadersVisualStyles = false;
            this.dgvInventoryList.Location = new System.Drawing.Point(12, 200);
            this.dgvInventoryList.Name = "dgvInventoryList";
            this.dgvInventoryList.ReadOnly = true;
            this.dgvInventoryList.RowHeadersVisible = false;
            this.dgvInventoryList.Size = new System.Drawing.Size(751, 413);
            this.dgvInventoryList.TabIndex = 30;
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 12);
            this.lblInfo.Multiline = true;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.ReadOnly = true;
            this.lblInfo.Size = new System.Drawing.Size(756, 65);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.TabStop = false;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // lblBarcodeNumberError
            // 
            this.lblBarcodeNumberError.AutoSize = true;
            this.lblBarcodeNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcodeNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblBarcodeNumberError.Location = new System.Drawing.Point(513, 86);
            this.lblBarcodeNumberError.Name = "lblBarcodeNumberError";
            this.lblBarcodeNumberError.Size = new System.Drawing.Size(250, 25);
            this.lblBarcodeNumberError.TabIndex = 32;
            this.lblBarcodeNumberError.Text = "Barcode Number Not Set";
            this.lblBarcodeNumberError.Visible = false;
            // 
            // lblDescriptionEditor
            // 
            this.lblDescriptionEditor.AutoSize = true;
            this.lblDescriptionEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionEditor.ForeColor = System.Drawing.Color.Red;
            this.lblDescriptionEditor.Location = new System.Drawing.Point(513, 123);
            this.lblDescriptionEditor.Name = "lblDescriptionEditor";
            this.lblDescriptionEditor.Size = new System.Drawing.Size(197, 25);
            this.lblDescriptionEditor.TabIndex = 33;
            this.lblDescriptionEditor.Text = "Description Not Set";
            this.lblDescriptionEditor.Visible = false;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.Location = new System.Drawing.Point(466, 619);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(184, 37);
            this.btnSaveAndClose.TabIndex = 36;
            this.btnSaveAndClose.Text = "Save and Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(656, 619);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(197, 120);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(310, 31);
            this.txtDescription.TabIndex = 37;
            // 
            // colBarcodeNumber
            // 
            this.colBarcodeNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBarcodeNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBarcodeNumber.HeaderText = "Barcode Number";
            this.colBarcodeNumber.Name = "colBarcodeNumber";
            this.colBarcodeNumber.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle4;
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "-";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 5;
            // 
            // InventoryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 668);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDescriptionEditor);
            this.Controls.Add(this.lblBarcodeNumberError);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvInventoryList);
            this.Controls.Add(this.txtBarcodeNumber);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblBarcodeNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryEditor";
            this.ShowInTaskbar = false;
            this.Text = "Inventory Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarcodeNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBarcodeNumber;
        private System.Windows.Forms.DataGridView dgvInventoryList;
        private System.Windows.Forms.TextBox lblInfo;
        private System.Windows.Forms.Label lblBarcodeNumberError;
        private System.Windows.Forms.Label lblDescriptionEditor;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcodeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
    }
}