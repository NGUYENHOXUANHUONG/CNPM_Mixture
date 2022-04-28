using QLTVDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVBUS
{
    public class CCard_DetailBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static CCard_DetailBUS instance;

        public static CCard_DetailBUS Instance
        {
            get { if (instance == null) instance = new CCard_DetailBUS(); return CCard_DetailBUS.instance; }
            private set => instance = value;
        }

        private CCard_DetailBUS() { }

        public void CreateCCDetail(string idBook)
        {
            CCard_DetailDAL.Instance.CreateCCDetail(idBook);
        }
    }
}
