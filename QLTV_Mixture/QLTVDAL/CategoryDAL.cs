using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class CategoryDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static CategoryDAL instance;

        public static CategoryDAL Instance
        {
            get { if (instance == null) instance = new CategoryDAL(); return CategoryDAL.instance; }
            private set => instance = value;
        }

        private CategoryDAL() { }

        public string getName(string id)
        {
            string query = "Select * from dbo.Category where id = '" + id + "'";

            DataTable dt= DataProvider.Instance.ExecuteQuery(query);

            string res = dt.Rows[0].Field<string>(1);

            return res;
        }

        public DataTable getCate()
        {
            string query = "Select * from dbo.Category";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<string> GetListName()
        {
            List<string> result = new List<string>();

            string query = "Select * from dbo.Category";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow r in dt.Rows)
            {
                result.Add(r["Name"].ToString());
            }

            return result;
        }

        public string GetIdByName(string name)
        {
            string query = "Select * from dbo.Category where Name = N'" + name + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt.Rows[0].Field<string>(0);
        }
    }
}
