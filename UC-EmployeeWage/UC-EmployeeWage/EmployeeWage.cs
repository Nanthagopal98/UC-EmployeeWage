using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_EmployeeWage
{
    public class EmployeeWage
    {
        int employeePresent = 1;
        int absent = 0;
        int empWagePerHour = 20;
        int isFullTime = 8;
        public void employeeAttendatce() 
        {
            Random random = new Random();
            int attendance = random.Next(2);
            if(attendance==1)
            {
                Console.WriteLine("Employee present");
                int wagePerDay = empWagePerHour * isFullTime;
                Console.WriteLine("Employee Wage per day = " + wagePerDay);
            }
            else
            {
                Console.WriteLine("Employee absent");
            }
               
        }
    }
}
