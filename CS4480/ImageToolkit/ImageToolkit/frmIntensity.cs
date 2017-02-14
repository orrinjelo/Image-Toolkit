using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToolkit
{
    public partial class frmIntensity : Form
    {
        public frmIntensity()
        {
            InitializeComponent();
        }


        private void reportIntensity(object sender, EventArgs e)
        {
            this.Hide();
            OperationsMathSimple.ChangeIntensity((float)this.intensityUD.Value);
        }
    }
}
