namespace DD_Tune_Track.Forms
{
    partial class TechListEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechListEditor));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTechInitials = new System.Windows.Forms.Label();
            this.txtTechName = new System.Windows.Forms.TextBox();
            this.lblTechs = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTechInitialError = new System.Windows.Forms.Label();
            this.lstTechs = new System.Windows.Forms.ListBox();
            this.btnSuppressDing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 38);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 38);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTechInitials
            // 
            this.lblTechInitials.AutoSize = true;
            this.lblTechInitials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechInitials.Location = new System.Drawing.Point(9, 9);
            this.lblTechInitials.Name = "lblTechInitials";
            this.lblTechInitials.Size = new System.Drawing.Size(97, 20);
            this.lblTechInitials.TabIndex = 20;
            this.lblTechInitials.Text = "Tech Initials:";
            // 
            // txtTechName
            // 
            this.txtTechName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechName.Location = new System.Drawing.Point(109, 6);
            this.txtTechName.Name = "txtTechName";
            this.txtTechName.Size = new System.Drawing.Size(101, 26);
            this.txtTechName.TabIndex = 21;
            this.txtTechName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTechName_KeyUp);
            // 
            // lblTechs
            // 
            this.lblTechs.AutoSize = true;
            this.lblTechs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechs.Location = new System.Drawing.Point(9, 67);
            this.lblTechs.Name = "lblTechs";
            this.lblTechs.Size = new System.Drawing.Size(216, 20);
            this.lblTechs.TabIndex = 22;
            this.lblTechs.Text = "Techs for the current season:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 26);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTechInitialError
            // 
            this.lblTechInitialError.AutoSize = true;
            this.lblTechInitialError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechInitialError.ForeColor = System.Drawing.Color.Red;
            this.lblTechInitialError.Location = new System.Drawing.Point(9, 36);
            this.lblTechInitialError.Name = "lblTechInitialError";
            this.lblTechInitialError.Size = new System.Drawing.Size(174, 20);
            this.lblTechInitialError.TabIndex = 24;
            this.lblTechInitialError.Text = "No tech initials entered!";
            this.lblTechInitialError.Visible = false;
            // 
            // lstTechs
            // 
            this.lstTechs.FormattingEnabled = true;
            this.lstTechs.Location = new System.Drawing.Point(12, 90);
            this.lstTechs.Name = "lstTechs";
            this.lstTechs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTechs.Size = new System.Drawing.Size(283, 147);
            this.lstTechs.TabIndex = 25;
            this.lstTechs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstTechs_KeyUp);
            // 
            // btnSuppressDing
            // 
            this.btnSuppressDing.Location = new System.Drawing.Point(257, 52);
            this.btnSuppressDing.Name = "btnSuppressDing";
            this.btnSuppressDing.Size = new System.Drawing.Size(75, 23);
            this.btnSuppressDing.TabIndex = 26;
            this.btnSuppressDing.Text = "btnSuppressDing";
            this.btnSuppressDing.UseVisualStyleBackColor = true;
            this.btnSuppressDing.Visible = false;
            // 
            // TechListEditor
            // 
            this.AcceptButton = this.btnSuppressDing;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 291);
            this.ControlBox = false;
            this.Controls.Add(this.btnSuppressDing);
            this.Controls.Add(this.lstTechs);
            this.Controls.Add(this.lblTechInitialError);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTechs);
            this.Controls.Add(this.txtTechName);
            this.Controls.Add(this.lblTechInitials);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TechListEditor";
            this.ShowInTaskbar = false;
            this.Text = "Tech List Editor";
            this.Load += new System.EventHandler(this.TechListEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTechInitials;
        private System.Windows.Forms.TextBox txtTechName;
        private System.Windows.Forms.Label lblTechs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTechInitialError;
        private System.Windows.Forms.ListBox lstTechs;
        private System.Windows.Forms.Button btnSuppressDing;
    }
}