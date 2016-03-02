namespace DD_Tune_Track.Forms
{
    partial class TuneTypeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuneTypeEditor));
            this.lblTuneType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTuneType = new System.Windows.Forms.TextBox();
            this.dgvInventoryList = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.TextBox();
            this.lblTuneTypeError = new System.Windows.Forms.Label();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colTuneType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTuneType
            // 
            this.lblTuneType.AutoSize = true;
            this.lblTuneType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuneType.Location = new System.Drawing.Point(12, 69);
            this.lblTuneType.Name = "lblTuneType";
            this.lblTuneType.Size = new System.Drawing.Size(121, 25);
            this.lblTuneType.TabIndex = 22;
            this.lblTuneType.Text = "Tune Type:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(349, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 37);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(238, 103);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 37);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtTuneType
            // 
            this.txtTuneType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuneType.Location = new System.Drawing.Point(144, 66);
            this.txtTuneType.Name = "txtTuneType";
            this.txtTuneType.Size = new System.Drawing.Size(310, 31);
            this.txtTuneType.TabIndex = 27;
            // 
            // dgvInventoryList
            // 
            this.dgvInventoryList.AllowUserToAddRows = false;
            this.dgvInventoryList.AllowUserToDeleteRows = false;
            this.dgvInventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTuneType,
            this.colRemove});
            this.dgvInventoryList.EnableHeadersVisualStyles = false;
            this.dgvInventoryList.Location = new System.Drawing.Point(12, 146);
            this.dgvInventoryList.Name = "dgvInventoryList";
            this.dgvInventoryList.ReadOnly = true;
            this.dgvInventoryList.RowHeadersVisible = false;
            this.dgvInventoryList.Size = new System.Drawing.Size(631, 323);
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
            this.lblInfo.Size = new System.Drawing.Size(638, 48);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.TabStop = false;
            this.lblInfo.Text = "Please enter the different tune types for winter. Any tune types entered here wil" +
    "l be automatically present next season. \r\n";
            // 
            // lblTuneTypeError
            // 
            this.lblTuneTypeError.AutoSize = true;
            this.lblTuneTypeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuneTypeError.ForeColor = System.Drawing.Color.Red;
            this.lblTuneTypeError.Location = new System.Drawing.Point(460, 69);
            this.lblTuneTypeError.Name = "lblTuneTypeError";
            this.lblTuneTypeError.Size = new System.Drawing.Size(192, 25);
            this.lblTuneTypeError.TabIndex = 32;
            this.lblTuneTypeError.Text = "Tune Type Not Set";
            this.lblTuneTypeError.Visible = false;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.Location = new System.Drawing.Point(348, 475);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(184, 37);
            this.btnSaveAndClose.TabIndex = 36;
            this.btnSaveAndClose.Text = "Save and Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(538, 475);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // colTuneType
            // 
            this.colTuneType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTuneType.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTuneType.HeaderText = "Tune Type";
            this.colTuneType.Name = "colTuneType";
            this.colTuneType.ReadOnly = true;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "-";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 5;
            // 
            // TuneTypeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 520);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTuneTypeError);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvInventoryList);
            this.Controls.Add(this.txtTuneType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTuneType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TuneTypeEditor";
            this.ShowInTaskbar = false;
            this.Text = "Tune Type Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuneType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTuneType;
        private System.Windows.Forms.DataGridView dgvInventoryList;
        private System.Windows.Forms.TextBox lblInfo;
        private System.Windows.Forms.Label lblTuneTypeError;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuneType;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
    }
}