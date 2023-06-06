using System.ComponentModel.Design;

var name = ("Ewa");
bool woman = true;
var age = 33;
if (age < 30 && woman)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (age == 33 && woman && name == "Ewa")
{
    Console.WriteLine("Ewa lat 33");
}
else if (age < 18 && woman == false)
{
    Console.WriteLine("niepełnoletni mężczyzna");
}

