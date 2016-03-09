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
    public partial class TechListEditor : Form
    {
        #region Attributes

        // Application object
        private TuneTrackApplication mAppObj = Program.appObject;

        // Tech list
        BindingList<Tech> mTechList = null; 

        // Tech name max length
        private const int mTechNameMaxLength = 3;

        #endregion

        #region Methods

        public TechListEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialises the Tech List Editor form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TechListEditor_Load(object sender, EventArgs e)
        {
            // Set focus to tech input text box
            this.ActiveControl = txtTechName; 

            // Set maximum length property of tech input box
            txtTechName.MaxLength = mTechNameMaxLength;

            // Make sure error label is hidden
            lblTechInitialError.Visible = false;

            // Initialise the tech list by creating a copy of the existing tech list in the application object
            mTechList = new BindingList<Tech>(mAppObj.Techs.ConvertAll(tech => new Tech(tech)));

            // Set list box data source
            lstTechs.DataSource = mTechList;
            lstTechs.DisplayMember = "Name"; 
        }

        /// <summary>
        /// Adds a tech to the tech list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewTech();
        }

        /// <summary>
        /// Adds a new tech when Return is pressed on the tech entry texxt box. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTechName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AddNewTech(); 
            }
        }

        /// <summary>
        /// Adds a tech to the list
        /// </summary>
        private void AddNewTech()
        {
            // Reset error labels
            lblTechInitialError.Visible = false;
            lblDuplicateTechError.Visible = false;

            // Validate input
            // Check for empty string input
            if (txtTechName.Text == string.Empty)
            {
                lblTechInitialError.Visible = true;
                return;
            }

            // Check for duplicate name input
            foreach (Tech tech in mTechList)
            {
                if (tech.Name.Equals(txtTechName.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    lblDuplicateTechError.Visible = true;
                    return; 
                }
            }

            // Create a new tech
            mTechList.Add(new Tech(txtTechName.Text));

            // Clear input
            txtTechName.Text = string.Empty;

            // Reset bindings
            lstTechs.DataSource = mTechList;
        }

        /// <summary>
        /// Saves the updated tech list back to the Tune Track Application Object
        /// </summary>
        private void SaveAndClose()
        {
            // Apply the updated list to the application object
            mAppObj.Techs = new List<Tech>(mTechList);

            // Close the form
            this.Close(); 
        }

        /// <summary>
        /// Closes the tech list editor without saving any changes
        /// </summary>
        private void Cancel()
        {
            // Nothing to save. Just unload the form. 
            this.Close(); 
        }

        /// <summary>
        /// Saves the updated tech list and closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAndClose(); 
        }

        /// <summary>
        /// Closes the tech list editor without saving any changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel(); 
        }

        private void lstTechs_KeyUp(object sender, KeyEventArgs e)
        {
            // !!!! Implement delete key to delete item from list box? !!!!
        }

        #endregion
    }
}
