using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DD_Tune_Track.Forms
{
    public partial class WinterMainForm : Form
    {
        public WinterMainForm()
        {
            InitializeComponent();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.MaintenanceWinter wm = new MaintenanceWinter();
            wm.ShowDialog(this); 
        }
    }
}
