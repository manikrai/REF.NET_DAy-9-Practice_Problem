using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_Computation
{
    internal class UC5_wages_for_a_month
    {
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;

       
        public static void CalculatingWagesforaMonth()
        {
            int emphrs=0,empwage=0,totalempwage = 0;
           
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0,3);
                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                empwage = emphrs * EMP_RATE_PER_HOUR;
                totalempwage += empwage;
               Console.WriteLine("emp wage of the day:" +empwage);
            }
            Console.WriteLine("total emp wage :" +totalempwage);
        }
    }
}
