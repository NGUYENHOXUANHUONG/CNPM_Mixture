using QLTVDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVBUS
{
    public class Bo_CateBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static Bo_CateBUS instance;

        public static Bo_CateBUS Instance
        {
            get { if (instance == null) instance = new Bo_CateBUS(); return Bo_CateBUS.instance; }
            private set => instance = value;
        }

        private Bo_CateBUS() { }

        public List<string> getIdCate(string idBook)
        {
            try
            {
                return Bo_CateDAL.Instance.getIdCate(idBook);
            }
            catch
            {
                List<string> r = new List<string>();
                r.Add("");
                return r;
            }
        }
    }
}
