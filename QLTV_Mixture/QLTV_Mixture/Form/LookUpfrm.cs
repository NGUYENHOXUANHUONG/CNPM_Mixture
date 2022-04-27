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
            ccbCate.SelectedIndex = -1;
        }

        public void LoadForm()
        {
            lvLookUp.Items.Clear();
            List<LookUp> lk = LookUpBUS.Instance.show();

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

            DataTable cate = CategoryBUS.Instance.getCate();

            ccbCate.DataSource = cate;
            ccbCate.DisplayMember = "Name";
            ccbCate.ValueMember = "ID";
        }
    }
}
