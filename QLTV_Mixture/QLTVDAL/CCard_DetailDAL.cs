using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class CCard_DetailDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static CCard_DetailDAL instance;

        public static CCard_DetailDAL Instance
        {
            get { if (instance == null) instance = new CCard_DetailDAL(); return CCard_DetailDAL.instance; }
            private set => instance = value;
        }

        private CCard_DetailDAL() { }

        public void CreateCCDetail(string idBook)
        {
            string idcc = Call_CardDAL.Instance.GetIDMax();
            string sql = "INSERT INTO dbo.CCard_Detail(ID_Book, ID_CCard) VALUES(@idbook, @idcc)";
            SqlParameter[] pa = new SqlParameter[2];
            pa[0] = new SqlParameter("idbook", idBook);
            pa[1] = new SqlParameter("idcc", idcc);
            DataProvider.Instance.ExcuteNonQuery(sql, CommandType.Text, pa);
        }
    }
}
