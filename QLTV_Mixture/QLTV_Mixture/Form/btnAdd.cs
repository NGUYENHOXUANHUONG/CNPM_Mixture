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

namespace QLTVUI
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
            //LoadListBook();
            //cbStatus.SelectedIndex = 0;
        }

        //private void LoadListBook()
        //{
        //    dtgvListBook.DataSource = BookBUS.Instance.GetBookList();
        //}

        //private bool IsSpace(string name)
        //{
        //    int result = 0;
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        if (name[i] == ' ') result++;
        //    }

        //    if (result == name.Length)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    bool check = true;
        //    if(txbName.Text.Length == 0 || IsSpace(txbName.Text))
        //    {
        //        check = false;
        //        MessageBox.Show("Chưa nhập tên sách!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    if (check)
        //    {
        //        if (BookBUS.Instance.CheckBook(txbName.Text))
        //        {
        //            MessageBox.Show("Sách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            int status = 0;
        //            if (cbStatus.SelectedIndex == 0) status = 1;
        //            try
        //            {
        //                BookBUS.Instance.AddBook(txbName.Text, Convert.ToInt32(numAmount.Value), status, "LB001");
        //                LoadListBook();
        //                MessageBox.Show("Thêm sách " + txbName.Text + " thành công", "Thông báo", MessageBoxButtons.OK);
        //            }
        //            catch
        //            {
        //                MessageBox.Show("Thêm sách " + txbName.Text + " không thành công!!!", "Thông báo", MessageBoxButtons.OK);
        //            }
        //        }
        //    }
        //}
    }
}
