using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_EmployeeWage
{
    public interface rules
    {
        public void computeEmpWage();
        public int computeEmpWage(string[] args);
        public void totalEmpWage(string[] args);
    }
    public class builder
    {
        private LinkedList<EmployeeWage> companyEmpWageList;
        private Dictionary<string, EmployeeWage> empWageDictionary;
        int empWage = 0, workingHour = 0, hour;

        public builder()
        {
            this.companyEmpWageList = new LinkedList<EmployeeWage>();
            this.empWageDictionary = new Dictionary<string, EmployeeWage>();
        }

        public void addDetails(string companyName, int empWagePerHour, int maxWorkinhHours, int maxWorkingDays)
        {
            EmployeeWage EmployeeWage = new EmployeeWage(companyName, empWagePerHour, maxWorkinhHours, maxWorkingDays);
            this.companyEmpWageList.AddLast(EmployeeWage);
            this.empWageDictionary.Add(companyName , EmployeeWage);
        }
        public void computeEmpWage()
        {
            foreach(EmployeeWage EmployeeWage in this.companyEmpWageList)
            {
                EmployeeWage.totalEmpWage(this.computeEmpWage(EmployeeWage));
                Console.WriteLine(EmployeeWage.companyNameAndSalary());
            }
        }
        public int computeEmpWage(EmployeeWage EmployeeWage)
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
        public int getTotalWage(string companyName)
        {
            return this.empWageDictionary[companyName].empWage;
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
