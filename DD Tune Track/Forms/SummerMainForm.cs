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
    public partial class SummerMainForm : Form
    {
        public SummerMainForm()
        {
            InitializeComponent();
        }

        private void btnOpenPartsSelector_Click(object sender, EventArgs e)
        {
            Forms.PartsSelectorSummer pss = new PartsSelectorSummer();
            pss.ShowDialog(this); 
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.MaintenanceSummer ms = new MaintenanceSummer();
            ms.ShowDialog(this); 
        }
    }
}
