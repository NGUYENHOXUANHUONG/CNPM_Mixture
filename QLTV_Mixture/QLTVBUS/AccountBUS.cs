using QLTVDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLTVBUS
{
    public class AccountBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get { if (instance == null) instance = new AccountBUS(); return instance; }
            private set => instance = value;
        }

        private AccountBUS() { }

        //Hàm mã hóa mật khẩu
        private string MaHoa(string pass)
        {
            byte[] tmp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(tmp);

            string haspass = "";

            foreach (byte item in hasData)
            {
                haspass += item;
            }

            return haspass;
        }

        public bool Login(string email, string password)
        {
            string pass = MaHoa(password);
            try
            {
                return AccountDAL.Instance.Login(email, pass);
            }
            catch
            {
                return false;
            }
        }

        public int getType(string email, string password)
        {
            string pass = MaHoa(password);
            try
            {
                return AccountDAL.Instance.getType(email, pass);
            }
            catch
            {
                return 0;
            }
        }

        public string getName(string email, string password)
        {
            string pass = MaHoa(password);
            try
            {
                return AccountDAL.Instance.getName(email, pass);
            }
            catch
            {
                return "";
            }
        }
    }
}
