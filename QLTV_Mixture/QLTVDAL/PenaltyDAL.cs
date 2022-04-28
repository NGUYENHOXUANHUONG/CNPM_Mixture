using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class PenaltyDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static PenaltyDAL instance;

        public static PenaltyDAL Instance
        {
            get { if (instance == null) instance = new PenaltyDAL(); return PenaltyDAL.instance; }
            private set => instance = value;
        }

        private PenaltyDAL() { }

        //Lấy ID lớn nhất
        public string GetIDMax()
        {
            string sql = "select ID from dbo.Penalty where ID=(Select max(ID) from dbo.Penalty)";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            string kq = "PC001";
            if (dt.Rows.Count > 0)
            {
                kq = dt.Rows[0].Field<string>(0);
            }
            return kq;
        }

        public string CreateNewID()
        {
            string id_max = GetIDMax();
            string so = id_max[2].ToString() + id_max[3].ToString() + id_max[4].ToString();
            int tmp = Convert.ToInt32(so);
            tmp++;
            if (tmp < 100)
            {
                if (tmp < 10)
                {
                    so = "00" + tmp.ToString();
                }
                else
                {
                    so = "0" + tmp.ToString();
                }
            }
            id_max = "PC" + so;

            return id_max;
        }

        public void CreatePenalty(Penalty pn)
        {
            string sql = "INSERT INTO dbo.Penalty(ID, ID_Library, ID_Student, Overdue_fines, NumOfDay_Overdue, Date_Start) VALUES(@id, @idlib, @idstu, @of, @no, @dt)";
            SqlParameter[] pa = new SqlParameter[6];
            pa[0] = new SqlParameter("id", pn.ID);
            pa[1] = new SqlParameter("idlib", pn.ID_Library);
            pa[2] = new SqlParameter("idstu", pn.ID_Student);
            pa[3] = new SqlParameter("of", pn.Overdue_fines);
            pa[4] = new SqlParameter("no", pn.NumOfDay_Overdue);
            pa[5] = new SqlParameter("dt", pn.Date_Start);
            
            DataProvider.Instance.ExcuteNonQuery(sql, CommandType.Text, pa);
        }

        public bool HavePenalty(string id_stu)
        {
            string query = "Select * from dbo.Penalty where ID_Student = '" + id_stu + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                TimeSpan inte = DateTime.Today.Subtract(Convert.ToDateTime(dt.Rows[0]["Date_Start"]));
                if (inte.Days <= 30)
                {
                    return true;
                } 
            }

            return false;
        }
    }
}
