using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_Computation
{
    internal class UC8_Multiple_Companies
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int ComputeEmpWage(string company,int empRatePerHour,int numofWorkingDays,int maxHoursPerMonth)

        {
            int emphrs = 0, totalEmpHrs = 0, totalWorkingDays=0;

            while(totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck=random.Next(0,3);

                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                        case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                        default:
                        emphrs = 0;
                        break;
                }
                totalEmpHrs+=emphrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + emphrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company : " + company + " is : " + totalEmpHrs);
            return totalEmpWage;
        }
        /*  static void Main(string[] args)
        {
            ComputeEmpWage("Dmart", 20, 2, 10);
            ComputeEmpWage("Reliance", 10, 4, 20);
        }*/


    }
}
