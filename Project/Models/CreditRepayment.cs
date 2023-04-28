using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CreditRepayment
    {
        public double Rate { get; set; }
        public double Balance { get; set; }
        public double InterestPayment { get; set; }
        public double MainDebt { get; set; }
        public double Sum { get; set; }
    }
}
