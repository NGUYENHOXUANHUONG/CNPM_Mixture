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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        //hàm gọi kiểm tra login của class accountDAO
        //bool Login(string username, string password)
        //{
        //    //return BUS.Instance.Login(username, password);
        //}

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            ////biến tạm lưu tên đăng nhập và mật khẩu
            //string user = txtUser.Text;
            //string pass = txtPass.Text;

            ////kiểm tra tài khoản mật khẩu
            //if (Login(user, pass))
            //{
            //    //lưu tên và chức vụ người dùng QSG
            //    UserDisplayName = AccountBUS.Instance.GetDisplayName(user, pass);
            //    UserStatic = AccountBUS.Instance.GetStatus(user, pass);
            //    UserName = AccountBUS.Instance.GetUserName(user, pass);
            //    //mở form Menu
            //    frmMenu f = new frmMenu();
            //    this.Hide();
            //    f.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    //hiện dòng chữ sai tài khoản hoặc mật khẩu
            //    MessageBox.Show("Sai mmật khẩu!","Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //}
        }
    }
}
