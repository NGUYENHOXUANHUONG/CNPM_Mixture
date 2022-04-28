using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class LibrianDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static LibrianDAL instance;

        public static LibrianDAL Instance
        {
            get { if (instance == null) instance = new LibrianDAL(); return LibrianDAL.instance; }
            private set => instance = value;
        }

        private LibrianDAL() { }

        public string GetIDByMail(string mail)
        {
            string query = "select ID from dbo.Librian where Mail = '" + mail + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt.Rows[0].Field<string>(0);
        }
    }
}
