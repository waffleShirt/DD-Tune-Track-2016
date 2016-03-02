using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DD_Tune_Track.Forms
{
    public partial class MaintenanceSummer : Form
    {
        public MaintenanceSummer()
        {
            InitializeComponent();
        }

        private void lblAssetNumber_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditTechList_Click(object sender, EventArgs e)
        {
            Forms.TechListEditor tl = new TechListEditor();
            tl.ShowDialog(this); 
        }

        private void btnEditBikeList_Click(object sender, EventArgs e)
        {
            Forms.BikeListEditor ble = new BikeListEditor();
            ble.ShowDialog(this); 
        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            Forms.InventoryEditor ie = new InventoryEditor();
            ie.ShowDialog(this); 
        }
    }
}
