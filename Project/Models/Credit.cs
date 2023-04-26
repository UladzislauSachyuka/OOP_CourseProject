using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Credit
    {
        public string CreditType { get; set; }
        public double Rate { get; set; }
        public int Sum { get; set; }
        public int Period { get; set; }
    }
}
