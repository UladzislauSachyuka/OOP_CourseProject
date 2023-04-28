using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string Telephone { get; set; }
        public int Salary { get; set; }
        public string Role { get; set; }
        public UserAuth UserAuth { get; set; }
        public CreditRepayment CreditRepayment { get; set; }
    }
}
