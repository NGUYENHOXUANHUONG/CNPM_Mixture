using QLTVDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVBUS
{
    public class AuthorBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static AuthorBUS instance;

        public static AuthorBUS Instance
        {
            get { if (instance == null) instance = new AuthorBUS(); return AuthorBUS.instance; }
            private set => instance = value;
        }

        private AuthorBUS() { }

        public DataTable getAuthor()
        {
            try
            {
                return AuthorDAL.Instance.getAuthor();
            }
            catch
            {
                return new DataTable();
            }
        }

        public List<string> GetListName()
        {
            try
            {
                return AuthorDAL.Instance.GetListName();
            }
            catch
            {
                return new List<string>();
            }
        }

        public string GetIdByName(string name)
        {
            try
            {
                return AuthorDAL.Instance.GetIdByName(name);
            }
            catch
            {
                return "";
            }
        }
    }
}
