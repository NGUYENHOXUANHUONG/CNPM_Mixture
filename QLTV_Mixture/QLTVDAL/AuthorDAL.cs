using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class AuthorDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static AuthorDAL instance;

        public static AuthorDAL Instance
        {
            get { if (instance == null) instance = new AuthorDAL(); return AuthorDAL.instance; }
            private set => instance = value;
        }

        private AuthorDAL() { }

        public DataTable getAuthor()
        {
            string query = "Select * from dbo.Author";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<string> GetListName()
        {
            List<string> result = new List<string>();

            string query = "Select * from dbo.Author";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow r in dt.Rows)
            {
                result.Add(r["Name"].ToString());
            }

            return result;
        }

        public string GetIdByName(string name)
        {
            string query = "Select * from dbo.Author where Name = N'" + name + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt.Rows[0].Field<string>(0);
        }
    }
}
