using System.ComponentModel.Design;

var name = "Ewa";
bool woman = true;
var age = 33;

if (woman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (woman == true && name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
if (woman == false && age < 18)
{
    Console.WriteLine("niepełnoletni mężczyzna");
}
