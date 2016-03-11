using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DD_Tune_Track.Source; 

namespace DD_Tune_Track.Forms
{
    public partial class BikeListEditor : Form
    {
        #region Attributes

        private enum InputMode
        {
            INPUT_MODE_NEW_BIKE, 
            INPUT_MODE_EDIT_BIKE,
        };

        // Application object
        private TuneTrackApplication mAppObj = Program.appObject;

        // Character limits
        private const int mAssetNumberMaxLength = 10;
        private const int mBrandMaxLength = 20;
        private const int mModelMaxLength = 20;
        private const int mSerialMaxLength = 20;

        // Bike list
        private List<Bike> mBikeList = null;

        // Bike List Binding Source
        private BindingSource mBikeListBindingSource = null;

        // Reference to bike being edited
        private Bike mBikeToEdit = null;

        // DGV selection edit control flag
        private bool mAllowSelectionChange = false;

        // Mode
        private InputMode mMode = InputMode.INPUT_MODE_NEW_BIKE;

        #endregion

        //==============================================================================
        //==============================================================================

        #region Methods

        public BikeListEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load event. Performs some initialisation work
        /// on the form controls, makes a copy of the bike list
        /// from the application object and sets up the data 
        /// bindings to show all existing bikes in the data
        /// grid view. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BikeListEditor_Load(object sender, EventArgs e)
        {
            // Set focus to asset number input box
            this.ActiveControl = txtAssetNumber;

            // Set character limits
            txtAssetNumber.MaxLength = mAssetNumberMaxLength;
            cmbBrand.MaxLength = mBrandMaxLength;
            cmbModel.MaxLength = mModelMaxLength;
            txtSerialNumber.MaxLength = mSerialMaxLength;
            HideErrorLabels();

            // Create a copy of the existing bike list in the application object
            mBikeList = new List<Bike>(mAppObj.BikeList).ConvertAll(bike => new Bike(bike));

            // Setup data bindings
            mBikeListBindingSource = new BindingSource();
            mBikeListBindingSource.DataSource = mBikeList;

            dgvBikeList.AutoGenerateColumns = false;
            dgvBikeList.DataSource = mBikeListBindingSource;

            // Deselect rows
            dgvBikeList.ClearSelection(); 

            // Populate combo box items
            PopulateBrandComboBox();
            PopulateModelComboBox();

            // Form has finished loading. We can now allow selection changes in the DGV. 
            mAllowSelectionChange = true; 

        }

        /// <summary>
        /// Hides all error labels in the form.
        /// </summary>
        private void HideErrorLabels()
        {
            // Hide all error labels
            lblAssetNumberError.Visible = false;
            lblAssetExistsError.Visible = false;
            lblBrandError.Visible = false;
            lblModelError.Visible = false;
            lblSerialNumberError.Visible = false;
        }

        /// <summary>
        /// Clears all input fields in the form. 
        /// </summary>
        private void ClearInputFields()
        {
            txtAssetNumber.Text = string.Empty;
            cmbBrand.SelectedIndex = -1;
            cmbModel.SelectedIndex = -1;
            cmbBrand.Text = string.Empty;
            cmbModel.Text = string.Empty; 
            txtSerialNumber.Text = string.Empty; 
        }

        /// <summary>
        /// Validates all the input fields to ensure data is correct. 
        /// </summary>
        /// <returns>True if data passes validation, otherwise false.</returns>
        private bool ValidateInput()
        {
            HideErrorLabels(); 

            if (txtAssetNumber.Text == string.Empty)
            {
                lblAssetNumberError.Visible = true;
                return false; 
            }

            // Check for duplicate asset number if we are adding a new bike
            if (mMode == InputMode.INPUT_MODE_NEW_BIKE)
            {
                foreach (Bike b in mBikeList)
                {
                    if (txtAssetNumber.Text.Equals(b.AssetNumber, StringComparison.InvariantCultureIgnoreCase))
                    {
                        lblAssetExistsError.Visible = true;
                        return false;
                    }
                }
            }

            if (cmbBrand.Text == string.Empty)
            {
                lblBrandError.Visible = true;
                return false; 
            }

            if (cmbModel.Text == string.Empty)
            {
                lblModelError.Visible = true;
                return false; 
            }

            if (txtSerialNumber.Text == string.Empty)
            {
                lblSerialNumberError.Visible = true;
                return false; 
            }

            return true; 
        }

        /// <summary>
        /// Adds a new bike to the bike list. 
        /// </summary>
        private void AddBikeToBikeList()
        {
            if (ValidateInput())
            {
                UpdateBrandComboBoxItems();
                UpdateModelComboBoxItems();

                // Add new bike to list
                Bike b = new Bike(txtAssetNumber.Text, cmbBrand.SelectedItem.ToString(), cmbModel.SelectedItem.ToString(), txtSerialNumber.Text);
                mBikeList.Add(b);

                /*
                Updating the bindings will add a new row to the DGV. 
                This will fire the onSelectionChanged event and this
                will force the form into Edit mode, which we don't 
                want to happen. We briefly unsubscribe the event handler,
                update the bindings, and then subscribe to it again. 
                */
                ResetBindingsWithSuppressOnSelectionChanged(); 
            }
        }

        /// <summary>
        /// Updates the bike currently selected in the datagridview. 
        /// </summary>
        /// <returns>True if update succeeded. False if it failed due to data validation failure.</returns>
        private bool UpdateExistingBike()
        {
            if (ValidateInput())
            {
                UpdateBrandComboBoxItems();
                UpdateModelComboBoxItems();

                // Update bike that is being edited
                mBikeToEdit.AssetNumber = txtAssetNumber.Text;
                mBikeToEdit.Brand = cmbBrand.SelectedItem.ToString();
                mBikeToEdit.Model = cmbModel.SelectedItem.ToString();
                mBikeToEdit.Serial = txtSerialNumber.Text;

                /*
                Update data bindings
                Note that updating an existing bike will not change 
                the number of rows in the DataGridView so no 
                OnSelectionChanged event is raised. This means there
                is no need to perform an unsubscribe/subscribe around
                the binding reset. 
                */
                mBikeListBindingSource.ResetBindings(false);

                // Update was successful 
                return true; 
            }

            // Update failed. 
            return false; 
        }

        /// <summary>
        /// Loads details for a bike selected in the data 
        /// grid view back into the form controls. 
        /// </summary>
        private void LoadBikeForEditing()
        {
            // Check what row was selected
            int rowIdx = GetSelectedBikeRowIndex();

            // Get asset number of bike
            string assetNum = dgvBikeList.Rows[rowIdx].Cells["colAssetNumber"].Value.ToString();

            // Find this bike in the bike list
            bool bikeFound = false;
            for (int i = 0; i < mBikeList.Count; ++i)
            {
                if (mBikeList[i].AssetNumber == assetNum)
                {
                    mBikeToEdit = mBikeList[i];
                    bikeFound = true;
                    break;
                }
            }

            // Bike couldn't be found in the list for some reason
            if (!bikeFound)
            {
                throw new Exception("Bike in datagridview could not be found in bike list.");
            }

            // Load the bike for editing
            txtAssetNumber.Text = mBikeToEdit.AssetNumber;
            cmbBrand.SelectedIndex = cmbBrand.Items.IndexOf(mBikeToEdit.Brand);
            cmbModel.SelectedIndex = cmbModel.Items.IndexOf(mBikeToEdit.Model);
            txtSerialNumber.Text = mBikeToEdit.Serial;
        }

        /// <summary>
        /// Removes a bike from the bike list. 
        /// </summary>
        /// <param name="bikeDGVRowIndex">Row index of bike in data grid view</param>
        private void RemoveBikeAt(int bikeDGVRowIndex)
        {
            /* 
            Remove row from datagridview. Note that to do this we
            actually remove the associated Bike object from the bike
            list and then update the data source bindings. As we may
            at some point enable column sorting or for some reason have
            bikes shown in the datagridview in a different order to 
            what they appear in the underlying list we must look
            up the bike in the list rather than just use the row index
            as an index into the bike list to remove a bike. The lookup
            is performed on the asset number as it must be unique. 
            */
            for (int i = 0; i < mBikeList.Count; ++i)
            {
                DataGridViewRow row = dgvBikeList.Rows[bikeDGVRowIndex];

                if (mBikeList[i].AssetNumber == row.Cells["colAssetNumber"].Value.ToString())
                {
                    // Found the matching bike. Remove it. 
                    mBikeList.RemoveAt(i);
                    break;
                }
            }

            /*
            Updating the bindings will select a new row to the DGV. 
            This will fire the onSelectionChanged event and this
            will force the form into Edit mode, which we don't 
            want to happen. We briefly unsubscribe the event handler,
            update the bindings, and then subscribe to it again. 
            */
            ResetBindingsWithSuppressOnSelectionChanged();
        }

        /// <summary>
        /// Resets the data bindings for the Dat Grid View. The call
        /// to reset the bindings is wrapped by calls that will 
        /// unsubscribe the OnSelectionChange from the Data Grid View
        /// and then re-subscribe after updating the bindings. This will
        /// suppress the OnSelectionChanged event that can cause problems
        /// with a bike in the DGV getting loaded for editing without the
        /// user actually selecting a row in the DGV. 
        /// </summary>
        private void ResetBindingsWithSuppressOnSelectionChanged()
        {
            this.dgvBikeList.SelectionChanged -= this.dgvBikeList_SelectionChanged;

            // Update data bindings
            mBikeListBindingSource.ResetBindings(false);

            // Subscribe
            this.dgvBikeList.SelectionChanged += this.dgvBikeList_SelectionChanged;
        }

        /// <summary>
        /// Scans the existing list of bikes and extracts the 
        /// unique brand names and adds them as items to the
        /// brand combo box. 
        /// </summary>
        private void PopulateBrandComboBox()
        {
            foreach (Bike b in mBikeList)
            {
                bool matchFound = false; 
                foreach (String brand in cmbBrand.Items)
                {
                    if (b.Brand.Equals(brand))
                    {
                        matchFound = true; 
                    }
                }

                if (!matchFound)
                {
                    cmbBrand.Items.Add(b.Brand);
                }
            }
        }

        /// <summary>
        /// Scans the existing list of bikes and extracts the 
        /// unique model names and adds them as items to the
        /// model combo box. 
        /// </summary>
        private void PopulateModelComboBox()
        {
            foreach (Bike b in mBikeList)
            {
                bool matchFound = false;
                foreach (String model in cmbModel.Items)
                {
                    if (b.Model.Equals(model))
                    {
                        matchFound = true;
                    }
                }

                if (!matchFound)
                {
                    cmbModel.Items.Add(b.Model);
                }
            }
        }

        /// <summary>
        /// Updates the items in the Brand combo box. 
        /// If a new brand has been entered as text then
        /// it is added as an item and set as the selected
        /// index. 
        /// </summary>
        private void UpdateBrandComboBoxItems()
        {
            int selectedIndex = cmbBrand.SelectedIndex;

            if (selectedIndex == -1)
            {
                // No index slected. Probably a new brand was entered
                string brand = cmbBrand.Text;

                // Insert item and make it the selected index
                cmbBrand.SelectedIndex = cmbBrand.Items.Add(brand);
            }
        }

        /// <summary>
        /// Updates the items in the Model combo box. 
        /// If a new model has been entered as text then
        /// it is added as an item and set as the selected
        /// index. 
        /// </summary>
        private void UpdateModelComboBoxItems()
        {
            int selectedIndex = cmbModel.SelectedIndex;

            if (selectedIndex == -1)
            {
                // No index slected. Probably a new brand was entered
                string model = cmbModel.Text;

                // Insert item and make it the selected index
                cmbModel.SelectedIndex = cmbModel.Items.Add(model);
            }
        }

        /// <summary>
        /// Gets the row index of the bike currently selected
        /// in the Data Grid View. 
        /// </summary>
        /// <returns>Positive integer if a bike is selected. -1 if no bike is selected.</returns>
        private int GetSelectedBikeRowIndex()
        {
            /*
            Multi select is disabled on the DGV. So we know 
            we'll only have one row selected. 
            */
            if (dgvBikeList.SelectedRows.Count > 0)
            {
                return dgvBikeList.SelectedRows[0].Index; 
            }
            else
            {
                // No rows selected. 
                return -1; 
            }
        }

        /// <summary>
        /// Changes form controls to allow entering a 
        /// new bike into the datagridview. 
        /// </summary>
        private void EnableNewBikeMode()
        {
            mMode = InputMode.INPUT_MODE_NEW_BIKE;
            txtAssetNumber.Enabled = true;  
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnClear.Enabled = true;
            mBikeToEdit = null;
            this.ActiveControl = txtAssetNumber; 
            HideErrorLabels();
            ClearInputFields();
            dgvBikeList.ClearSelection(); 
        }

        /// <summary>
        /// Changes form controls to allow editing
        /// an exiting bike in the datagridview
        /// </summary>
        private void EnableEditBikeMode()
        {
            mMode = InputMode.INPUT_MODE_EDIT_BIKE;
            txtAssetNumber.Enabled = false; 
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnClear.Enabled = false;
            HideErrorLabels();
            ClearInputFields();
        }

        /// <summary>
        /// Saves the updated bike list back to the Tune Track Application Object
        /// </summary>
        private void SaveAndClose()
        {
            // Apply the updated list to the application object
            mAppObj.BikeList = new List<Bike>(mBikeList);

            // Close the form
            this.Close();
        }

        /// <summary>
        /// Closes the bike list editor without saving any changes
        /// </summary>
        private void Cancel()
        {
            // Nothing to save. Just unload the form. 
            this.Close();
        }

        #endregion

        //==============================================================================
        //==============================================================================

        #region Button and Event Handlers

        /// <summary>
        /// Adds a new bike to the bike list. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBikeToBikeList();
            EnableNewBikeMode(); 
        }

        /// <summary>
        /// Updates an existing bike in the data grid view. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update bike
            if (UpdateExistingBike())
            {
                // Return to new bike mode if the update succeeded 
                EnableNewBikeMode();
            }
        }

        /// <summary>
        /// SelectionChanged event handler for data grid view. 
        /// If a row has been selected the bike in it is added
        /// loaded into the entry fields for editing. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBikeList_SelectionChanged(object sender, EventArgs e)
        {
            if (mAllowSelectionChange)
            {
                if (GetSelectedBikeRowIndex() >= 0)
                {
                    EnableEditBikeMode();
                    LoadBikeForEditing();
                }
                else
                {
                    // No row selected. Reset to new bike mode. 
                    EnableNewBikeMode();
                }
            }
        }

        /// <summary>
        /// Clears all input data and error lebels in the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            ClearInputFields();
        }

        /// <summary>
        /// Handles pressing the [-] button on any row in the bike list data grid view. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBikeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            // We have to make sure the RowIndex >= 0 as a value less than 0 would be the header row 
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                RemoveBikeAt(e.RowIndex);
                EnableNewBikeMode(); 
            }
        }

        /// <summary>
        /// Adds a new bike to the bike list on pressing Return
        /// in the serial number input field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSerialNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (mMode == InputMode.INPUT_MODE_NEW_BIKE)
                {
                    AddBikeToBikeList();
                    EnableNewBikeMode();
                }
                else
                {
                    if (UpdateExistingBike())
                    {
                        // Only enable new bike mode if update succeeded. 
                        EnableNewBikeMode(); 
                    }
                }                
            }
        }

        /// <summary>
        /// On mouse up on the bike datagridview perform a hit
        /// test and if blank space is clicked then deselect
        /// all items in the grid view. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBikeList_MouseUp(object sender, MouseEventArgs e)
        {
            // Test if user clicked away from all the rows within the DataGridView. 
            // If they did, then unselect any selected row. 
            if (e.Button == MouseButtons.Left)
            {
                if (dgvBikeList.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
                {
                    EnableNewBikeMode();
                }
            }
        }

        /// <summary>
        /// On mouse up on the form perform a hit
        /// test and if blank space is clicked then 
        /// deselect all items in the grid view. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BikeListEditor_MouseUp(object sender, MouseEventArgs e)
        {
            // Test if user clicked on the form while an item was selected in the DGV. 
            // If one was, clear the selection
            if (e.Button == MouseButtons.Left)
            {
                dgvBikeList.ClearSelection();
            }
        }

        /// <summary>
        /// Saves the updated bike list back to the Tune Track Application Object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            SaveAndClose();
        }

        /// <summary>
        /// Closes the bike list editor without saving any changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        #endregion
    }
}
