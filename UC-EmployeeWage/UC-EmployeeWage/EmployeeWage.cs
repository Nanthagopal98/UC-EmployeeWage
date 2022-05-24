using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_EmployeeWage
{
    public class bulider
    {
        private int numberOfCompanies = 0;
        private EmployeeWage[] companyEmpWagearray;
        int empWage = 0, workingHour = 0, hour;

        public bulider()
        {
            this.companyEmpWagearray = new EmployeeWage[5];
        }

        public void addtoArray(string companyName, int empWagePerHour, int maxWorkinhHours, int maxWorkingDays)
        {
            companyEmpWagearray[this.numberOfCompanies] = new EmployeeWage(companyName, empWagePerHour, maxWorkinhHours, maxWorkingDays);
            numberOfCompanies++;
        }
        public void computeEmpWage()
        {
            for(int i = 0; i < numberOfCompanies; i++)
            {
                companyEmpWagearray[i].totalEmpWage((this.computeEmpWage(this.companyEmpWagearray[i])));
                Console.WriteLine(this.companyEmpWagearray[i].companyNameAndSalary());
            }
        }
        private int computeEmpWage(EmployeeWage EmployeeWage)
        {
            int dailyWage;
            while (empWage <= EmployeeWage.maxWorkinhHours && workingHour <= EmployeeWage.maxWorkingDays)
            {
                Random random = new Random();
                int attendance = random.Next(3);
                switch (attendance)
                {
                    case 1:
                        //Console.WriteLine("Employee Fulltime");
                        //Console.WriteLine("Day " + i + " Employee Wage is = " + isFullTime);
                        hour = 8;
                        break;
                    case 2:
                        // Console.WriteLine("Employee Parttime");
                        // Console.WriteLine("Day " + i + " Employee Wage is = " + isPartTime);
                        hour = 4;
                        break;
                    case 0:
                        // Console.WriteLine("Employee Absent");
                        // Console.WriteLine("Day " + i + " Employee Wage is = " + 0);
                        hour = 0;
                        break;
                }
                workingHour += hour;
                dailyWage = hour * EmployeeWage.empWagePerHour;
            }
            return empWage = workingHour * EmployeeWage.empWagePerHour;
        }
        
    }

    public class EmployeeWage
    {
        public string companyName;
        public int empWagePerHour;
        public int maxWorkinhHours;
        public int maxWorkingDays;
        public int empWage;

        public EmployeeWage(string companyName, int empWagePerHour, int maxWorkinhHours, int maxWorkingDays)
        {
            this.companyName = companyName; ;
            this.empWagePerHour = empWagePerHour;
            this.maxWorkinhHours = maxWorkinhHours;
            this.maxWorkingDays = maxWorkingDays;
        }
        public string companyNameAndSalary()
        {
            return "Company Name : " + this.companyName + "\nEmployrrSalary : " + this.empWage;
        }
        public void totalEmpWage(int empWage)
        {
            this.empWage = empWage;
        }
    }

}
