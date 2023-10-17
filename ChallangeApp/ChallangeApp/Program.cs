﻿using ChallangeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("maks", "piecz");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("dodano nową ocenę");
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception caught: {e.Message}");
    }
}

var statistics = ((EmployeeInFile)employee).GetStatistics();
Console.WriteLine("-----------------------");
Console.WriteLine();
Console.WriteLine(employee.Name + " " + employee.Surname);
Console.WriteLine();
Console.WriteLine("Statystyki:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine();
Console.WriteLine($"Ocena:{statistics.AverageLetter}");







