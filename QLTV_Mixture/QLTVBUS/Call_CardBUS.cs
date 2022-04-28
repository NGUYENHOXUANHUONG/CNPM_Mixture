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
    public class Call_CardBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static Call_CardBUS instance;

        public static Call_CardBUS Instance
        {
            get { if (instance == null) instance = new Call_CardBUS(); return Call_CardBUS.instance; }
            private set => instance = value;
        }

        private Call_CardBUS() { }

        public bool ISBorrowing(string id_student)
        {
            try
            {
                return Call_CardDAL.Instance.ISBorrowing(id_student);
            }
            catch
            {
                return true;
            }
        }

        public void CreateCallCard(string id_student, string id_lib)
        {
            Call_Card cc = new Call_Card
            {
                ID = Call_CardDAL.Instance.CreateNewID(),
                ID_Library = id_lib,
                ID_Student = id_student,
                Borrowing_Periods = DateTime.Today,
                Return_Date = DateTime.Today.AddDays(7),
                Renewals = 0,
                Status = 0
            };

            Call_CardDAL.Instance.CreateCallCard(cc);
        }

        public void ReturnBook(string id_student)
        {
            try
            {
                Call_CardDAL.Instance.ReturnBook(id_student);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GiaHan(string id_student)
        {
            Call_CardDAL.Instance.GiaHan(id_student);
        }

        public bool DaGiaHan(string id_student)
        {
            try
            {
                return Call_CardDAL.Instance.DaGiaHan(id_student);
            }
            catch
            {
                return true;
            }
        }
    }
}
