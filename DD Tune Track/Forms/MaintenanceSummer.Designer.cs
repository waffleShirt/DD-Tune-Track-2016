namespace DD_Tune_Track.Forms
{
    partial class MaintenanceSummer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceSummer));
            this.lblCurrOpMode = new System.Windows.Forms.Label();
            this.btnBeginSeson = new System.Windows.Forms.Button();
            this.btnEndSeason = new System.Windows.Forms.Button();
            this.btnSwitchSeason = new System.Windows.Forms.Button();
            this.lblTechList = new System.Windows.Forms.Label();
            this.btnEditTechList = new System.Windows.Forms.Button();
            this.lblInventory = new System.Windows.Forms.Label();
            this.btnEditBikeList = new System.Windows.Forms.Button();
            this.btnEditInventory = new System.Windows.Forms.Button();
            this.lblBikeList = new System.Windows.Forms.Label();
            this.bntOpenSpreadsheetLocation = new System.Windows.Forms.Button();
            this.lblTuneSpreadsheet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrOpMode
            // 
            this.lblCurrOpMode.AutoSize = true;
            this.lblCurrOpMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrOpMode.Location = new System.Drawing.Point(12, 9);
            this.lblCurrOpMode.Name = "lblCurrOpMode";
            this.lblCurrOpMode.Size = new System.Drawing.Size(334, 25);
            this.lblCurrOpMode.TabIndex = 1;
            this.lblCurrOpMode.Text = "Current Operating Mode: Summer";
            this.lblCurrOpMode.Click += new System.EventHandler(this.lblAssetNumber_Click);
            // 
            // btnBeginSeson
            // 
            this.btnBeginSeson.Location = new System.Drawing.Point(54, 239);
            this.btnBeginSeson.Name = "btnBeginSeson";
            this.btnBeginSeson.Size = new System.Drawing.Size(153, 38);
            this.btnBeginSeson.TabIndex = 17;
            this.btnBeginSeson.Text = "Begin Season";
            this.btnBeginSeson.UseVisualStyleBackColor = true;
            // 
            // btnEndSeason
            // 
            this.btnEndSeason.Location = new System.Drawing.Point(213, 239);
            this.btnEndSeason.Name = "btnEndSeason";
            this.btnEndSeason.Size = new System.Drawing.Size(153, 38);
            this.btnEndSeason.TabIndex = 18;
            this.btnEndSeason.Text = "End Season";
            this.btnEndSeason.UseVisualStyleBackColor = true;
            // 
            // btnSwitchSeason
            // 
            this.btnSwitchSeason.Location = new System.Drawing.Point(372, 239);
            this.btnSwitchSeason.Name = "btnSwitchSeason";
            this.btnSwitchSeason.Size = new System.Drawing.Size(153, 38);
            this.btnSwitchSeason.TabIndex = 19;
            this.btnSwitchSeason.Text = "Switch Season";
            this.btnSwitchSeason.UseVisualStyleBackColor = true;
            // 
            // lblTechList
            // 
            this.lblTechList.AutoSize = true;
            this.lblTechList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechList.Location = new System.Drawing.Point(101, 54);
            this.lblTechList.Name = "lblTechList";
            this.lblTechList.Size = new System.Drawing.Size(106, 25);
            this.lblTechList.TabIndex = 21;
            this.lblTechList.Text = "Tech List:";
            // 
            // btnEditTechList
            // 
            this.btnEditTechList.Location = new System.Drawing.Point(213, 50);
            this.btnEditTechList.Name = "btnEditTechList";
            this.btnEditTechList.Size = new System.Drawing.Size(153, 38);
            this.btnEditTechList.TabIndex = 23;
            this.btnEditTechList.Text = "Edit Tech List";
            this.btnEditTechList.UseVisualStyleBackColor = true;
            this.btnEditTechList.Click += new System.EventHandler(this.btnEditTechList_Click);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(101, 141);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(106, 25);
            this.lblInventory.TabIndex = 13;
            this.lblInventory.Text = "Inventory:";
            // 
            // btnEditBikeList
            // 
            this.btnEditBikeList.Location = new System.Drawing.Point(213, 94);
            this.btnEditBikeList.Name = "btnEditBikeList";
            this.btnEditBikeList.Size = new System.Drawing.Size(153, 38);
            this.btnEditBikeList.TabIndex = 27;
            this.btnEditBikeList.Text = "Edit Bike List";
            this.btnEditBikeList.UseVisualStyleBackColor = true;
            this.btnEditBikeList.Click += new System.EventHandler(this.btnEditBikeList_Click);
            // 
            // btnEditInventory
            // 
            this.btnEditInventory.Location = new System.Drawing.Point(213, 137);
            this.btnEditInventory.Name = "btnEditInventory";
            this.btnEditInventory.Size = new System.Drawing.Size(153, 38);
            this.btnEditInventory.TabIndex = 16;
            this.btnEditInventory.Text = "Edit Inventory";
            this.btnEditInventory.UseVisualStyleBackColor = true;
            this.btnEditInventory.Click += new System.EventHandler(this.btnEditInventory_Click);
            // 
            // lblBikeList
            // 
            this.lblBikeList.AutoSize = true;
            this.lblBikeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeList.Location = new System.Drawing.Point(107, 98);
            this.lblBikeList.Name = "lblBikeList";
            this.lblBikeList.Size = new System.Drawing.Size(100, 25);
            this.lblBikeList.TabIndex = 11;
            this.lblBikeList.Text = "Bike List:";
            // 
            // bntOpenSpreadsheetLocation
            // 
            this.bntOpenSpreadsheetLocation.Location = new System.Drawing.Point(213, 181);
            this.bntOpenSpreadsheetLocation.Name = "bntOpenSpreadsheetLocation";
            this.bntOpenSpreadsheetLocation.Size = new System.Drawing.Size(153, 38);
            this.bntOpenSpreadsheetLocation.TabIndex = 29;
            this.bntOpenSpreadsheetLocation.Text = "Open Spreadsheet Location";
            this.bntOpenSpreadsheetLocation.UseVisualStyleBackColor = true;
            // 
            // lblTuneSpreadsheet
            // 
            this.lblTuneSpreadsheet.AutoSize = true;
            this.lblTuneSpreadsheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuneSpreadsheet.Location = new System.Drawing.Point(12, 185);
            this.lblTuneSpreadsheet.Name = "lblTuneSpreadsheet";
            this.lblTuneSpreadsheet.Size = new System.Drawing.Size(195, 25);
            this.lblTuneSpreadsheet.TabIndex = 30;
            this.lblTuneSpreadsheet.Text = "Tune Spreadsheet:";
            // 
            // MaintenanceSummer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 287);
            this.Controls.Add(this.lblTuneSpreadsheet);
            this.Controls.Add(this.bntOpenSpreadsheetLocation);
            this.Controls.Add(this.lblBikeList);
            this.Controls.Add(this.btnEditInventory);
            this.Controls.Add(this.btnEditBikeList);
            this.Controls.Add(this.lblTechList);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.btnEditTechList);
            this.Controls.Add(this.btnSwitchSeason);
            this.Controls.Add(this.btnEndSeason);
            this.Controls.Add(this.btnBeginSeson);
            this.Controls.Add(this.lblCurrOpMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaintenanceSummer";
            this.ShowInTaskbar = false;
            this.Text = "Double Diamond Tune Track - Summer Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrOpMode;
        private System.Windows.Forms.Button btnBeginSeson;
        private System.Windows.Forms.Button btnEndSeason;
        private System.Windows.Forms.Button btnSwitchSeason;
        private System.Windows.Forms.Label lblTechList;
        private System.Windows.Forms.Button btnEditTechList;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Button btnEditBikeList;
        private System.Windows.Forms.Button btnEditInventory;
        private System.Windows.Forms.Label lblBikeList;
        private System.Windows.Forms.Button bntOpenSpreadsheetLocation;
        private System.Windows.Forms.Label lblTuneSpreadsheet;
    }
}