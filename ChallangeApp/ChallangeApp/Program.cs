using System.ComponentModel.Design;

int number = 4594;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();

int[] counter = new int[10];

for (int i = 0; i <= 9; i++)
{
    counter[i] = 0;
}

foreach (char letter in letters)
{
    if (letter == '0') counter[0]++;
    else if (letter == '1') counter[1]++;
    else if (letter == '2') counter[2]++;
    else if (letter == '3') counter[3]++;
    else if (letter == '4') counter[4]++;
    else if (letter == '5') counter[5]++;
    else if (letter == '6') counter[6]++;
    else if (letter == '7') counter[7]++;
    else if (letter == '8') counter[8]++;
    else if (letter == '9') counter[9]++;
}

Console.WriteLine("Liczba ->" + number);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Cyfra" + i + "->" + counter[i]);
}