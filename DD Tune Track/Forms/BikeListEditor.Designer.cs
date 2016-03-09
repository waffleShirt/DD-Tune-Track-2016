namespace DD_Tune_Track.Forms
{
    partial class BikeListEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BikeListEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAssetNumber = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAssetNumber = new System.Windows.Forms.TextBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.dgvBikeList = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.TextBox();
            this.lblAssetNumberError = new System.Windows.Forms.Label();
            this.lblBrandError = new System.Windows.Forms.Label();
            this.lblModelError = new System.Windows.Forms.Label();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSerialNumberError = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.lblAssetExistsError = new System.Windows.Forms.Label();
            this.colAssetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSuppressDing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBikeList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAssetNumber
            // 
            this.lblAssetNumber.AutoSize = true;
            this.lblAssetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetNumber.Location = new System.Drawing.Point(12, 145);
            this.lblAssetNumber.Name = "lblAssetNumber";
            this.lblAssetNumber.Size = new System.Drawing.Size(153, 25);
            this.lblAssetNumber.TabIndex = 22;
            this.lblAssetNumber.Text = "Asset Number:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(90, 182);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(75, 25);
            this.lblBrand.TabIndex = 23;
            this.lblBrand.Text = "Brand:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(88, 221);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(77, 25);
            this.lblModel.TabIndex = 24;
            this.lblModel.Text = "Model:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(376, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(265, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 37);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAssetNumber
            // 
            this.txtAssetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetNumber.Location = new System.Drawing.Point(171, 142);
            this.txtAssetNumber.Name = "txtAssetNumber";
            this.txtAssetNumber.Size = new System.Drawing.Size(310, 31);
            this.txtAssetNumber.TabIndex = 1;
            // 
            // cmbModel
            // 
            this.cmbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(171, 218);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(310, 33);
            this.cmbModel.TabIndex = 3;
            // 
            // cmbBrand
            // 
            this.cmbBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(171, 179);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(310, 33);
            this.cmbBrand.TabIndex = 2;
            // 
            // dgvBikeList
            // 
            this.dgvBikeList.AllowUserToAddRows = false;
            this.dgvBikeList.AllowUserToDeleteRows = false;
            this.dgvBikeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBikeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssetNumber,
            this.colBrand,
            this.colModel,
            this.colSerialNumber,
            this.colRemove});
            this.dgvBikeList.EnableHeadersVisualStyles = false;
            this.dgvBikeList.Location = new System.Drawing.Point(12, 346);
            this.dgvBikeList.Name = "dgvBikeList";
            this.dgvBikeList.ReadOnly = true;
            this.dgvBikeList.RowHeadersVisible = false;
            this.dgvBikeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBikeList.Size = new System.Drawing.Size(800, 267);
            this.dgvBikeList.TabIndex = 30;
            this.dgvBikeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBikeList_CellContentClick);
            this.dgvBikeList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvBikeList_MouseUp);
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.HideSelection = false;
            this.lblInfo.Location = new System.Drawing.Point(12, 12);
            this.lblInfo.Multiline = true;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.ReadOnly = true;
            this.lblInfo.Size = new System.Drawing.Size(800, 130);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.TabStop = false;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // lblAssetNumberError
            // 
            this.lblAssetNumberError.AutoSize = true;
            this.lblAssetNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblAssetNumberError.Location = new System.Drawing.Point(487, 145);
            this.lblAssetNumberError.Name = "lblAssetNumberError";
            this.lblAssetNumberError.Size = new System.Drawing.Size(224, 25);
            this.lblAssetNumberError.TabIndex = 32;
            this.lblAssetNumberError.Text = "Asset Number Not Set";
            this.lblAssetNumberError.Visible = false;
            // 
            // lblBrandError
            // 
            this.lblBrandError.AutoSize = true;
            this.lblBrandError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandError.ForeColor = System.Drawing.Color.Red;
            this.lblBrandError.Location = new System.Drawing.Point(487, 182);
            this.lblBrandError.Name = "lblBrandError";
            this.lblBrandError.Size = new System.Drawing.Size(148, 25);
            this.lblBrandError.TabIndex = 33;
            this.lblBrandError.Text = "Model Not Set";
            this.lblBrandError.Visible = false;
            // 
            // lblModelError
            // 
            this.lblModelError.AutoSize = true;
            this.lblModelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelError.ForeColor = System.Drawing.Color.Red;
            this.lblModelError.Location = new System.Drawing.Point(487, 221);
            this.lblModelError.Name = "lblModelError";
            this.lblModelError.Size = new System.Drawing.Size(146, 25);
            this.lblModelError.TabIndex = 34;
            this.lblModelError.Text = "Brand Not Set";
            this.lblModelError.Visible = false;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.Location = new System.Drawing.Point(517, 619);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(184, 37);
            this.btnSaveAndClose.TabIndex = 8;
            this.btnSaveAndClose.Text = "Save and Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(707, 619);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSerialNumberError
            // 
            this.lblSerialNumberError.AutoSize = true;
            this.lblSerialNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblSerialNumberError.Location = new System.Drawing.Point(487, 260);
            this.lblSerialNumberError.Name = "lblSerialNumberError";
            this.lblSerialNumberError.Size = new System.Drawing.Size(225, 25);
            this.lblSerialNumberError.TabIndex = 39;
            this.lblSerialNumberError.Text = "Serial Number Not Set";
            this.lblSerialNumberError.Visible = false;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.Location = new System.Drawing.Point(11, 260);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(154, 25);
            this.lblSerialNumber.TabIndex = 37;
            this.lblSerialNumber.Text = "Serial Number:";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.Location = new System.Drawing.Point(171, 257);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(310, 31);
            this.txtSerialNumber.TabIndex = 4;
            this.txtSerialNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerialNumber_KeyUp);
            // 
            // lblAssetExistsError
            // 
            this.lblAssetExistsError.AutoSize = true;
            this.lblAssetExistsError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetExistsError.ForeColor = System.Drawing.Color.Red;
            this.lblAssetExistsError.Location = new System.Drawing.Point(487, 145);
            this.lblAssetExistsError.Name = "lblAssetExistsError";
            this.lblAssetExistsError.Size = new System.Drawing.Size(290, 25);
            this.lblAssetExistsError.TabIndex = 41;
            this.lblAssetExistsError.Text = "Asset Number Already Exists";
            this.lblAssetExistsError.Visible = false;
            // 
            // colAssetNumber
            // 
            this.colAssetNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAssetNumber.DataPropertyName = "AssetNumber";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAssetNumber.DefaultCellStyle = dataGridViewCellStyle7;
            this.colAssetNumber.HeaderText = "Asset Number";
            this.colAssetNumber.Name = "colAssetNumber";
            this.colAssetNumber.ReadOnly = true;
            // 
            // colBrand
            // 
            this.colBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBrand.DataPropertyName = "Brand";
            this.colBrand.HeaderText = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.ReadOnly = true;
            // 
            // colModel
            // 
            this.colModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colModel.DataPropertyName = "Model";
            this.colModel.HeaderText = "Model";
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSerialNumber.DataPropertyName = "Serial";
            this.colSerialNumber.HeaderText = "Serial";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.ReadOnly = true;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle8;
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "-";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 5;
            // 
            // btnSuppressDing
            // 
            this.btnSuppressDing.Location = new System.Drawing.Point(748, 316);
            this.btnSuppressDing.Name = "btnSuppressDing";
            this.btnSuppressDing.Size = new System.Drawing.Size(75, 23);
            this.btnSuppressDing.TabIndex = 42;
            this.btnSuppressDing.Text = "button1";
            this.btnSuppressDing.UseVisualStyleBackColor = true;
            this.btnSuppressDing.Visible = false;
            // 
            // BikeListEditor
            // 
            this.AcceptButton = this.btnSuppressDing;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 668);
            this.ControlBox = false;
            this.Controls.Add(this.btnSuppressDing);
            this.Controls.Add(this.lblAssetExistsError);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.lblSerialNumberError);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblModelError);
            this.Controls.Add(this.lblBrandError);
            this.Controls.Add(this.lblAssetNumberError);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvBikeList);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.txtAssetNumber);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblAssetNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BikeListEditor";
            this.ShowInTaskbar = false;
            this.Text = "Bike List Editor";
            this.Load += new System.EventHandler(this.BikeListEditor_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BikeListEditor_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBikeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssetNumber;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAssetNumber;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.DataGridView dgvBikeList;
        private System.Windows.Forms.TextBox lblInfo;
        private System.Windows.Forms.Label lblAssetNumberError;
        private System.Windows.Forms.Label lblBrandError;
        private System.Windows.Forms.Label lblModelError;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSerialNumberError;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label lblAssetExistsError;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNumber;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.Button btnSuppressDing;
    }
}