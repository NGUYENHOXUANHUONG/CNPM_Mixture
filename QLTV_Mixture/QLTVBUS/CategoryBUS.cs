using QLTVDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVBUS
{
    public class CategoryBUS
    {
        //singleton pattern (khởi tạo duy nhất)
        private static CategoryBUS instance;

        public static CategoryBUS Instance
        {
            get { if (instance == null) instance = new CategoryBUS(); return CategoryBUS.instance; }
            private set => instance = value;
        }

        private CategoryBUS() { }

        public string getName(string id)
        {
            try
            {
                return CategoryDAL.Instance.getName(id);
            }
            catch
            {
                return "Chưa chọn thể loại";
            }
        }

        public DataTable getCate()
        {
            try
            {
                return CategoryDAL.Instance.getCate();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataTable();
            }
        }

        public List<string> GetListName()
        {
            try
            {
                return CategoryDAL.Instance.GetListName();
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
                return CategoryDAL.Instance.GetIdByName(name);
            }
            catch
            {
                return "";
            }
        }
    }
}
