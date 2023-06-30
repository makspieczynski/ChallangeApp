using ChallangeApp;

var employee = new Employee("Maks", "Pieczynski");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(6);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


