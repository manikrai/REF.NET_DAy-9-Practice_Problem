using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_Computation
{
    internal class UC10_Ability_To_Manage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
      
        private int numOfCompany = 0;
       
        private CompanyEmpWage[] companyEmpWageArray;

        public void EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {

            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage( company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);

            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int emphrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random rnd = new Random();
                int empcheck = rnd.Next(0, 3);

                switch (empcheck)
                {
                    case IS_PART_TIME: emphrs = 4; break;
                    case IS_FULL_TIME: emphrs = 8; break;
                    default:
                        emphrs = 0;
                        break;
                }
                totalEmpHrs += emphrs;
                Console.WriteLine("Day# :" + totalWorkingDays + "Emp hrs :" + emphrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
        public class CompanyEmpWage
        {
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmpWage;

            public  CompanyEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }
            public string toString()
            {
                return "Total Emp Wage for Company : " + this.company + "is: " + this.totalEmpWage;
            }
        }
    }
}
