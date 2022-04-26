using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_Computation
{
    internal class UC7_Compute_Employee_Wage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;

        public static int ComputeEmpwage()
        {
            int emphrs=0,totalEmpHrs=0,totalWorkingDays=0;

            while(totalEmpHrs<=MAX_HRS_IN_MONTH && totalWorkingDays<NUM_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random rnd = new Random();
                int empcheck=rnd.Next(0,3);

                switch(empcheck)
                {
                    case IS_PART_TIME: emphrs=4; break;
                        case IS_FULL_TIME: emphrs=8; break;
                        default:
                        emphrs=0;
                        break;
                }
                totalEmpHrs+=emphrs;
                Console.WriteLine("Day# :" + totalWorkingDays + "Emp hrs :" + emphrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            return totalEmpWage;
        }
        //static void Main(string[] args)
        //{
          //  ComputeEmpwage();
        //}
    }
}
