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
    public partial class LookUpfrm : Form
    {
        public LookUpfrm()
        {
            InitializeComponent();
            LoadForm();
            ccbAuth.SelectedIndex = -1;
            ccbCate.SelectedIndex = -1;
        }

        public void LoadForm()
        {
            List<LookUp> lk = LookUpBUS.Instance.show();
            AddLsvItem(lk);

            List<string> Cate = CategoryBUS.Instance.GetListName();
            for(int i = 0; i < Cate.Count; i++)
            {
                ccbCate.Items.Add(Cate[i]);
            }

            List<string> Auth = AuthorBUS.Instance.GetListName();
            for (int i = 0; i < Auth.Count; i++)
            {
                ccbAuth.Items.Add(Auth[i]);
            }
        }

        public void LoadLsv()
        {
            lvLookUp.Items.Clear();
            string bookname = RemoveSpace(txbName.Text);
            if (bookname.Length == 0 && ccbAuth.SelectedIndex == -1 && ccbCate.SelectedIndex == -1) //Không chọn cả 3 
            {
                List<LookUp> lk = LookUpBUS.Instance.show();
                AddLsvItem(lk);
            }
            else if (bookname.Length > 0 && ccbAuth.SelectedIndex == -1 && ccbCate.SelectedIndex == -1) //Chọn tên sách
            {
                List<LookUp> lk = LookUpBUS.Instance.SortByName(bookname);
                AddLsvItem(lk);
            }
            else if (bookname.Length == 0 && ccbAuth.SelectedIndex != -1 && ccbCate.SelectedIndex == -1) //Chọn tác giả
            {
                string au_name = ccbAuth.SelectedItem.ToString();
                string IdAuth = AuthorBUS.Instance.GetIdByName(au_name);
                List<LookUp> lk = LookUpBUS.Instance.SortByAuthor(IdAuth);
                AddLsvItem(lk);
            }
            else if (bookname.Length == 0 && ccbAuth.SelectedIndex == -1 && ccbCate.SelectedIndex != -1) //Chọn thể loại
            {
                string ca_name = ccbCate.SelectedItem.ToString();
                string IdCate = CategoryBUS.Instance.GetIdByName(ca_name);
                List<LookUp> lk = LookUpBUS.Instance.SortByCate(IdCate);
                AddLsvItem(lk);
            }
            else if (bookname.Length > 0 && ccbAuth.SelectedIndex != -1 && ccbCate.SelectedIndex == -1) //Chọn tên sách và tác giả
            {
                string au_name = ccbAuth.SelectedItem.ToString();
                string IdAuth = AuthorBUS.Instance.GetIdByName(au_name);
                List<LookUp> lk = LookUpBUS.Instance.SortByBookAndAuth(bookname, IdAuth);
                AddLsvItem(lk);
            }
            else if (bookname.Length > 0 && ccbAuth.SelectedIndex == -1 && ccbCate.SelectedIndex != -1) //Chọn tên sách và thể loại
            {
                string ca_name = ccbCate.SelectedItem.ToString();
                string IdCate = CategoryBUS.Instance.GetIdByName(ca_name);
                List<LookUp> lk = LookUpBUS.Instance.SortByBookAndCate(bookname, IdCate);
                AddLsvItem(lk);
            }
            else if (bookname.Length == 0 && ccbAuth.SelectedIndex != -1 && ccbCate.SelectedIndex != -1) //Chọn thể loại và tác giả
            {
                string ca_name = ccbCate.SelectedItem.ToString();
                string IdCate = CategoryBUS.Instance.GetIdByName(ca_name);
                string au_name = ccbAuth.SelectedItem.ToString();
                string IdAuth = AuthorBUS.Instance.GetIdByName(au_name);
                List<LookUp> lk = LookUpBUS.Instance.SortByCateAndAuth(IdCate, IdAuth);
                AddLsvItem(lk);
            }
            else if (bookname.Length > 0 && ccbAuth.SelectedIndex != -1 && ccbCate.SelectedIndex != -1) //Chọn cả 3
            {
                string ca_name = ccbCate.SelectedItem.ToString();
                string IdCate = CategoryBUS.Instance.GetIdByName(ca_name);
                string au_name = ccbAuth.SelectedItem.ToString();
                string IdAuth = AuthorBUS.Instance.GetIdByName(au_name);
                List<LookUp> lk = LookUpBUS.Instance.SortBy3Ele(bookname, IdCate, IdAuth);
                AddLsvItem(lk);
            }
        }

        public void AddLsvItem(List<LookUp> lk)
        {
            foreach (LookUp lo in lk)
            {
                ListViewItem lsv = new ListViewItem(lo.STT.ToString());
                lsv.SubItems.Add(lo.BookName);
                lsv.SubItems.Add(lo.Cate);
                lsv.SubItems.Add(lo.Author);
                lsv.SubItems.Add(lo.Count.ToString());
                lsv.SubItems.Add(lo.Status);
                lvLookUp.Items.Add(lsv);
            }
        }

        public string RemoveSpace(string sth)
        {
            for (int i = 0; i < sth.Length; i++)
            {
                if (sth[i] == ' ')
                {
                    sth.Remove(i, 1);
                }
            }

            return sth;
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            LoadLsv();
        }

        private void ccbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLsv();
        }

        private void ccbAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLsv();
        }

        private void btnTuchoi_Click(object sender, EventArgs e)
        {
            txbName.Text = "";
            ccbCate.SelectedIndex = -1;
            ccbAuth.SelectedIndex = -1;
            LoadLsv();
        }
    }
}
