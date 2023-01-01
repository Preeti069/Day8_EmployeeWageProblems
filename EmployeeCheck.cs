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
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee  is Absent");
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Daily Wage is : " + empWage);
        }
    }
}
