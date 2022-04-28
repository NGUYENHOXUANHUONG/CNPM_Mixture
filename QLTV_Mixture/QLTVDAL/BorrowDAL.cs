using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class BorrowDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static BorrowDAL instance;

        public static BorrowDAL Instance
        {
            get { if (instance == null) instance = new BorrowDAL(); return BorrowDAL.instance; }
            private set => instance = value;
        }

        private BorrowDAL() { }

        public List<BorrowDTO> getBorrowList()
        {
            List<BorrowDTO> result = new List<BorrowDTO>();

            string query = "Select * from dbo.Call_Card where Status = 0";

            DataTable cc = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow rcc in cc.Rows)
            {
                BorrowDTO br = new BorrowDTO
                {
                    MSSV = rcc["ID_Student"].ToString(),
                    NgayMuon = Convert.ToDateTime(rcc["Borrowing_Periods"]),
                    NgayTra = Convert.ToDateTime(rcc["Return_Date"])
                };

                //Điền họ tên, sdt và email
                query = "Select * from dbo.Student where ID = '" + rcc["ID_Student"].ToString() + "'";

                DataTable st = DataProvider.Instance.ExecuteQuery(query);

                query = "Select * from dbo.Account where Email = '" +st.Rows[0]["Mail"] + "'";

                DataTable ac = DataProvider.Instance.ExecuteQuery(query);

                br.HoTen = ac.Rows[0]["Name"].ToString();
                br.Mail = ac.Rows[0]["Email"].ToString();
                br.SDT = ac.Rows[0]["Phone"].ToString();

                //Điền tên sách
                query = "Select * from dbo.CCard_Detail where ID_CCard = '" + rcc["ID"].ToString() + "'";

                DataTable cd = DataProvider.Instance.ExecuteQuery(query);

                br.TenSach = BookDAL.Instance.GetNameByID(cd.Rows[0]["ID_Book"].ToString());

                result.Add(br);
            }

            return result;
        }

        public List<BorrowDTO> SearchByMSSV(string id)
        {
            List<BorrowDTO> result = new List<BorrowDTO>();

            string query = "Select * From dbo.Call_Card Where ID_Student LIKE '%" + id + "%' and Status = 0";

            DataTable cc = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow rcc in cc.Rows)
            {
                BorrowDTO br = new BorrowDTO
                {
                    MSSV = rcc["ID_Student"].ToString(),
                    NgayMuon = Convert.ToDateTime(rcc["Borrowing_Periods"]),
                    NgayTra = Convert.ToDateTime(rcc["Return_Date"])
                };

                //Điền họ tên, sdt và email
                query = "Select * from dbo.Student where ID = '" + rcc["ID_Student"].ToString() + "'";

                DataTable st = DataProvider.Instance.ExecuteQuery(query);

                query = "Select * from dbo.Account where Email = '" + st.Rows[0]["Mail"] + "'";

                DataTable ac = DataProvider.Instance.ExecuteQuery(query);

                br.HoTen = ac.Rows[0]["Name"].ToString();
                br.Mail = ac.Rows[0]["Email"].ToString();
                br.SDT = ac.Rows[0]["Phone"].ToString();

                //Điền tên sách
                query = "Select * from dbo.CCard_Detail where ID_CCard = '" + rcc["ID"].ToString() + "'";

                DataTable cd = DataProvider.Instance.ExecuteQuery(query);

                br.TenSach = BookDAL.Instance.GetNameByID(cd.Rows[0]["ID_Book"].ToString());

                result.Add(br);
            }

            return result;
        }
    }
}
