using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_EmployeeWagePro
{
    public class EmployeeCheck
    {
        public void display()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
