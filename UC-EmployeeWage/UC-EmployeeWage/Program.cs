// See https://aka.ms/new-console-template for more information
UC_EmployeeWage.EmployeeWage company1= new UC_EmployeeWage.EmployeeWage();
company1.employeeAttendatce( "XYZ Company", 20, 100, 20);
Console.WriteLine(company1.companyNameAndSalary());
Console.WriteLine();
UC_EmployeeWage.EmployeeWage company2 = new UC_EmployeeWage.EmployeeWage();
company2.employeeAttendatce("ABC Company", 30, 80, 15);
Console.WriteLine(company2.companyNameAndSalary());