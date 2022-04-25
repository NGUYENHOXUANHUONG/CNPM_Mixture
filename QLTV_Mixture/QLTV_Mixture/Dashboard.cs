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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            guna2ShadowForm.SetShadowForm(this);
            
        }
        
        private Form activeForm = null;
        public void OpenFrm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.Main());
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.LookUp());
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.Borrow());
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.Book());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.Account());
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.Extend());
        }
    }
}
