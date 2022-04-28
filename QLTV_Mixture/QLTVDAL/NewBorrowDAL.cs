using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class NewBorrowDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static NewBorrowDAL instance;

        public static NewBorrowDAL Instance
        {
            get { if (instance == null) instance = new NewBorrowDAL(); return NewBorrowDAL.instance; }
            private set => instance = value;
        }

        private NewBorrowDAL() { }

        public NewBorrow GetStudentDetailByID(string ID)
        {
            string query = "Select * from dbo.Student where ID = '" + ID + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            DataRow r = data.Rows[0];

            string mail = r["Mail"].ToString();

            query = "Select * from dbo.Account where Email = '" + mail + "'";

            DataTable AC = DataProvider.Instance.ExecuteQuery(query);

            DataRow rac = AC.Rows[0];

            NewBorrow result = new NewBorrow
            {
                Name = rac["Name"].ToString(),
                Mail = rac["Email"].ToString(),
                SDT = rac["Phone"].ToString()
            };

            return result;
        }
    }
}
