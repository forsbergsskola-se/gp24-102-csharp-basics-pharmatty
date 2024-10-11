using System.Globalization;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

string Question = "Give me a number";
Console.WriteLine(Question);

string input = Console.ReadLine();
float NumberAsDouble = float.Parse(input);

Console.WriteLine(NumberAsDouble);

int i = (int)NumberAsDouble;
string finalNumber = i.ToString();

Console.WriteLine(finalNumber);