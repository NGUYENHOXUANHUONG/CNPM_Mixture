using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDTO
{
    public class BorrowDTO
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string Mail { get; set; }
        public string SDT { get; set; }
        public string TenSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
    }
}
