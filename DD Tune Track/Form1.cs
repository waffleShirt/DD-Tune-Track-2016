using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DD_Tune_Track
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.SummerMainForm smf = new Forms.SummerMainForm();
            smf.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.WinterMainForm wmf = new Forms.WinterMainForm();
            wmf.Show(); 
        }

        private void btnShowTechEditForm_Click(object sender, EventArgs e)
        {
            Forms.TechListEditor tle = new Forms.TechListEditor();
            tle.ShowDialog(this);  
        }

        private void btnShowBikeListEditor_Click(object sender, EventArgs e)
        {
            Forms.BikeListEditor ble = new Forms.BikeListEditor();
            ble.ShowDialog(this); 
        }
    }
}
