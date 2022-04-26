using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_Computation
{
    internal class UC3_part_time_employee
    {
        public static void parttime_employee()
        {
           const int IS_FULL_TIME = 2;
            const int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if(empcheck == IS_PART_TIME)
            {
                emphrs = 4;
            }
            else if(empcheck == IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp wage :" +empwage);
        }

    }
}
