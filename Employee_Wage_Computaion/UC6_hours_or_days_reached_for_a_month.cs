using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_Computation
{
    internal class UC6_hours_or_days_reached_for_a_month
    {
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public static void TotalWorkingHours()
        {
            int emphrs = 0, totalemphrs = 0, totalworkingdays = 0;
            while (totalemphrs <= MAX_HRS_IN_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck=random.Next(0,3);
                switch (empcheck)
                {
                    case IS_PART_TIME: emphrs=4;
                        break;
                        case IS_FULL_TIME: emphrs=8;
                        break;
                        default: emphrs=0;
                        break;
                }
                totalemphrs += emphrs;
                Console.WriteLine("day: " + totalworkingdays); 
                Console.WriteLine("emphrs: " + emphrs);
            }
            int totalempwage = totalemphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("total emp wage : " + totalempwage);

        }
    }
}
