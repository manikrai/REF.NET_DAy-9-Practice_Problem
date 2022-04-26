using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_Computation
{
    internal class UC9_Save_Total_Wage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private String comapny;
        private int empRatePerHour;
        private int numofWorkingDays;
        private int maxHourPerMonth;
        private int totalEmpwage;
       
        public UC9_Save_Total_Wage(string company,int empRatePerHour, int numofWorkingDays,int maxhourPerMonth)
        {
            this.comapny = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHourPerMonth = maxhourPerMonth; 
            
        }
        public void ComputeEmpWage()
        {
            int emphrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= this.maxHourPerMonth && totalWorkingDays < this.numofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);

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
                totalEmpHrs += emphrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + emphrs);
            }
            totalEmpwage = totalEmpHrs * this.empRatePerHour;
            //Console.WriteLine("Total Emp wage For Company : " + comapny + "is: " + totalEmpwage);

        }
        public string tostring()
        {
            return "Total Emp Wage For Company : " + this.comapny + "is : " + this.totalEmpwage;

        }
    }

}
