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
        BindingSource mBikeListBindingSource = null; 

        #endregion

        #region Methods

        public BikeListEditor()
        {
            InitializeComponent();
        }

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

            foreach (Bike b in mBikeList)
            {
                if (txtAssetNumber.Text.Equals(b.AssetNumber, StringComparison.InvariantCultureIgnoreCase))
                {
                    lblAssetExistsError.Visible = true;
                    return false; 
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBikeToBikeList();
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

                ClearInputFields();

                // Move focus back to asset number
                this.ActiveControl = txtAssetNumber;

                // Update data bindings
                mBikeListBindingSource.ResetBindings(false);
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
                    DataGridViewRow row = senderGrid.Rows[e.RowIndex]; 

                    if (mBikeList[i].AssetNumber == row.Cells["colAssetNumber"].Value.ToString())
                    {
                        // Found the matching bike. Remove it. 
                        mBikeList.RemoveAt(i);
                        break; 
                    }
                }

                // Update data source bindings
                mBikeListBindingSource.ResetBindings(false); 
            }
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
        /// Adds a new bike to the bike list on pressing Return
        /// in the serial number input field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSerialNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AddBikeToBikeList(); 
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
            // If they did, then unselect anys elected row. 
            if (e.Button == MouseButtons.Left)
            {
                if (dgvBikeList.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None)
                {
                    dgvBikeList.ClearSelection();
                }
            }
        }

        #endregion

        private void BikeListEditor_MouseUp(object sender, MouseEventArgs e)
        {
            // Test if user clicked on the form while an item was selected in the DGV. 
            // If one was, clear the selection
            if (e.Button == MouseButtons.Left)
            {
                //if (mMode == Mode.Mode_UpdateTune)
                {
                    dgvBikeList.ClearSelection(); 
                }
            }
        }
    }
}
