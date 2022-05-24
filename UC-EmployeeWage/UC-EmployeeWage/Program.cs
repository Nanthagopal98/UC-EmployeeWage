// See https://aka.ms/new-console-template for more information
UC_EmployeeWage.builder run = new UC_EmployeeWage.builder();
run.addDetails("XYZ Company", 20,100,20);
run.addDetails("ABC Company", 30, 80, 15);
run.computeEmpWage();
Console.WriteLine("Total Employe Wage for ABC Company is = " + run.getTotalWage("ABC Company"));