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
    public partial class MaintenanceWinter : Form
    {
        public MaintenanceWinter()
        {
            InitializeComponent();
        }

        private void btnEditTechList_Click(object sender, EventArgs e)
        {
            Forms.TechListEditor tle = new TechListEditor();
            tle.ShowDialog(this); 
        }

        private void btnEditTuneTypes_Click(object sender, EventArgs e)
        {
            Forms.TuneTypeEditor tte = new TuneTypeEditor();
            tte.ShowDialog(this); 
        }
    }
}
