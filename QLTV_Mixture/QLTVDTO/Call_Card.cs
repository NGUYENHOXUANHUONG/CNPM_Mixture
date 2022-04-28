using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDTO
{
    public class Call_Card
    {
        public string ID { get; set; }
        public string ID_Library { get; set; }
        public string ID_Student { get; set; }
        public DateTime Borrowing_Periods { get; set; }
        public DateTime Return_Date { get; set; }
        public int Renewals { get; set; }
        public int Status { get; set; }
    }
}
