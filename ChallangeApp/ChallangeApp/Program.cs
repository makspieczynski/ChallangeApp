using ChallangeApp;

Employee employee1 = new Employee("Adam","Siecla", "18");
Employee employee2 = new Employee("Mikołaj", "Jarożek", "32");
Employee employee3 = new Employee("Damian", "Mikołajewski", "22");


employee1.AddGrade(5);
employee1.AddGrade(2);
employee1.AddGrade(7);  
employee1.AddGrade(2);
employee1.AddGrade(9);

employee2.AddGrade(4);
employee2.AddGrade(8);
employee2.AddGrade(6);  
employee2.AddGrade(6);
employee2.AddGrade(3);

employee3.AddGrade(4);
employee3.AddGrade(5);
employee3.AddGrade(10); 
employee3.AddGrade(2);
employee3.AddGrade(2);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};
int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine(employeeWithMaxResult.Name + employeeWithMaxResult.Surname );
Console.WriteLine( "wiek" + employeeWithMaxResult.Age + "punkty" + employeeWithMaxResult.Result);






