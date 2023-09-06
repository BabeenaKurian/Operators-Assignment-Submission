using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class employee
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public static bool Equals(employee emp1, employee emp2)
        {
            if (emp1.ID == emp2.ID)
                return true;
            else
                return false;
        }
    }
    }
}
