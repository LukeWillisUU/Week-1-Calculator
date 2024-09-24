// See https://aka.ms/new-console-template for more information
//Variable names should be short and meaningful
//first number variable
Console.WriteLine("Type in the first number followed by the Enter key");
int firstnumber = Convert.ToInt32(Console.ReadLine());
//second number variable

Console.WriteLine("Type in the second number followed by the Enter key");
int secondnumber = Convert.ToInt32(Console.ReadLine());

//perform the calculation

int result = firstnumber + secondnumber;

//output answer to the console
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstnumber, secondnumber, result);


