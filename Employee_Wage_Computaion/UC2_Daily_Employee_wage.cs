using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage_Computation
{
    internal class UC2_Daily_Employee_wage
    {
       public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void EmployeeSalaryofDay()
        {
            
            
            int emphrs = 0;
            int empwage = 0;
        
            Random random = new Random();
            int empcheck=random.Next(0,2);
           
            if(empcheck==IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp wage of the day is :" + empwage);
           
        }
    }
}
