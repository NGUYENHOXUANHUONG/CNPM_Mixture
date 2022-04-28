using QLTVBUS;
using QLTVDTO;
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
    public partial class NewBorrowfrm : Form
    {
        public NewBorrowfrm()
        {
            InitializeComponent();
            lbBook.Text = LookUpfrm.SelectedBookName;
            List<string> st = StudentBUS.Instance.GetIDList();

            for (int i = 0; i < st.Count; i++)
            {
                cbbMSSV.Items.Add(st[i]);
            }
        }

        private void cbbMSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewBorrow nb = NewBorrowBUS.Instance.GetStudentDetailByID(cbbMSSV.SelectedItem.ToString());

            txbHoten.Text = nb.Name;
            txbMail.Text = nb.Mail;
            txbSĐT.Text = nb.SDT;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbMSSV_TextChanged(object sender, EventArgs e)
        {
            NewBorrow nb = NewBorrowBUS.Instance.GetStudentDetailByID(cbbMSSV.Text);

            txbHoten.Text = nb.Name;
            txbMail.Text = nb.Mail;
            txbSĐT.Text = nb.SDT;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            NewBorrow nb = NewBorrowBUS.Instance.GetStudentDetailByID(cbbMSSV.Text);

            if (nb.Name == null)
            {
                MessageBox.Show("Không tìm thấy mã số sinh viên");
            }
            else if (Call_CardBUS.Instance.ISBorrowing(cbbMSSV.Text))
            {
                MessageBox.Show("Sinh viên đang mượn sách hoặc không tìm thấy mã số sinh viên");
            }
            else if (PenaltyBUS.Instance.HavePenalty(cbbMSSV.Text))
            {
                MessageBox.Show("Sinh viên vẫn đang trong thời gian phạt");
            }
            else
            {
                bool check = true;
                try
                {
                    Call_CardBUS.Instance.CreateCallCard(cbbMSSV.Text, LibrianBUS.Instance.GetIDByMail(LoginFrm.UserMail));
                    CCard_DetailBUS.Instance.CreateCCDetail(BookBUS.Instance.GetIDByName(LookUpfrm.SelectedBookName));
                }
                catch
                {
                    check = false;
                    MessageBox.Show("Gặp lỗi khi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (check)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }
    }
}
