namespace DD_Tune_Track.Forms
{
    partial class WinterMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinterMainForm));
            this.tabControlWinter = new System.Windows.Forms.TabControl();
            this.tabTuneEntry = new System.Windows.Forms.TabPage();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblTuneTypeError = new System.Windows.Forms.Label();
            this.cmbTuneType = new System.Windows.Forms.ComboBox();
            this.lblTuneType = new System.Windows.Forms.Label();
            this.dgvTuneEntryTuneList = new System.Windows.Forms.DataGridView();
            this.colAssetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuneType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.btnSuppressDing = new System.Windows.Forms.Button();
            this.lblTechError = new System.Windows.Forms.Label();
            this.lblTuneDateError = new System.Windows.Forms.Label();
            this.lblAssetNumberError = new System.Windows.Forms.Label();
            this.btnUpdateChargeList = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnClearRemove = new System.Windows.Forms.Button();
            this.dtpTuneDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTech = new System.Windows.Forms.ComboBox();
            this.txtAssetNumber = new System.Windows.Forms.TextBox();
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
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtTotalTunes = new System.Windows.Forms.TextBox();
            this.lblTotalTunes = new System.Windows.Forms.Label();
            this.txtAvgTunes = new System.Windows.Forms.TextBox();
            this.lblAvgTunes = new System.Windows.Forms.Label();
            this.menuStripWinter = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlWinter.SuspendLayout();
            this.tabTuneEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuneEntryTuneList)).BeginInit();
            this.tabChargeLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargeListTuneList)).BeginInit();
            this.tabTuneStats.SuspendLayout();
            this.menuStripWinter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlWinter
            // 
            this.tabControlWinter.Controls.Add(this.tabTuneEntry);
            this.tabControlWinter.Controls.Add(this.tabChargeLists);
            this.tabControlWinter.Controls.Add(this.tabTuneStats);
            this.tabControlWinter.Location = new System.Drawing.Point(12, 27);
            this.tabControlWinter.Name = "tabControlWinter";
            this.tabControlWinter.SelectedIndex = 0;
            this.tabControlWinter.Size = new System.Drawing.Size(754, 637);
            this.tabControlWinter.TabIndex = 1;
            // 
            // tabTuneEntry
            // 
            this.tabTuneEntry.Controls.Add(this.txtNotes);
            this.tabTuneEntry.Controls.Add(this.lblNotes);
            this.tabTuneEntry.Controls.Add(this.lblTuneTypeError);
            this.tabTuneEntry.Controls.Add(this.cmbTuneType);
            this.tabTuneEntry.Controls.Add(this.lblTuneType);
            this.tabTuneEntry.Controls.Add(this.dgvTuneEntryTuneList);
            this.tabTuneEntry.Controls.Add(this.txtParts);
            this.tabTuneEntry.Controls.Add(this.lblParts);
            this.tabTuneEntry.Controls.Add(this.btnSuppressDing);
            this.tabTuneEntry.Controls.Add(this.lblTechError);
            this.tabTuneEntry.Controls.Add(this.lblTuneDateError);
            this.tabTuneEntry.Controls.Add(this.lblAssetNumberError);
            this.tabTuneEntry.Controls.Add(this.btnUpdateChargeList);
            this.tabTuneEntry.Controls.Add(this.btnAddUpdate);
            this.tabTuneEntry.Controls.Add(this.btnClearRemove);
            this.tabTuneEntry.Controls.Add(this.dtpTuneDate);
            this.tabTuneEntry.Controls.Add(this.cmbTech);
            this.tabTuneEntry.Controls.Add(this.txtAssetNumber);
            this.tabTuneEntry.Controls.Add(this.lblTech);
            this.tabTuneEntry.Controls.Add(this.lblTuneDate);
            this.tabTuneEntry.Controls.Add(this.lblAssetNumber);
            this.tabTuneEntry.Location = new System.Drawing.Point(4, 22);
            this.tabTuneEntry.Name = "tabTuneEntry";
            this.tabTuneEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabTuneEntry.Size = new System.Drawing.Size(746, 611);
            this.tabTuneEntry.TabIndex = 0;
            this.tabTuneEntry.Text = "Ski/Board Tune Entry";
            this.tabTuneEntry.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(160, 198);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(310, 31);
            this.txtNotes.TabIndex = 29;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(80, 201);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(74, 25);
            this.lblNotes.TabIndex = 30;
            this.lblNotes.Text = "Notes:";
            // 
            // lblTuneTypeError
            // 
            this.lblTuneTypeError.AutoSize = true;
            this.lblTuneTypeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuneTypeError.ForeColor = System.Drawing.Color.Red;
            this.lblTuneTypeError.Location = new System.Drawing.Point(477, 49);
            this.lblTuneTypeError.Name = "lblTuneTypeError";
            this.lblTuneTypeError.Size = new System.Drawing.Size(192, 25);
            this.lblTuneTypeError.TabIndex = 28;
            this.lblTuneTypeError.Text = "Tune Type Not Set";
            this.lblTuneTypeError.Visible = false;
            // 
            // cmbTuneType
            // 
            this.cmbTuneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTuneType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTuneType.FormattingEnabled = true;
            this.cmbTuneType.Items.AddRange(new object[] {
            "Rentals Performance Tune"});
            this.cmbTuneType.Location = new System.Drawing.Point(161, 46);
            this.cmbTuneType.Name = "cmbTuneType";
            this.cmbTuneType.Size = new System.Drawing.Size(310, 33);
            this.cmbTuneType.TabIndex = 27;
            // 
            // lblTuneType
            // 
            this.lblTuneType.AutoSize = true;
            this.lblTuneType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuneType.Location = new System.Drawing.Point(33, 49);
            this.lblTuneType.Name = "lblTuneType";
            this.lblTuneType.Size = new System.Drawing.Size(121, 25);
            this.lblTuneType.TabIndex = 26;
            this.lblTuneType.Text = "Tune Type:";
            // 
            // dgvTuneEntryTuneList
            // 
            this.dgvTuneEntryTuneList.AllowUserToAddRows = false;
            this.dgvTuneEntryTuneList.AllowUserToDeleteRows = false;
            this.dgvTuneEntryTuneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuneEntryTuneList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssetNumber,
            this.colTuneType,
            this.colTuneDate,
            this.colTech,
            this.colParts,
            this.colNotes,
            this.colRemove});
            this.dgvTuneEntryTuneList.EnableHeadersVisualStyles = false;
            this.dgvTuneEntryTuneList.Location = new System.Drawing.Point(8, 278);
            this.dgvTuneEntryTuneList.Name = "dgvTuneEntryTuneList";
            this.dgvTuneEntryTuneList.ReadOnly = true;
            this.dgvTuneEntryTuneList.RowHeadersVisible = false;
            this.dgvTuneEntryTuneList.Size = new System.Drawing.Size(732, 283);
            this.dgvTuneEntryTuneList.TabIndex = 25;
            // 
            // colAssetNumber
            // 
            this.colAssetNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAssetNumber.DefaultCellStyle = dataGridViewCellStyle7;
            this.colAssetNumber.HeaderText = "Asset Number";
            this.colAssetNumber.Name = "colAssetNumber";
            this.colAssetNumber.ReadOnly = true;
            // 
            // colTuneType
            // 
            this.colTuneType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTuneType.HeaderText = "Tune Type";
            this.colTuneType.Name = "colTuneType";
            this.colTuneType.ReadOnly = true;
            // 
            // colTuneDate
            // 
            this.colTuneDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTuneDate.DefaultCellStyle = dataGridViewCellStyle8;
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
            // colParts
            // 
            this.colParts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colParts.HeaderText = "Parts";
            this.colParts.Name = "colParts";
            this.colParts.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle9;
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "-";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 5;
            // 
            // txtParts
            // 
            this.txtParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParts.Location = new System.Drawing.Point(160, 161);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(310, 31);
            this.txtParts.TabIndex = 22;
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(86, 164);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(68, 25);
            this.lblParts.TabIndex = 23;
            this.lblParts.Text = "Parts:";
            // 
            // btnSuppressDing
            // 
            this.btnSuppressDing.Enabled = false;
            this.btnSuppressDing.Location = new System.Drawing.Point(417, 575);
            this.btnSuppressDing.Name = "btnSuppressDing";
            this.btnSuppressDing.Size = new System.Drawing.Size(75, 23);
            this.btnSuppressDing.TabIndex = 20;
            this.btnSuppressDing.TabStop = false;
            this.btnSuppressDing.Text = "button1";
            this.btnSuppressDing.UseVisualStyleBackColor = true;
            this.btnSuppressDing.Visible = false;
            // 
            // lblTechError
            // 
            this.lblTechError.AutoSize = true;
            this.lblTechError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechError.ForeColor = System.Drawing.Color.Red;
            this.lblTechError.Location = new System.Drawing.Point(477, 123);
            this.lblTechError.Name = "lblTechError";
            this.lblTechError.Size = new System.Drawing.Size(137, 25);
            this.lblTechError.TabIndex = 19;
            this.lblTechError.Text = "Tech Not Set";
            this.lblTechError.Visible = false;
            // 
            // lblTuneDateError
            // 
            this.lblTuneDateError.AutoSize = true;
            this.lblTuneDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuneDateError.ForeColor = System.Drawing.Color.Red;
            this.lblTuneDateError.Location = new System.Drawing.Point(477, 86);
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
            this.lblAssetNumberError.Location = new System.Drawing.Point(477, 12);
            this.lblAssetNumberError.Name = "lblAssetNumberError";
            this.lblAssetNumberError.Size = new System.Drawing.Size(224, 25);
            this.lblAssetNumberError.TabIndex = 15;
            this.lblAssetNumberError.Text = "Asset Number Not Set";
            this.lblAssetNumberError.Visible = false;
            // 
            // btnUpdateChargeList
            // 
            this.btnUpdateChargeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateChargeList.Location = new System.Drawing.Point(525, 567);
            this.btnUpdateChargeList.Name = "btnUpdateChargeList";
            this.btnUpdateChargeList.Size = new System.Drawing.Size(215, 38);
            this.btnUpdateChargeList.TabIndex = 9;
            this.btnUpdateChargeList.Text = "Update Charge List";
            this.btnUpdateChargeList.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.Location = new System.Drawing.Point(367, 235);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(105, 37);
            this.btnAddUpdate.TabIndex = 7;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClearRemove
            // 
            this.btnClearRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRemove.Location = new System.Drawing.Point(256, 235);
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
            this.dtpTuneDate.Location = new System.Drawing.Point(161, 85);
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
            this.cmbTech.Items.AddRange(new object[] {
            "TB"});
            this.cmbTech.Location = new System.Drawing.Point(161, 122);
            this.cmbTech.Name = "cmbTech";
            this.cmbTech.Size = new System.Drawing.Size(310, 33);
            this.cmbTech.TabIndex = 5;
            // 
            // txtAssetNumber
            // 
            this.txtAssetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetNumber.Location = new System.Drawing.Point(162, 9);
            this.txtAssetNumber.Name = "txtAssetNumber";
            this.txtAssetNumber.Size = new System.Drawing.Size(310, 31);
            this.txtAssetNumber.TabIndex = 1;
            // 
            // lblTech
            // 
            this.lblTech.AutoSize = true;
            this.lblTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTech.Location = new System.Drawing.Point(88, 125);
            this.lblTech.Name = "lblTech";
            this.lblTech.Size = new System.Drawing.Size(66, 25);
            this.lblTech.TabIndex = 4;
            this.lblTech.Text = "Tech:";
            // 
            // lblTuneDate
            // 
            this.lblTuneDate.AutoSize = true;
            this.lblTuneDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuneDate.Location = new System.Drawing.Point(37, 90);
            this.lblTuneDate.Name = "lblTuneDate";
            this.lblTuneDate.Size = new System.Drawing.Size(118, 25);
            this.lblTuneDate.TabIndex = 2;
            this.lblTuneDate.Text = "Tune Date:";
            // 
            // lblAssetNumber
            // 
            this.lblAssetNumber.AutoSize = true;
            this.lblAssetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetNumber.Location = new System.Drawing.Point(3, 12);
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
            this.tabChargeLists.Size = new System.Drawing.Size(746, 611);
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
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn1});
            this.dgvChargeListTuneList.EnableHeadersVisualStyles = false;
            this.dgvChargeListTuneList.Location = new System.Drawing.Point(6, 367);
            this.dgvChargeListTuneList.Name = "dgvChargeListTuneList";
            this.dgvChargeListTuneList.ReadOnly = true;
            this.dgvChargeListTuneList.RowHeadersVisible = false;
            this.dgvChargeListTuneList.Size = new System.Drawing.Size(732, 197);
            this.dgvChargeListTuneList.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn1.HeaderText = "Asset Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tune Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tune Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tech";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Parts";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.btnGoToNextDay.Location = new System.Drawing.Point(612, 13);
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
            this.txtChargeList.WordWrap = false;
            // 
            // tabTuneStats
            // 
            this.tabTuneStats.Controls.Add(this.txtTotalTunes);
            this.tabTuneStats.Controls.Add(this.lblTotalTunes);
            this.tabTuneStats.Controls.Add(this.txtAvgTunes);
            this.tabTuneStats.Controls.Add(this.lblAvgTunes);
            this.tabTuneStats.Location = new System.Drawing.Point(4, 22);
            this.tabTuneStats.Name = "tabTuneStats";
            this.tabTuneStats.Size = new System.Drawing.Size(746, 611);
            this.tabTuneStats.TabIndex = 2;
            this.tabTuneStats.Text = "Tuning Stats";
            this.tabTuneStats.UseVisualStyleBackColor = true;
            // 
            // txtTotalTunes
            // 
            this.txtTotalTunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTunes.Location = new System.Drawing.Point(301, 51);
            this.txtTotalTunes.Name = "txtTotalTunes";
            this.txtTotalTunes.ReadOnly = true;
            this.txtTotalTunes.Size = new System.Drawing.Size(310, 31);
            this.txtTotalTunes.TabIndex = 28;
            // 
            // lblTotalTunes
            // 
            this.lblTotalTunes.AutoSize = true;
            this.lblTotalTunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTunes.Location = new System.Drawing.Point(3, 54);
            this.lblTotalTunes.Name = "lblTotalTunes";
            this.lblTotalTunes.Size = new System.Drawing.Size(214, 25);
            this.lblTotalTunes.TabIndex = 29;
            this.lblTotalTunes.Text = "Total Tunes To Date:";
            // 
            // txtAvgTunes
            // 
            this.txtAvgTunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgTunes.Location = new System.Drawing.Point(301, 14);
            this.txtAvgTunes.Name = "txtAvgTunes";
            this.txtAvgTunes.ReadOnly = true;
            this.txtAvgTunes.Size = new System.Drawing.Size(310, 31);
            this.txtAvgTunes.TabIndex = 24;
            // 
            // lblAvgTunes
            // 
            this.lblAvgTunes.AutoSize = true;
            this.lblAvgTunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgTunes.Location = new System.Drawing.Point(3, 17);
            this.lblAvgTunes.Name = "lblAvgTunes";
            this.lblAvgTunes.Size = new System.Drawing.Size(247, 25);
            this.lblAvgTunes.TabIndex = 25;
            this.lblAvgTunes.Text = "Average Tunes Per Day:";
            // 
            // menuStripWinter
            // 
            this.menuStripWinter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripWinter.Location = new System.Drawing.Point(0, 0);
            this.menuStripWinter.Name = "menuStripWinter";
            this.menuStripWinter.Size = new System.Drawing.Size(771, 24);
            this.menuStripWinter.TabIndex = 2;
            this.menuStripWinter.Text = "menuStrip1";
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
            // WinterMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 676);
            this.Controls.Add(this.menuStripWinter);
            this.Controls.Add(this.tabControlWinter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinterMainForm";
            this.Text = "Double Diamond Tune Track - Winter";
            this.tabControlWinter.ResumeLayout(false);
            this.tabTuneEntry.ResumeLayout(false);
            this.tabTuneEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuneEntryTuneList)).EndInit();
            this.tabChargeLists.ResumeLayout(false);
            this.tabChargeLists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargeListTuneList)).EndInit();
            this.tabTuneStats.ResumeLayout(false);
            this.tabTuneStats.PerformLayout();
            this.menuStripWinter.ResumeLayout(false);
            this.menuStripWinter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlWinter;
        private System.Windows.Forms.TabPage tabTuneEntry;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblTuneTypeError;
        private System.Windows.Forms.ComboBox cmbTuneType;
        private System.Windows.Forms.Label lblTuneType;
        private System.Windows.Forms.DataGridView dgvTuneEntryTuneList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuneType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuneDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Button btnSuppressDing;
        private System.Windows.Forms.Label lblTechError;
        private System.Windows.Forms.Label lblTuneDateError;
        private System.Windows.Forms.Label lblAssetNumberError;
        private System.Windows.Forms.Button btnUpdateChargeList;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnClearRemove;
        private System.Windows.Forms.DateTimePicker dtpTuneDate;
        private System.Windows.Forms.ComboBox cmbTech;
        private System.Windows.Forms.TextBox txtAssetNumber;
        private System.Windows.Forms.Label lblTech;
        private System.Windows.Forms.Label lblTuneDate;
        private System.Windows.Forms.Label lblAssetNumber;
        private System.Windows.Forms.TabPage tabChargeLists;
        private System.Windows.Forms.Button btnGoToToday;
        private System.Windows.Forms.Button btnGoToNextDay;
        private System.Windows.Forms.Button btnGoToPrevDay;
        private System.Windows.Forms.DateTimePicker dtpChargeListDate;
        private System.Windows.Forms.Label lblChargeListDate;
        private System.Windows.Forms.Label lblChargeStatus;
        private System.Windows.Forms.Button btnCloseOut;
        private System.Windows.Forms.TextBox txtChargeList;
        private System.Windows.Forms.TabPage tabTuneStats;
        private System.Windows.Forms.TextBox txtTotalTunes;
        private System.Windows.Forms.Label lblTotalTunes;
        private System.Windows.Forms.TextBox txtAvgTunes;
        private System.Windows.Forms.Label lblAvgTunes;
        private System.Windows.Forms.MenuStrip menuStripWinter;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvChargeListTuneList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}