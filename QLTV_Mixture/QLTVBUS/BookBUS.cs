using QLTVDAL;
using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVBUS
{
    public class BookBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static BookBUS instance;

        public static BookBUS Instance
        {
            get { if (instance == null) instance = new BookBUS(); return BookBUS.instance; }
            private set => instance = value;
        }

        private BookBUS() { }

        //Lấy ID lớn nhất
        public string GetIDMax()
        {
            try
            {
                return BookDAL.Instance.GetIDMax();
            }
            catch
            {
                return "BO001";
            }
        }

        //kiểm tra sách bị trùng
        public bool CheckBook(string name)
        {
            try
            {
                return BookDAL.Instance.CheckBook(name);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return true;
            }
        }

        //Them sach
        public void AddBook(string name, int amount, int status, string idLib)
        {
            try
            {
                string id = GetIDMax();
                string so = id[2].ToString() + id[3].ToString() + id[4].ToString();
                int tmp = Convert.ToInt32(so);
                tmp++;
                if (tmp < 100)
                {
                    if (tmp < 10)
                    {
                        so = "00" + tmp.ToString();
                    }
                    else
                    {
                        so = "0" + tmp.ToString();
                    }
                }
                id = "BO" + so;
                BookDAL.Instance.AddBook(id, name, amount, status, idLib);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Lấy danh sách sách
        public List<Book> GetBookList()
        {
            try
            {
                List<Book> bo = new List<Book>();
                bo = BookDAL.Instance.GetBookList();
                return bo;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<Book>();
            }
        }
    }
}
