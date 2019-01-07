using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Staff
    {
        public int Age { get; set; }
        public decimal Salary { get; set; }

        Random r = new Random();
        public Staff()
        {
            Age = r.Next(25, 50);
            Salary = r.Next(2100, 10000);
        }
    }
}
