using QLTVBUS;
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
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
            lbMSSV.Text = Borrow.SelectedBorrow.MSSV;
            lbbookname.Text = Borrow.SelectedBorrow.TenSach;
            lbMail.Text = Borrow.SelectedBorrow.Mail;
            lbName.Text = Borrow.SelectedBorrow.HoTen;
            lbNgayMuon.Text = Borrow.SelectedBorrow.NgayMuon.ToShortDateString();
            lbNgayTra.Text = Borrow.SelectedBorrow.NgayTra.ToShortDateString();
            lbNumber.Text = Borrow.SelectedBorrow.SDT;

            if (DateTime.Today >= Borrow.SelectedBorrow.NgayTra)
            {
                checkTre = true;
                lbTre.Visible = true;
                interval = DateTime.Today.Subtract(Borrow.SelectedBorrow.NgayTra);
                lbTre.Text = "Đã trễ hạn, tiền phạt là " + (interval.Days * 1000).ToString();
                btGiaHan.Visible = false;
            }
        }

        private bool checkTre = false;
        private TimeSpan interval;

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (checkTre)
            {
                DialogResult result = MessageBox.Show("Yêu cầu sinh viên đóng tiền phạt là " + (interval.Days * 1000).ToString(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Call_CardBUS.Instance.ReturnBook(Borrow.SelectedBorrow.MSSV);
                    PenaltyBUS.Instance.CreatePenalty(LibrianBUS.Instance.GetIDByMail(LoginFrm.UserMail), Borrow.SelectedBorrow.MSSV, interval.Days);
                    this.Close();
                }
            }
            else
            {
                Call_CardBUS.Instance.ReturnBook(Borrow.SelectedBorrow.MSSV);
                this.Close();
            }
        }

        private void btGiaHan_Click(object sender, EventArgs e)
        {
            if (!checkTre)
            {
                if (Call_CardBUS.Instance.DaGiaHan(Borrow.SelectedBorrow.MSSV))
                {
                    MessageBox.Show("Lần mượn này đã được gia hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool check = true;
                    try
                    {
                        Call_CardBUS.Instance.GiaHan(Borrow.SelectedBorrow.MSSV);
                        lbNgayTra.Text = Borrow.SelectedBorrow.NgayTra.AddDays(7).ToShortDateString();
                    }
                    catch
                    {
                        check = false;
                        MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (check)
                    {
                        MessageBox.Show("Gia hạn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Trễ hạn không thể gia hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
