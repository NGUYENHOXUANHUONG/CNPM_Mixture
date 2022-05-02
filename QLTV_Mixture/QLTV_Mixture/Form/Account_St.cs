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
    public partial class Account_St : Form
    {
        public Account_St()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            ChangePass ct = new ChangePass();
            if (activeForm != null)
                activeForm.Close();
            activeForm = ct;
            ct.TopLevel = false;
            ct.FormBorderStyle = FormBorderStyle.None;
            ct.Dock = DockStyle.Fill;
            panel1.Controls.Add(ct);
            panel1.Tag = ct;
            ct.BringToFront();
            //ct.ButtonClicked += new EventHandler(ob_ButtonClicked);
            ct.Show();
        }
    }
}
