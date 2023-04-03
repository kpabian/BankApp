using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App1
{
    public class LoanClass
    {
        public User user { get; set; }
        public decimal sum { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
