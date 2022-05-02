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
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
            FillLsv();
        }

        private static BorrowDTO selectedBorrow;

        public static BorrowDTO SelectedBorrow { get => selectedBorrow; private set => selectedBorrow = value; }

        private List<BorrowDTO> brs = new List<BorrowDTO>();
        private void FillLsv()
        {
            lvDSmuon.Items.Clear();

            string mssv = RemoveSpace(txbMSSV.Text);

            if(mssv.Length > 0)
            {
                brs = BorrowBUS.Instance.SearchByMSSV(mssv);
                LoadLsv(brs);
            }
            else
            {
                brs = BorrowBUS.Instance.getBorrowList();
                LoadLsv(brs);
            }
        }

        private string RemoveSpace(string sth)
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

        private void LoadLsv(List<BorrowDTO> brs)
        {
            foreach(BorrowDTO br in brs)
            {
                ListViewItem lsv = new ListViewItem(br.MSSV);
                lsv.SubItems.Add(br.HoTen);
                lsv.SubItems.Add(br.Mail);
                lsv.SubItems.Add(br.TenSach);
                lvDSmuon.Items.Add(lsv);
            }
            
        }

        private void txbMSSV_TextChanged(object sender, EventArgs e)
        {
            FillLsv();
        }

        private void lvDSmuon_DoubleClick(object sender, MouseEventArgs e)
        {
            string MSSV = lvDSmuon.SelectedItems[0].SubItems[1].Text;
            string HoTen = lvDSmuon.SelectedItems[0].SubItems[2].Text;
            string Mail = lvDSmuon.SelectedItems[0].SubItems[3].Text;
            string SĐT = lvDSmuon.SelectedItems[0].SubItems[4].Text;
            string TenSach = lvDSmuon.SelectedItems[0].SubItems[5].Text;
            if (lvDSmuon.SelectedItems.Count == 1)
            {
                string select_MSSV = lvDSmuon.SelectedItems[0].Text;
                

                
            }

        }
        
    }
}
