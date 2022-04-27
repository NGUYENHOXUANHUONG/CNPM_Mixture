using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class Bo_CateDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static Bo_CateDAL instance;

        public static Bo_CateDAL Instance
        {
            get { if (instance == null) instance = new Bo_CateDAL(); return Bo_CateDAL.instance; }
            private set => instance = value;
        }

        private Bo_CateDAL() { }

        public List<string> getIdCate(string idBook)
        {
            List<string> res = new List<string>();

            string query = "Select * from dbo.Bo_Cate where ID_Book = '" + idBook + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow r in dt.Rows)
            {
                res.Add(r.Field<string>(1));
            }

            return res;
        }
    }
}
