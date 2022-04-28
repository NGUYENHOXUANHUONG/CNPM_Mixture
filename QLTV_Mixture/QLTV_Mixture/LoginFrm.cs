using QLTVBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_Mixture
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        bool Login(string email, string password)
        {
            return AccountBUS.Instance.Login(email, password);
        }

        //trường truyền chức vụ người dùng đăng nhập cho các form khác
        private static int userType;

        public static int UserType { get => userType; private set => userType = value; }

        private static string userName;

        public static string UserName { get => userName; private set => userName = value; }

        private static string userMail;

        public static string UserMail { get => userMail; private set => userMail = value; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(txtUser.Text, txtPass.Text))
            {
                UserType = AccountBUS.Instance.getType(txtUser.Text, txtPass.Text);
                UserName = AccountBUS.Instance.getName(txtUser.Text, txtPass.Text);
                UserMail = txtUser.Text;
                Dashboard d = new Dashboard();
                this.Hide();
                d.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
