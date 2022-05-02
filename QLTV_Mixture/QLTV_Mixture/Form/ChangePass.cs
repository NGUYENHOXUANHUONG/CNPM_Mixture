using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_Mixture
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonClicked;

        public void NotifyButtonClicked(EventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);
        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            NotifyButtonClicked(e);
            this.Close();
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            NotifyButtonClicked(e);
            this.Close();
        }
    }
}
