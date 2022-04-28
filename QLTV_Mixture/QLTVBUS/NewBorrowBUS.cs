using QLTVDAL;
using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVBUS
{
    public class NewBorrowBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static NewBorrowBUS instance;

        public static NewBorrowBUS Instance
        {
            get { if (instance == null) instance = new NewBorrowBUS(); return NewBorrowBUS.instance; }
            private set => instance = value;
        }

        private NewBorrowBUS() { }

        public NewBorrow GetStudentDetailByID(string ID)
        {
            try
            {
                return NewBorrowDAL.Instance.GetStudentDetailByID(ID);
            }
            catch
            {
                return new NewBorrow();
            }
        }
    }
}
