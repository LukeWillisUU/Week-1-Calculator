// See https://aka.ms/new-console-template for more information
//Variable names should be short and meaningful
//first number variable

using System.Xml.Serialization;

CalculatorApp();

void CalculatorApp()
{

    //Declare the variables and initialise them to 0.
    int firstnumber = 0;
    int secondnumber = 0;
    int result = 0;
    int choice = 0;

    Console.WriteLine("Type in the first number followed by the Enter key");
    firstnumber = Convert.ToInt32(Console.ReadLine());
    //second number variable

    Console.WriteLine("Type in the second number followed by the Enter key");
    secondnumber = Convert.ToInt32(Console.ReadLine());

    //use a loop to make the relevant decision
    //and perforn the requested math operation

    Console.WriteLine("Choose an option form the following list.");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    //convert user input string into integer.
    choice = Convert.ToInt32(Console.ReadLine());

    //Use an IF statement to perform the selected math operation
    if (choice ==1)
    {
        result = firstnumber + secondnumber;
        Console.WriteLine($"Adding {firstnumber} and {secondnumber} equals {result}", firstnumber, secondnumber, result);

    }
    else if (choice ==2)
    {
        result = firstnumber - secondnumber;
        Console.WriteLine($"Subtracting {int = firstnumber} from {secondnumber} equals {result}");
    }
    else if (choice ==3)
    {
        result = firstnumber / secondnumber;
        Console.WriteLine($"Dividing {firstnumber} by {secondnumber} equals {result}");
    }
    else if (choice == 4)
    {
        result = firstnumber * secondnumber;
        Console.WriteLine($"Multiplying {firstnumber} by {secondnumber} equals {result}");
    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1-4");
    }

    //output answer to the console
    Console.WriteLine("The result is: {result}", result);
}

