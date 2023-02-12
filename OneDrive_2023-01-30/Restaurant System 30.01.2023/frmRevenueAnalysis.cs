using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarant_System
{
    public partial class frmRevenueAnalysis : Form
    {

        public frmRevenueAnalysis()
        {
            InitializeComponent();
        }
   

        private void frmRevenueAnalysis_Load(object sender, EventArgs e)
        {
            pictureBoxRevenueAnalysis.SizeMode = PictureBoxSizeMode.Zoom;
        }

    }
}
