// See https://aka.ms/new-console-template for more information
using System;
namespace Employee_wage_Computation
{
    internal class Program
    {
         static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to Employee wage Computation");
           // UC1_Employee_Attendance.EmployeeAttendance();

            //UC2_Daily_Employee_wage.EmployeeSalaryofDay();
            
            //UC5_wages_for_a_month.CalculatingWagesforaMonth();
            
            //UC6_hours_or_days_reached_for_a_month.TotalWorkingHours();
            
            //UC3_part_time_employee.parttime_employee();
            
            //Uc4_Switch_case.switch_statement();
            
            //UC7_Compute_Employee_Wage.ComputeEmpwage();
            
            // UC8_Multiple_Companies.ComputeEmpWage("Reliance", 10, 4, 20);
            
            //UC8_Multiple_Companies.ComputeEmpWage("Dmart", 20, 2, 10);

           /* UC9_Save_Total_Wage dmart = new UC9_Save_Total_Wage("Dmart", 20, 2, 10);
            UC9_Save_Total_Wage reliance = new UC9_Save_Total_Wage("Reliance", 10, 4, 20);
            dmart.ComputeEmpWage();
            Console.WriteLine(dmart.tostring());
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.tostring());*/

            UC10_Ability_To_Manage empWageBuilder = new UC10_Ability_To_Manage();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
                
            
            Console.ReadKey();
        }
    }
}

