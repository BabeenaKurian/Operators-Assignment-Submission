using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            employee example = new employee();

            example.firstName = "Kitty";
            example.lastName = "Katz";
            example.ID = 24923;

            employee example2 = new employee();
            example2.firstName = "John";
            example2.lastName = "Dudinsky";
            example2.ID = 39292;

            employee.Equals(example2, example);
        }
    }
}
