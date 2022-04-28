using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class StudentDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static StudentDAL instance;

        public static StudentDAL Instance
        {
            get { if (instance == null) instance = new StudentDAL(); return StudentDAL.instance; }
            private set => instance = value;
        }

        private StudentDAL() { }

        public List<string> GetIDList()
        {
            List<string> result = new List<string>();

            string query = "Select * from dbo.Student";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow r in data.Rows)
            {
                string tmp = r["ID"].ToString();

                result.Add(tmp);
            }

            return result;
        }
    }
}
