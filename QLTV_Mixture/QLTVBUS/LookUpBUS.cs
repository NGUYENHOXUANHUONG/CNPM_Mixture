using QLTVDAL;
using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVBUS
{
    public class LookUpBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static LookUpBUS instance;

        public static LookUpBUS Instance
        {
            get { if (instance == null) instance = new LookUpBUS(); return LookUpBUS.instance; }
            private set => instance = value;
        }

        private LookUpBUS() { }

        public List<LookUp> show()
        {
            try
            {
                return LookUpDAL.Instance.show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<LookUp>();
            }
        }
    }
}
