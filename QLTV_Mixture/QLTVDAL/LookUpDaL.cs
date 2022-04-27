using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class LookUpDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static LookUpDAL instance;

        public static LookUpDAL Instance
        {
            get { if (instance == null) instance = new LookUpDAL(); return LookUpDAL.instance; }
            private set => instance = value;
        }

        private LookUpDAL() { }

        public List<LookUp> show()
        {
            List<LookUp> r = new List<LookUp>();

            string query = "Select * From dbo.Book";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            int dem = 1;

            foreach (DataRow row in data.Rows)
            {
                LookUp lk = new LookUp
                {
                    STT = dem,
                    BookName = row["Name"].ToString(),
                    Count = Convert.ToInt32(row["Amount"]),
                };

                //Điền thể loại sách
                query = "Select * from dbo.Bo_Cate where ID_Book = '" + row["ID"].ToString() + "'";

                DataTable BC = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow rbc in BC.Rows)
                {
                    query = "Select * from dbo.Category where ID = '" + rbc.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    string tmp = dt.Rows[0].Field<string>(1);

                    lk.Cate += tmp + " ";
                }

                //Điền tên tác giả

                query = "Select * from dbo.Bo_Au where ID_Book = '" + row["ID"].ToString() + "'";

                DataTable BA = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow rba in BA.Rows)
                {
                    query = "Select * from dbo.Author where ID = '" + rba.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    string tmp = dt.Rows[0].Field<string>(1);

                    lk.Author += tmp + " ";
                }

                //Tình trạng sách
                query = "Select * from dbo.CCard_Detail where ID_Book = '" + row["ID"].ToString() + "'";

                DataTable CD = DataProvider.Instance.ExecuteQuery(query);

                int sachdamuon = 0;

                foreach (DataRow rcd in CD.Rows)
                {
                    query = "Select * from dbo.Call_Card where ID = '" + rcd.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    int tmp = dt.Rows[0].Field<int>(6);

                    if (tmp == 0) sachdamuon++;

                    lk.Author += tmp + " ";
                }

                if(sachdamuon >= Convert.ToInt32(row["Amount"]))
                {
                    lk.Status = "Không thể mượn";
                }
                else
                {
                    lk.Status = "Có thể mượn";
                }

                dem++;
                r.Add(lk);
            }

            return r;
        }
    }
}
