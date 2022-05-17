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
        public void employeeAttendatce() 
        {
            Random random = new Random();
            int attendance = random.Next(2);
            if(attendance==0)
            {
                Console.WriteLine("Employee present");
            }
            else
            {
                Console.WriteLine("Employee absent");
            }
               
        }
    }
}
