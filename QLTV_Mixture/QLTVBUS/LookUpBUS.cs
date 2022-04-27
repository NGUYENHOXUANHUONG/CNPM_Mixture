using QLTVDAL;
using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVBUS
{
    public class LookUpBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static LookUpBUS instance;

        public static LookUpBUS Instance
        {
            get { if (instance == null) instance = new LookUpBUS(); return LookUpBUS.instance; }
            private set => instance = value;
        }

        private LookUpBUS() { }

        public List<LookUp> show()
        {
            try
            {
                return LookUpDAL.Instance.show();
            }
            catch 
            {
                return new List<LookUp>();
            }
        }

        public List<LookUp> SortByName(string name)
        {
            try
            {
                return LookUpDAL.Instance.SortByName(name);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<LookUp>();
            }
        }

        public List<LookUp> SortByCate(string IDCate)
        {
            try
            {
                return LookUpDAL.Instance.SortByCate(IDCate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<LookUp>();
            }
        }

        public List<LookUp> SortByAuthor(string IDAuth)
        {
            try
            {
                return LookUpDAL.Instance.SortByAuthor(IDAuth);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<LookUp>();
            }
        }

        public List<LookUp> SortByBookAndCate(string bookname, string IDCate)
        {
            try
            {
                return LookUpDAL.Instance.SortByBookAndCate(bookname, IDCate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<LookUp>();
            }
        }

        public List<LookUp> SortByBookAndAuth(string bookname, string IDAuth)
        {
            try
            {
                return LookUpDAL.Instance.SortByBookAndAuth(bookname,IDAuth);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<LookUp>();
            }
        }

        public List<LookUp> SortByCateAndAuth(string IDCate, string IDAuth)
        {
            try
            {
                return LookUpDAL.Instance.SortByCateAndAuth(IDCate, IDAuth);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<LookUp>();
            }
        }

        public List<LookUp> SortBy3Ele(string bookname, string IDCate, string IDAuth)
        {
            try
            {
                return LookUpDAL.Instance.SortBy3Ele(bookname, IDCate, IDAuth);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<LookUp>();
            }
        }
    }
}
