using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_EmployeeWage
{
    public class EmployeeWage
    {
        int empWagePerHour = 20;
        int isFullTime = 8;
        int isPartTime = 4;
        int maxWorkinhHours = 100;
        int maxWorkingDays = 20;
        int empWage = 0;
        int workingHour = 0;
        int hour;
        public void employeeAttendatce() 
        {
            for (int i = 1; i <= maxWorkingDays; i++)
            {
                if (workingHour < maxWorkinhHours)
                {
                    Random random = new Random();
                    int attendance = random.Next(3);
                    switch (attendance)
                    {
                        case 1:
                            Console.WriteLine("Employee Fulltime");
                            Console.WriteLine("Day " + i + " Employee Wage is = " + isFullTime);
                            hour = 8;
                            break;
                        case 2:
                            Console.WriteLine("Employee Parttime");
                            Console.WriteLine("Day " + i + " Employee Wage is = " + isPartTime);
                            hour = 4;
                            break;
                        case 0:
                            Console.WriteLine("Employee Absent");
                            Console.WriteLine("Day " + i + " Employee Wage is = " + 0);
                            hour = 0;
                            break;
                    }
                    int dailyWage = hour * empWagePerHour;
                    empWage = empWage + dailyWage;
                    workingHour = workingHour + hour;

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Total Employee Wage = " + empWage);
            Console.WriteLine("Total Employee Working Hour = " + workingHour);
        }
    }
}
