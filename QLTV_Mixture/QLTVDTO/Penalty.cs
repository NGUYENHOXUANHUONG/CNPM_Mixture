using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDTO
{
    public class Penalty
    {
        public string ID { get; set; }
        public string ID_Library { get; set; }
        public string ID_Student { get; set; }
        public int Overdue_fines { get; set; }
        public int NumOfDay_Overdue { get; set; }
        public DateTime Date_Start { get; set; }
    }
}
