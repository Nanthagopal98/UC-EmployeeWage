using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_EmployeeWage
{
    public class EmployeeWage
    {
        int empWagePerHour = 20, isFullTime = 8, isPartTime = 4, maxWorkinhHours = 100, maxWorkingDays = 20, empWage = 0, workingHour = 0,hour;
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
