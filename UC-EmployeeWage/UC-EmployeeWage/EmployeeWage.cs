using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_EmployeeWage
{
    public class EmployeeWage
    {
        int employeeFullTimet = 1;
        int employeePartTimet = 2;
        int absent = 0;
        int empWagePerHour = 20;
        int isFullTime = 8;
        int isPartTime = 4;
        public void employeeAttendatce() 
        {
            int[] values = new int[20];
            for (int i = 1; i <= 20; i++)
            {
                Random random = new Random();
                int attendance = random.Next(3);
                switch (attendance)
                {
                    case 1:
                        Console.WriteLine("Employee Fulltime");
                        int fullTimeWage = empWagePerHour * isFullTime;
                        Console.WriteLine("Day " + i +" Employee Wage is = " + fullTimeWage);
                        values[i]=fullTimeWage;
                        break;
                    case 2:
                        Console.WriteLine("Employee Parttime");
                        int partTimeWage = empWagePerHour * isPartTime;
                        Console.WriteLine("Day " + i +" Employee Wage is = " + partTimeWage);
                        values[i]=partTimeWage;
                        break;
                    case 0:
                        Console.WriteLine("Employee Absent");
                        Console.WriteLine("Day " + i + " Employee Wage is = " + 0);
                        values[i]=0;
                        break;
                }
            }
               
        }
    }
}
