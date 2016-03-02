namespace DD_Tune_Track.Forms
{
    partial class SummerMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummerMainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlSummer = new System.Windows.Forms.TabControl();
            this.tabTuneEntry = new System.Windows.Forms.TabPage();
            this.cmbAssetNumber = new System.Windows.Forms.ComboBox();
            this.dgvTuneEntryTuneList = new System.Windows.Forms.DataGridView();
            this.colAssetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLabParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnOpenPartsSelector = new System.Windows.Forms.Button();
            this.txtLabourParts = new System.Windows.Forms.TextBox();
            this.lblLabourParts = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnSuppressDing = new System.Windows.Forms.Button();
            this.lblStaffError = new System.Windows.Forms.Label();
            this.lblTuneDateError = new System.Windows.Forms.Label();
            this.lblAssetNumberError = new System.Windows.Forms.Label();
            this.btnUpdateChargeList = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnClearRemove = new System.Windows.Forms.Button();
            this.dtpTuneDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTech = new System.Windows.Forms.ComboBox();
            this.lblTech = new System.Windows.Forms.Label();
            this.lblTuneDate = new System.Windows.Forms.Label();
            this.lblAssetNumber = new System.Windows.Forms.Label();
            this.tabChargeLists = new System.Windows.Forms.TabPage();
            this.dgvChargeListTuneList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGoToToday = new System.Windows.Forms.Button();
            this.btnGoToNextDay = new System.Windows.Forms.Button();
            this.btnGoToPrevDay = new System.Windows.Forms.Button();
            this.dtpChargeListDate = new System.Windows.Forms.DateTimePicker();
            this.lblChargeListDate = new System.Windows.Forms.Label();
            this.lblChargeStatus = new System.Windows.Forms.Label();
            this.btnCloseOut = new System.Windows.Forms.Button();
            this.txtChargeList = new System.Windows.Forms.TextBox();
            this.tabTuneStats = new System.Windows.Forms.TabPage();
            this.dgvTuneStatsChargeList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtLastTuneDateForBike = new System.Windows.Forms.TextBox();
            this.lblLastTuneDateForBike = new System.Windows.Forms.Label();
            this.cmbAssetNumberForStats = new System.Windows.Forms.ComboBox();
            this.txtTotalTunes = new System.Windows.Forms.TextBox();
            this.txtTotalTunesForBike = new System.Windows.Forms.TextBox();
            this.lblTotalTunes = new System.Windows.Forms.Label();
            this.lblSelectBike = new System.Windows.Forms.Label();
            this.lblTotalTunesForBike = new System.Windows.Forms.Label();
            this.txtAvgTunes = new System.Windows.Forms.TextBox();
            this.lblAvgTunes = new System.Windows.Forms.Label();
            this.menuStripSummer = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlSummer.SuspendLayout();
            this.tabTuneEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuneEntryTuneList)).BeginInit();
            this.tabChargeLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargeListTuneList)).BeginInit();
            this.tabTuneStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuneStatsChargeList)).BeginInit();
            this.menuStripSummer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSummer
            // 
            this.tabControlSummer.Controls.Add(this.tabTuneEntry);
            this.tabControlSummer.Controls.Add(this.tabChargeLists);
            this.tabControlSummer.Controls.Add(this.tabTuneStats);
            this.tabControlSummer.Location = new System.Drawing.Point(12, 27);
            this.tabControlSummer.Name = "tabControlSummer";
            this.tabControlSummer.SelectedIndex = 0;
            this.tabControlSummer.Size = new System.Drawing.Size(754, 639);
            this.tabControlSummer.TabIndex = 1;
            // 
            // tabTuneEntry
            // 
            this.tabTuneEntry.Controls.Add(this.cmbAssetNumber);
            this.tabTuneEntry.Controls.Add(this.dgvTuneEntryTuneList);
            this.tabTuneEntry.Controls.Add(this.btnOpenPartsSelector);
            this.tabTuneEntry.Controls.Add(this.txtLabourParts);
            this.tabTuneEntry.Controls.Add(this.lblLabourParts);
            this.tabTuneEntry.Controls.Add(this.txtNotes);
            this.tabTuneEntry.Controls.Add(this.lblNotes);
            this.tabTuneEntry.Controls.Add(this.btnSuppressDing);
            this.tabTuneEntry.Controls.Add(this.lblStaffError);
            this.tabTuneEntry.Controls.Add(this.lblTuneDateError);
            this.tabTuneEntry.Controls.Add(this.lblAssetNumberError);
            this.tabTuneEntry.Controls.Add(this.btnUpdateChargeList);
            this.tabTuneEntry.Controls.Add(this.btnAddUpdate);
            this.tabTuneEntry.Controls.Add(this.btnClearRemove);
            this.tabTuneEntry.Controls.Add(this.dtpTuneDate);
            this.tabTuneEntry.Controls.Add(this.cmbTech);
            this.tabTuneEntry.Controls.Add(this.lblTech);
            this.tabTuneEntry.Controls.Add(this.lblTuneDate);
            this.tabTuneEntry.Controls.Add(this.lblAssetNumber);
            this.tabTuneEntry.Location = new System.Drawing.Point(4, 22);
            this.tabTuneEntry.Name = "tabTuneEntry";
            this.tabTuneEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabTuneEntry.Size = new System.Drawing.Size(746, 613);
            this.tabTuneEntry.TabIndex = 0;
            this.tabTuneEntry.Text = "Bike Tune Entry";
            this.tabTuneEntry.UseVisualStyleBackColor = true;
            // 
            // cmbAssetNumber
            // 
            this.cmbAssetNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAssetNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAssetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssetNumber.FormattingEnabled = true;
            this.cmbAssetNumber.Items.AddRange(new object[] {
            "AUR16S1",
            "AUR16S2",
            "AUR16M1",
            "AUR16L1"});
            this.cmbAssetNumber.Location = new System.Drawing.Point(160, 7);
            this.cmbAssetNumber.Name = "cmbAssetNumber";
            this.cmbAssetNumber.Size = new System.Drawing.Size(310, 33);
            this.cmbAssetNumber.TabIndex = 26;
            // 
            // dgvTuneEntryTuneList
            // 
            this.dgvTuneEntryTuneList.AllowUserToAddRows = false;
            this.dgvTuneEntryTuneList.AllowUserToDeleteRows = false;
            this.dgvTuneEntryTuneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuneEntryTuneList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssetNumber,
            this.colTuneDate,
            this.colTech,
            this.colLabParts,
            this.colNotes,
            this.colRemove});
            this.dgvTuneEntryTuneList.EnableHeadersVisualStyles = false;
            this.dgvTuneEntryTuneList.Location = new System.Drawing.Point(8, 239);
            this.dgvTuneEntryTuneList.Name = "dgvTuneEntryTuneList";
            this.dgvTuneEntryTuneList.ReadOnly = true;
            this.dgvTuneEntryTuneList.RowHeadersVisible = false;
            this.dgvTuneEntryTuneList.Size = new System.Drawing.Size(732, 324);
            this.dgvTuneEntryTuneList.TabIndex = 25;
            // 
            // colAssetNumber
            // 
            this.colAssetNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAssetNumber.DefaultCellStyle = dataGridViewCellStyle19;
            this.colAssetNumber.HeaderText = "Asset Number";
            this.colAssetNumber.Name = "colAssetNumber";
            this.colAssetNumber.ReadOnly = true;
            // 
            // colTuneDate
            // 
            this.colTuneDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTuneDate.DefaultCellStyle = dataGridViewCellStyle20;
            this.colTuneDate.HeaderText = "Tune Date";
            this.colTuneDate.Name = "colTuneDate";
            this.colTuneDate.ReadOnly = true;
            // 
            // colTech
            // 
            this.colTech.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTech.HeaderText = "Tech";
            this.colTech.Name = "colTech";
            this.colTech.ReadOnly = true;
            // 
            // colLabParts
            // 
            this.colLabParts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLabParts.HeaderText = "Labour & Parts";
            this.colLabParts.Name = "colLabParts";
            this.colLabParts.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNotes.HeaderText = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle21;
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "-";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 5;
            // 
            // btnOpenPartsSelector
            // 
            this.btnOpenPartsSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPartsSelector.Location = new System.Drawing.Point(476, 118);
            this.btnOpenPartsSelector.Name = "btnOpenPartsSelector";
            this.btnOpenPartsSelector.Size = new System.Drawing.Size(100, 38);
            this.btnOpenPartsSelector.TabIndex = 24;
            this.btnOpenPartsSelector.Text = "Choose From List";
            this.btnOpenPartsSelector.UseVisualStyleBackColor = true;
            this.btnOpenPartsSelector.Click += new System.EventHandler(this.btnOpenPartsSelector_Click);
            // 
            // txtLabourParts
            // 
            this.txtLabourParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabourParts.Location = new System.Drawing.Point(160, 122);
            this.txtLabourParts.Name = "txtLabourParts";
            this.txtLabourParts.Size = new System.Drawing.Size(310, 31);
            this.txtLabourParts.TabIndex = 22;
            // 
            // lblLabourParts
            // 
            this.lblLabourParts.AutoSize = true;
            this.lblLabourParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabourParts.Location = new System.Drawing.Point(2, 123);
            this.lblLabourParts.Name = "lblLabourParts";
            this.lblLabourParts.Size = new System.Drawing.Size(153, 25);
            this.lblLabourParts.TabIndex = 23;
            this.lblLabourParts.Text = "Labour / Parts:";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(160, 159);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(310, 31);
            this.txtNotes.TabIndex = 6;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(2, 159);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(74, 25);
            this.lblNotes.TabIndex = 21;
            this.lblNotes.Text = "Notes:";
            // 
            // btnSuppressDing
            // 
            this.btnSuppressDing.Enabled = false;
            this.btnSuppressDing.Location = new System.Drawing.Point(417, 577);
            this.btnSuppressDing.Name = "btnSuppressDing";
            this.btnSuppressDing.Size = new System.Drawing.Size(75, 23);
            this.btnSuppressDing.TabIndex = 20;
            this.btnSuppressDing.TabStop = false;
            this.btnSuppressDing.Text = "button1";
            this.btnSuppressDing.UseVisualStyleBackColor = true;
            this.btnSuppressDing.Visible = false;
            // 
            // lblStaffError
            // 
            this.lblStaffError.AutoSize = true;
            this.lblStaffError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffError.ForeColor = System.Drawing.Color.Red;
            this.lblStaffError.Location = new System.Drawing.Point(476, 87);
            this.lblStaffError.Name = "lblStaffError";
            this.lblStaffError.Size = new System.Drawing.Size(217, 25);
            this.lblStaffError.TabIndex = 19;
            this.lblStaffError.Text = "Staff Member Not Set";
            this.lblStaffError.Visible = false;
            // 
            // lblTuneDateError
            // 
            this.lblTuneDateError.AutoSize = true;
            this.lblTuneDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuneDateError.ForeColor = System.Drawing.Color.Red;
            this.lblTuneDateError.Location = new System.Drawing.Point(476, 51);
            this.lblTuneDateError.Name = "lblTuneDateError";
            this.lblTuneDateError.Size = new System.Drawing.Size(189, 25);
            this.lblTuneDateError.TabIndex = 17;
            this.lblTuneDateError.Text = "Tune Date Not Set";
            this.lblTuneDateError.Visible = false;
            // 
            // lblAssetNumberError
            // 
            this.lblAssetNumberError.AutoSize = true;
            this.lblAssetNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblAssetNumberError.Location = new System.Drawing.Point(476, 15);
            this.lblAssetNumberError.Name = "lblAssetNumberError";
            this.lblAssetNumberError.Size = new System.Drawing.Size(224, 25);
            this.lblAssetNumberError.TabIndex = 15;
            this.lblAssetNumberError.Text = "Asset Number Not Set";
            this.lblAssetNumberError.Visible = false;
            // 
            // btnUpdateChargeList
            // 
            this.btnUpdateChargeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateChargeList.Location = new System.Drawing.Point(527, 569);
            this.btnUpdateChargeList.Name = "btnUpdateChargeList";
            this.btnUpdateChargeList.Size = new System.Drawing.Size(213, 38);
            this.btnUpdateChargeList.TabIndex = 9;
            this.btnUpdateChargeList.Text = "Update Charge List";
            this.btnUpdateChargeList.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.Location = new System.Drawing.Point(365, 196);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(105, 37);
            this.btnAddUpdate.TabIndex = 7;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClearRemove
            // 
            this.btnClearRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRemove.Location = new System.Drawing.Point(254, 196);
            this.btnClearRemove.Name = "btnClearRemove";
            this.btnClearRemove.Size = new System.Drawing.Size(105, 37);
            this.btnClearRemove.TabIndex = 8;
            this.btnClearRemove.Text = "Clear";
            this.btnClearRemove.UseVisualStyleBackColor = true;
            // 
            // dtpTuneDate
            // 
            this.dtpTuneDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuneDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuneDate.Location = new System.Drawing.Point(160, 46);
            this.dtpTuneDate.MaxDate = new System.DateTime(2016, 4, 30, 0, 0, 0, 0);
            this.dtpTuneDate.MinDate = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.dtpTuneDate.Name = "dtpTuneDate";
            this.dtpTuneDate.Size = new System.Drawing.Size(310, 31);
            this.dtpTuneDate.TabIndex = 3;
            // 
            // cmbTech
            // 
            this.cmbTech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTech.FormattingEnabled = true;
            this.cmbTech.Location = new System.Drawing.Point(160, 83);
            this.cmbTech.Name = "cmbTech";
            this.cmbTech.Size = new System.Drawing.Size(310, 33);
            this.cmbTech.TabIndex = 5;
            // 
            // lblTech
            // 
            this.lblTech.AutoSize = true;
            this.lblTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTech.Location = new System.Drawing.Point(2, 87);
            this.lblTech.Name = "lblTech";
            this.lblTech.Size = new System.Drawing.Size(66, 25);
            this.lblTech.TabIndex = 4;
            this.lblTech.Text = "Tech:";
            // 
            // lblTuneDate
            // 
            this.lblTuneDate.AutoSize = true;
            this.lblTuneDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuneDate.Location = new System.Drawing.Point(2, 51);
            this.lblTuneDate.Name = "lblTuneDate";
            this.lblTuneDate.Size = new System.Drawing.Size(118, 25);
            this.lblTuneDate.TabIndex = 2;
            this.lblTuneDate.Text = "Tune Date:";
            // 
            // lblAssetNumber
            // 
            this.lblAssetNumber.AutoSize = true;
            this.lblAssetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetNumber.Location = new System.Drawing.Point(3, 15);
            this.lblAssetNumber.Name = "lblAssetNumber";
            this.lblAssetNumber.Size = new System.Drawing.Size(153, 25);
            this.lblAssetNumber.TabIndex = 0;
            this.lblAssetNumber.Text = "Asset Number:";
            // 
            // tabChargeLists
            // 
            this.tabChargeLists.Controls.Add(this.dgvChargeListTuneList);
            this.tabChargeLists.Controls.Add(this.btnGoToToday);
            this.tabChargeLists.Controls.Add(this.btnGoToNextDay);
            this.tabChargeLists.Controls.Add(this.btnGoToPrevDay);
            this.tabChargeLists.Controls.Add(this.dtpChargeListDate);
            this.tabChargeLists.Controls.Add(this.lblChargeListDate);
            this.tabChargeLists.Controls.Add(this.lblChargeStatus);
            this.tabChargeLists.Controls.Add(this.btnCloseOut);
            this.tabChargeLists.Controls.Add(this.txtChargeList);
            this.tabChargeLists.Location = new System.Drawing.Point(4, 22);
            this.tabChargeLists.Name = "tabChargeLists";
            this.tabChargeLists.Padding = new System.Windows.Forms.Padding(3);
            this.tabChargeLists.Size = new System.Drawing.Size(746, 613);
            this.tabChargeLists.TabIndex = 1;
            this.tabChargeLists.Text = "Tune Charge Lists";
            this.tabChargeLists.UseVisualStyleBackColor = true;
            // 
            // dgvChargeListTuneList
            // 
            this.dgvChargeListTuneList.AllowUserToAddRows = false;
            this.dgvChargeListTuneList.AllowUserToDeleteRows = false;
            this.dgvChargeListTuneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChargeListTuneList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewButtonColumn1});
            this.dgvChargeListTuneList.EnableHeadersVisualStyles = false;
            this.dgvChargeListTuneList.Location = new System.Drawing.Point(8, 367);
            this.dgvChargeListTuneList.Name = "dgvChargeListTuneList";
            this.dgvChargeListTuneList.ReadOnly = true;
            this.dgvChargeListTuneList.RowHeadersVisible = false;
            this.dgvChargeListTuneList.Size = new System.Drawing.Size(732, 197);
            this.dgvChargeListTuneList.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn1.HeaderText = "Asset Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tune Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tech";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Labour & Parts";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "-";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 5;
            // 
            // btnGoToToday
            // 
            this.btnGoToToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToToday.Location = new System.Drawing.Point(479, 12);
            this.btnGoToToday.Name = "btnGoToToday";
            this.btnGoToToday.Size = new System.Drawing.Size(127, 31);
            this.btnGoToToday.TabIndex = 3;
            this.btnGoToToday.Text = "Today";
            this.btnGoToToday.UseVisualStyleBackColor = true;
            // 
            // btnGoToNextDay
            // 
            this.btnGoToNextDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToNextDay.Location = new System.Drawing.Point(612, 12);
            this.btnGoToNextDay.Name = "btnGoToNextDay";
            this.btnGoToNextDay.Size = new System.Drawing.Size(128, 31);
            this.btnGoToNextDay.TabIndex = 4;
            this.btnGoToNextDay.Text = "Next Day";
            this.btnGoToNextDay.UseVisualStyleBackColor = true;
            // 
            // btnGoToPrevDay
            // 
            this.btnGoToPrevDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToPrevDay.Location = new System.Drawing.Point(308, 12);
            this.btnGoToPrevDay.Name = "btnGoToPrevDay";
            this.btnGoToPrevDay.Size = new System.Drawing.Size(165, 31);
            this.btnGoToPrevDay.TabIndex = 2;
            this.btnGoToPrevDay.Text = "Previous Day";
            this.btnGoToPrevDay.UseVisualStyleBackColor = true;
            // 
            // dtpChargeListDate
            // 
            this.dtpChargeListDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChargeListDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChargeListDate.Location = new System.Drawing.Point(75, 14);
            this.dtpChargeListDate.MaxDate = new System.DateTime(2016, 4, 30, 0, 0, 0, 0);
            this.dtpChargeListDate.MinDate = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.dtpChargeListDate.Name = "dtpChargeListDate";
            this.dtpChargeListDate.Size = new System.Drawing.Size(200, 31);
            this.dtpChargeListDate.TabIndex = 1;
            this.dtpChargeListDate.Value = new System.DateTime(2015, 11, 6, 0, 0, 0, 0);
            // 
            // lblChargeListDate
            // 
            this.lblChargeListDate.AutoSize = true;
            this.lblChargeListDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargeListDate.Location = new System.Drawing.Point(8, 19);
            this.lblChargeListDate.Name = "lblChargeListDate";
            this.lblChargeListDate.Size = new System.Drawing.Size(63, 25);
            this.lblChargeListDate.TabIndex = 3;
            this.lblChargeListDate.Text = "Date:";
            // 
            // lblChargeStatus
            // 
            this.lblChargeStatus.AutoSize = true;
            this.lblChargeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargeStatus.ForeColor = System.Drawing.Color.Red;
            this.lblChargeStatus.Location = new System.Drawing.Point(3, 570);
            this.lblChargeStatus.Name = "lblChargeStatus";
            this.lblChargeStatus.Size = new System.Drawing.Size(304, 37);
            this.lblChargeStatus.TabIndex = 2;
            this.lblChargeStatus.Text = "X Not Yet Charged";
            // 
            // btnCloseOut
            // 
            this.btnCloseOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseOut.Location = new System.Drawing.Point(577, 570);
            this.btnCloseOut.Name = "btnCloseOut";
            this.btnCloseOut.Size = new System.Drawing.Size(163, 37);
            this.btnCloseOut.TabIndex = 5;
            this.btnCloseOut.Text = "Close Out";
            this.btnCloseOut.UseVisualStyleBackColor = true;
            this.btnCloseOut.Click += new System.EventHandler(this.btnCloseOut_Click);
            // 
            // txtChargeList
            // 
            this.txtChargeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChargeList.Location = new System.Drawing.Point(3, 50);
            this.txtChargeList.Multiline = true;
            this.txtChargeList.Name = "txtChargeList";
            this.txtChargeList.ReadOnly = true;
            this.txtChargeList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChargeList.Size = new System.Drawing.Size(737, 311);
            this.txtChargeList.TabIndex = 0;
            this.txtChargeList.TabStop = false;
            this.txtChargeList.Text = resources.GetString("txtChargeList.Text");
            this.txtChargeList.WordWrap = false;
            // 
            // tabTuneStats
            // 
            this.tabTuneStats.Controls.Add(this.dgvTuneStatsChargeList);
            this.tabTuneStats.Controls.Add(this.txtLastTuneDateForBike);
            this.tabTuneStats.Controls.Add(this.lblLastTuneDateForBike);
            this.tabTuneStats.Controls.Add(this.cmbAssetNumberForStats);
            this.tabTuneStats.Controls.Add(this.txtTotalTunes);
            this.tabTuneStats.Controls.Add(this.txtTotalTunesForBike);
            this.tabTuneStats.Controls.Add(this.lblTotalTunes);
            this.tabTuneStats.Controls.Add(this.lblSelectBike);
            this.tabTuneStats.Controls.Add(this.lblTotalTunesForBike);
            this.tabTuneStats.Controls.Add(this.txtAvgTunes);
            this.tabTuneStats.Controls.Add(this.lblAvgTunes);
            this.tabTuneStats.Location = new System.Drawing.Point(4, 22);
            this.tabTuneStats.Name = "tabTuneStats";
            this.tabTuneStats.Size = new System.Drawing.Size(746, 613);
            this.tabTuneStats.TabIndex = 2;
            this.tabTuneStats.Text = "Tuning Stats";
            this.tabTuneStats.UseVisualStyleBackColor = true;
            // 
            // dgvTuneStatsChargeList
            // 
            this.dgvTuneStatsChargeList.AllowUserToAddRows = false;
            this.dgvTuneStatsChargeList.AllowUserToDeleteRows = false;
            this.dgvTuneStatsChargeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewButtonColumn2});
            this.dgvTuneStatsChargeList.EnableHeadersVisualStyles = false;
            this.dgvTuneStatsChargeList.Location = new System.Drawing.Point(8, 202);
            this.dgvTuneStatsChargeList.Name = "dgvTuneStatsChargeList";
            this.dgvTuneStatsChargeList.ReadOnly = true;
            this.dgvTuneStatsChargeList.RowHeadersVisible = false;
            this.dgvTuneStatsChargeList.Size = new System.Drawing.Size(732, 396);
            this.dgvTuneStatsChargeList.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn6.HeaderText = "Asset Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn7.HeaderText = "Tune Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Tech";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "Labour & Parts";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "-";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 5;
            // 
            // txtLastTuneDateForBike
            // 
            this.txtLastTuneDateForBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastTuneDateForBike.Location = new System.Drawing.Point(301, 165);
            this.txtLastTuneDateForBike.Name = "txtLastTuneDateForBike";
            this.txtLastTuneDateForBike.ReadOnly = true;
            this.txtLastTuneDateForBike.Size = new System.Drawing.Size(310, 31);
            this.txtLastTuneDateForBike.TabIndex = 37;
            // 
            // lblLastTuneDateForBike
            // 
            this.lblLastTuneDateForBike.AutoSize = true;
            this.lblLastTuneDateForBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastTuneDateForBike.Location = new System.Drawing.Point(3, 168);
            this.lblLastTuneDateForBike.Name = "lblLastTuneDateForBike";
            this.lblLastTuneDateForBike.Size = new System.Drawing.Size(177, 25);
            this.lblLastTuneDateForBike.TabIndex = 38;
            this.lblLastTuneDateForBike.Text = "Date Last Tuned:";
            // 
            // cmbAssetNumberForStats
            // 
            this.cmbAssetNumberForStats.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAssetNumberForStats.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAssetNumberForStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssetNumberForStats.FormattingEnabled = true;
            this.cmbAssetNumberForStats.Items.AddRange(new object[] {
            "AUR16S1",
            "AUR16S2",
            "AUR16M1",
            "AUR16L1"});
            this.cmbAssetNumberForStats.Location = new System.Drawing.Point(301, 89);
            this.cmbAssetNumberForStats.Name = "cmbAssetNumberForStats";
            this.cmbAssetNumberForStats.Size = new System.Drawing.Size(310, 33);
            this.cmbAssetNumberForStats.TabIndex = 3;
            // 
            // txtTotalTunes
            // 
            this.txtTotalTunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTunes.Location = new System.Drawing.Point(301, 52);
            this.txtTotalTunes.Name = "txtTotalTunes";
            this.txtTotalTunes.ReadOnly = true;
            this.txtTotalTunes.Size = new System.Drawing.Size(310, 31);
            this.txtTotalTunes.TabIndex = 28;
            // 
            // txtTotalTunesForBike
            // 
            this.txtTotalTunesForBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTunesForBike.Location = new System.Drawing.Point(301, 128);
            this.txtTotalTunesForBike.Name = "txtTotalTunesForBike";
            this.txtTotalTunesForBike.ReadOnly = true;
            this.txtTotalTunesForBike.Size = new System.Drawing.Size(310, 31);
            this.txtTotalTunesForBike.TabIndex = 33;
            // 
            // lblTotalTunes
            // 
            this.lblTotalTunes.AutoSize = true;
            this.lblTotalTunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTunes.Location = new System.Drawing.Point(3, 55);
            this.lblTotalTunes.Name = "lblTotalTunes";
            this.lblTotalTunes.Size = new System.Drawing.Size(214, 25);
            this.lblTotalTunes.TabIndex = 29;
            this.lblTotalTunes.Text = "Total Tunes To Date:";
            // 
            // lblSelectBike
            // 
            this.lblSelectBike.AutoSize = true;
            this.lblSelectBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectBike.Location = new System.Drawing.Point(3, 92);
            this.lblSelectBike.Name = "lblSelectBike";
            this.lblSelectBike.Size = new System.Drawing.Size(126, 25);
            this.lblSelectBike.TabIndex = 4;
            this.lblSelectBike.Text = "Select Bike:";
            // 
            // lblTotalTunesForBike
            // 
            this.lblTotalTunesForBike.AutoSize = true;
            this.lblTotalTunesForBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTunesForBike.Location = new System.Drawing.Point(3, 131);
            this.lblTotalTunesForBike.Name = "lblTotalTunesForBike";
            this.lblTotalTunesForBike.Size = new System.Drawing.Size(241, 25);
            this.lblTotalTunesForBike.TabIndex = 34;
            this.lblTotalTunesForBike.Text = "Total Number Of Tunes:";
            // 
            // txtAvgTunes
            // 
            this.txtAvgTunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgTunes.Location = new System.Drawing.Point(301, 15);
            this.txtAvgTunes.Name = "txtAvgTunes";
            this.txtAvgTunes.ReadOnly = true;
            this.txtAvgTunes.Size = new System.Drawing.Size(310, 31);
            this.txtAvgTunes.TabIndex = 24;
            // 
            // lblAvgTunes
            // 
            this.lblAvgTunes.AutoSize = true;
            this.lblAvgTunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgTunes.Location = new System.Drawing.Point(3, 18);
            this.lblAvgTunes.Name = "lblAvgTunes";
            this.lblAvgTunes.Size = new System.Drawing.Size(247, 25);
            this.lblAvgTunes.TabIndex = 25;
            this.lblAvgTunes.Text = "Average Tunes Per Day:";
            // 
            // menuStripSummer
            // 
            this.menuStripSummer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripSummer.Location = new System.Drawing.Point(0, 0);
            this.menuStripSummer.Name = "menuStripSummer";
            this.menuStripSummer.Size = new System.Drawing.Size(771, 24);
            this.menuStripSummer.TabIndex = 2;
            this.menuStripSummer.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.maintenanceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // SummerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 676);
            this.Controls.Add(this.menuStripSummer);
            this.Controls.Add(this.tabControlSummer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SummerMainForm";
            this.Text = "Double Diamond Tune Track - Summer";
            this.tabControlSummer.ResumeLayout(false);
            this.tabTuneEntry.ResumeLayout(false);
            this.tabTuneEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuneEntryTuneList)).EndInit();
            this.tabChargeLists.ResumeLayout(false);
            this.tabChargeLists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargeListTuneList)).EndInit();
            this.tabTuneStats.ResumeLayout(false);
            this.tabTuneStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuneStatsChargeList)).EndInit();
            this.menuStripSummer.ResumeLayout(false);
            this.menuStripSummer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvgTunes;
        private System.Windows.Forms.TextBox txtAvgTunes;
        private System.Windows.Forms.Label lblTotalTunes;
        private System.Windows.Forms.TextBox txtTotalTunes;
        private System.Windows.Forms.Label lblTotalTunesForBike;
        private System.Windows.Forms.Label lblSelectBike;
        private System.Windows.Forms.TextBox txtTotalTunesForBike;
        private System.Windows.Forms.ComboBox cmbAssetNumberForStats;
        private System.Windows.Forms.Label lblLastTuneDateForBike;
        private System.Windows.Forms.TextBox txtLastTuneDateForBike;
        private System.Windows.Forms.TabPage tabTuneStats;
        private System.Windows.Forms.TextBox txtChargeList;
        private System.Windows.Forms.Button btnCloseOut;
        private System.Windows.Forms.Label lblChargeStatus;
        private System.Windows.Forms.Label lblChargeListDate;
        private System.Windows.Forms.DateTimePicker dtpChargeListDate;
        private System.Windows.Forms.Button btnGoToPrevDay;
        private System.Windows.Forms.Button btnGoToNextDay;
        private System.Windows.Forms.Button btnGoToToday;
        private System.Windows.Forms.TabPage tabChargeLists;
        private System.Windows.Forms.Label lblAssetNumber;
        private System.Windows.Forms.Label lblTuneDate;
        private System.Windows.Forms.Label lblTech;
        private System.Windows.Forms.ComboBox cmbTech;
        private System.Windows.Forms.DateTimePicker dtpTuneDate;
        private System.Windows.Forms.Button btnClearRemove;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnUpdateChargeList;
        private System.Windows.Forms.Label lblAssetNumberError;
        private System.Windows.Forms.Label lblTuneDateError;
        private System.Windows.Forms.Label lblStaffError;
        private System.Windows.Forms.Button btnSuppressDing;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblLabourParts;
        private System.Windows.Forms.TextBox txtLabourParts;
        private System.Windows.Forms.Button btnOpenPartsSelector;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLabParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuneDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetNumber;
        private System.Windows.Forms.DataGridView dgvTuneEntryTuneList;
        private System.Windows.Forms.ComboBox cmbAssetNumber;
        private System.Windows.Forms.TabPage tabTuneEntry;
        private System.Windows.Forms.TabControl tabControlSummer;
        private System.Windows.Forms.DataGridView dgvChargeListTuneList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridView dgvTuneStatsChargeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.MenuStrip menuStripSummer;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}