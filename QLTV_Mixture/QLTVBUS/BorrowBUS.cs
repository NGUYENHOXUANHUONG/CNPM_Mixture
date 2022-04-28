using QLTVDAL;
using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVBUS
{
    public class BorrowBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static BorrowBUS instance;

        public static BorrowBUS Instance
        {
            get { if (instance == null) instance = new BorrowBUS(); return BorrowBUS.instance; }
            private set => instance = value;
        }

        private BorrowBUS() { }

        public List<BorrowDTO> getBorrowList()
        {
            try
            {
                return BorrowDAL.Instance.getBorrowList();
            }
            catch
            {
                return new List<BorrowDTO>();
            }
        }

        public List<BorrowDTO> SearchByMSSV(string id)
        {
            try
            {
                return BorrowDAL.Instance.SearchByMSSV(id);
            }
            catch
            {
                return new List<BorrowDTO>();
            }
        }
    }
}
