using ChallangeApp;

var employee = new Employee("Maks", "Pieczynski");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(9);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
