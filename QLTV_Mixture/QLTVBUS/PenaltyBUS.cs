using QLTVDAL;
using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVBUS
{
    public class PenaltyBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static PenaltyBUS instance;

        public static PenaltyBUS Instance
        {
            get { if (instance == null) instance = new PenaltyBUS(); return PenaltyBUS.instance; }
            private set => instance = value;
        }

        private PenaltyBUS() { }

        public void CreatePenalty(string idlib, string idstu, int songaytre)
        {
            try
            {
                Penalty pn = new Penalty
                {
                    ID = PenaltyDAL.Instance.CreateNewID(),
                    ID_Library = idlib,
                    ID_Student = idstu,
                    Overdue_fines = songaytre * 1000,
                    NumOfDay_Overdue = songaytre,
                    Date_Start = DateTime.Today
                };
                PenaltyDAL.Instance.CreatePenalty(pn);
            }
            catch
            {
                MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool HavePenalty(string id_stu)
        {
            try
            {
                return PenaltyDAL.Instance.HavePenalty(id_stu);
            }
            catch
            {
                MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
    }
}
