using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdaterDotNET.Wizard
{
    /// <summary>
    /// 
    /// </summary>
    public partial class frmWizard : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public frmWizard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Keeps track of current page
        /// </summary>
        public int Page { get; set; } = 1;

        private void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            if (Page == 6)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Page == 1){ return; }
            
            Page--;
            if (Page <= 5)
            {
                btnNext.Enabled = false;
            }
        }
       

    }
}
