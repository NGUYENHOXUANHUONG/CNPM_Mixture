using QLTVDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVBUS
{
    public class StudentBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static StudentBUS instance;

        public static StudentBUS Instance
        {
            get { if (instance == null) instance = new StudentBUS(); return StudentBUS.instance; }
            private set => instance = value;
        }

        private StudentBUS() { }

        public List<string> GetIDList()
        {
            try
            {
                return StudentDAL.Instance.GetIDList();
            }
            catch
            {
                return new List<string>();
            }
        }
    }
}
