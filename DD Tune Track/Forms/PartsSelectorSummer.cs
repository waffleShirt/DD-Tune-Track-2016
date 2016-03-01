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
    public partial class PartsSelectorSummer : Form
    {
        public PartsSelectorSummer()
        {
            InitializeComponent();

            this.dgvPartsListForBike.Rows.Add("#RT", "Rental Tune", "$14.50", "1");
            this.dgvPartsListForBike.Rows.Add("#1016", "SRAM Guide Pads", "$27.00", "2");
            this.dgvPartsListForBike.Rows.Add("#199", "Shift Cable", "$4.00", "1");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
