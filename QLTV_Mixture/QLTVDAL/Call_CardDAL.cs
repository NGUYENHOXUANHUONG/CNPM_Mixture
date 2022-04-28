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
    public class Call_CardDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static Call_CardDAL instance;

        public static Call_CardDAL Instance
        {
            get { if (instance == null) instance = new Call_CardDAL(); return Call_CardDAL.instance; }
            private set => instance = value;
        }

        private Call_CardDAL() { }

        public bool ISBorrowing(string id_student)
        {
            string query = "Select * from dbo.Call_Card where ID_Student = '" + id_student + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    if (Convert.ToInt32(r["Status"].ToString()) == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        //Lấy ID lớn nhất
        public string GetIDMax()
        {
            string sql = "select ID from dbo.Call_Card where ID=(Select max(ID) from dbo.Call_Card)";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            string kq = "CC001";
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
            id_max = "CC" + so;

            return id_max;
        }

        public void CreateCallCard(Call_Card cc)
        {
            string sql = "INSERT INTO dbo.Call_Card(Id, ID_Library, ID_Student, Borrowing_Periods, Return_Date, Renewals, Status) VALUES(@id, @idlib, @idstu, @bp, @rd, @re, @sta)";
            SqlParameter[] pa = new SqlParameter[7];
            pa[0] = new SqlParameter("id", cc.ID);
            pa[1] = new SqlParameter("idlib", cc.ID_Library);
            pa[2] = new SqlParameter("idstu", cc.ID_Student);
            pa[3] = new SqlParameter("bp", cc.Borrowing_Periods);
            pa[4] = new SqlParameter("rd", cc.Return_Date);
            pa[5] = new SqlParameter("re", cc.Renewals);
            pa[6] = new SqlParameter("sta", cc.Status);
            DataProvider.Instance.ExcuteNonQuery(sql, CommandType.Text, pa);
        }

        public void ReturnBook(string id_student)
        {
            string query = "Select * from dbo.Call_Card where ID_Student = '" + id_student + "' and status = 0";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            string id = dt.Rows[0]["ID"].ToString();

            query = "Update dbo.Call_Card SET Status = 1 WHERE ID = '" +id + "'";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void GiaHan(string id_student)
        {
            string query = "Select * from dbo.Call_Card where ID_Student = '" + id_student + "' and status = 0";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            string id = dt.Rows[0]["ID"].ToString();

            query = "Update dbo.Call_Card set Return_Date = DATEADD(day, 7, Return_Date), Renewals = 1 WHERE ID = '"+id+"'";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool DaGiaHan(string id_student)
        {
            string query = "Select * from dbo.Call_Card where ID_Student = '" + id_student + "' and status = 0";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return Convert.ToInt32(dt.Rows[0]["Renewals"].ToString()) == 1;
        }
    }
}
