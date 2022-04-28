using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class BookDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static BookDAL instance;

        public static BookDAL Instance
        {
            get { if (instance == null) instance = new BookDAL(); return BookDAL.instance; }
            private set => instance = value;
        }

        private BookDAL() { }

        //Lấy ID lớn nhất
        public string GetIDMax()
        {
            string sql = "select ID from Book where ID=(Select max(ID) from Book)";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            string kq = "BO001";
            if (dt.Rows.Count > 0)
            {
                kq = dt.Rows[0].Field<string>(0);
            }
            return kq;
        }

        //kiểm tra sách bị trùng
        public bool CheckBook(string name)
        {
            string query = "Select * From dbo.Book where Name = '" + name + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        //Them sach
        public void AddBook(string id, string name, int amount, int status, string idLib)
        {
            string query = "INSERT INTO dbo.Book(ID, Name, Amount, Status, IDLibrian) VALUES(@id, @name, @amount, @stat, @idLib)";
            SqlParameter[] pa = new SqlParameter[5];
            pa[0] = new SqlParameter("id", id);
            pa[1] = new SqlParameter("name", name);
            pa[2] = new SqlParameter("amount", amount);
            pa[3] = new SqlParameter("stat", status);
            pa[4] = new SqlParameter("idLib", idLib);
            DataProvider.Instance.ExcuteNonQuery(query, CommandType.Text, pa);
        }

        //Lấy danh sách sách
        public List<Book> GetBookList()
        {
            List<Book> list = new List<Book>();
            string query = "Select * From dbo.Book";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow r in data.Rows)
            {
                Book b = new Book
                {
                    ID = r["ID"].ToString(),
                    Name = r["Name"].ToString(),
                    Amount = Convert.ToInt32(r["Amount"].ToString()),
                    Status = Convert.ToInt32(r["Status"].ToString()),
                    IDLibrian = r["IDLibrian"].ToString()
                };
                list.Add(b);
            }

            return list;
        }

        //Lấy ID sách từ tên sách
        public string GetIDByName(string name)
        {
            string query = "Select * from dbo.Book where Name = N'" + name + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows[0].Field<string>(0);
        }

        //Lấy tên sách từ ID
        public string GetNameByID(string ID)
        {
            string query = "Select * from dbo.Book where ID = '" + ID + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows[0].Field<string>(1);
        }
    }
}
