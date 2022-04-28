using QLTVDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVBUS
{
    public class LibrianBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static LibrianBUS instance;

        public static LibrianBUS Instance
        {
            get { if (instance == null) instance = new LibrianBUS(); return LibrianBUS.instance; }
            private set => instance = value;
        }

        private LibrianBUS() { }

        public string GetIDByMail(string mail)
        {
            try
            {
                return LibrianDAL.Instance.GetIDByMail(mail);
            }
            catch
            {
                return "";
            }
        }
    }
}
