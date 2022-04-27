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

            //hiển thị chức vụ khi load vào form
            lbName.Text = LoginFrm.UserName;
            if (LoginFrm.UserType == 1)
            {
                lbCv.Text = "Thủ thư";
            }
            else
            {
                lbCv.Text = "Sinh viên";
                btnBook.Visible = false;
                btnExtend.Visible = false;
            }
        }
        
        // Hàm mở form con
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

        // mở form trang chủ khi nhấp vào btn Dashboard
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.Main());
        }

        // mở form tra cứu khi nhấp vào btn LookUp
        private void btnLookUp_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.LookUpfrm());
        }

        // mở form mượn khi nhấp vào btn Borrow
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.Borrow());
        }

        // mở form sách khi nhấp vào btn Book
        private void btnBook_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.Book());
        }

        // mở form tài khoản khi nhấp vào btn Account
        private void btnAccount_Click(object sender, EventArgs e)
        {
            if(LoginFrm.UserType == 1)
            {
                OpenFrm(new QLTV_Mixture.Account());
            }
            else
            {
                OpenFrm(new QLTV_Mixture.Account_St());
            }
            
        }

        // mở form gia hạn khi nhấp vào btn Extend
        private void btnExtend_Click(object sender, EventArgs e)
        {
            OpenFrm(new QLTV_Mixture.Extend());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrm f = new LoginFrm();
            f.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
