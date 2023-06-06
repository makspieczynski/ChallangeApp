using System.ComponentModel.Design;

var name = ("Ewa");
bool woman = true;
var age = 33;
if (age < 30 && woman && age >= 18)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (age == 35 && woman && name == "Ewa")
{
    Console.WriteLine(name + ", lat" + age);
}
if (age < 18 && woman == false)
{
        Console.WriteLine("niepełnoletni mężczyzna");
}

