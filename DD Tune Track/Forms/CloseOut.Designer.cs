namespace DD_Tune_Track.Forms
{
    partial class CloseOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseOut));
            this.lblInfo = new System.Windows.Forms.TextBox();
            this.btnCloseOut = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbCloseOutTech = new System.Windows.Forms.ComboBox();
            this.lblChargedBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(14, 18);
            this.lblInfo.Multiline = true;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.ReadOnly = true;
            this.lblInfo.Size = new System.Drawing.Size(581, 71);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.TabStop = false;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnCloseOut
            // 
            this.btnCloseOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseOut.Location = new System.Drawing.Point(123, 159);
            this.btnCloseOut.Name = "btnCloseOut";
            this.btnCloseOut.Size = new System.Drawing.Size(178, 33);
            this.btnCloseOut.TabIndex = 1;
            this.btnCloseOut.Text = "Close Out";
            this.btnCloseOut.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(307, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbCloseOutTech
            // 
            this.cmbCloseOutTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCloseOutTech.FormattingEnabled = true;
            this.cmbCloseOutTech.Items.AddRange(new object[] {
            "RG",
            "TB",
            "SM",
            "NL"});
            this.cmbCloseOutTech.Location = new System.Drawing.Point(356, 107);
            this.cmbCloseOutTech.Name = "cmbCloseOutTech";
            this.cmbCloseOutTech.Size = new System.Drawing.Size(189, 33);
            this.cmbCloseOutTech.TabIndex = 3;
            // 
            // lblChargedBy
            // 
            this.lblChargedBy.AutoSize = true;
            this.lblChargedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargedBy.Location = new System.Drawing.Point(64, 110);
            this.lblChargedBy.Name = "lblChargedBy";
            this.lblChargedBy.Size = new System.Drawing.Size(286, 25);
            this.lblChargedBy.TabIndex = 4;
            this.lblChargedBy.Text = "Charged and Closed Out By:";
            this.lblChargedBy.Click += new System.EventHandler(this.label1_Click);
            // 
            // CloseOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 213);
            this.Controls.Add(this.lblChargedBy);
            this.Controls.Add(this.cmbCloseOutTech);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCloseOut);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CloseOut";
            this.ShowInTaskbar = false;
            this.Text = "Close Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblInfo;
        private System.Windows.Forms.Button btnCloseOut;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbCloseOutTech;
        private System.Windows.Forms.Label lblChargedBy;
    }
}