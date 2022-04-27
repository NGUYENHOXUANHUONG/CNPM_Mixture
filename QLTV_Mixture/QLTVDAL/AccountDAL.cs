using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class AccountDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static AccountDAL instance;
        
        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set => instance = value;
        }

        private AccountDAL() { }

        public bool Login(string email, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE Email = '" + email + "' AND Password = '" + password + "'";

            DataTable res = DataProvider.Instance.ExecuteQuery(query);

            return res.Rows.Count > 0;
        }

        public int getType(string email, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE Email = '" + email + "' AND Password = '" + password + "'";

            DataTable res = DataProvider.Instance.ExecuteQuery(query);

            return res.Rows[0].Field<int>(2);
        }

        public string getName(string email, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE Email = '" + email + "' AND Password = '" + password + "'";

            DataTable res = DataProvider.Instance.ExecuteQuery(query);

            return res.Rows[0].Field<string>(3);
        }
    }
}
