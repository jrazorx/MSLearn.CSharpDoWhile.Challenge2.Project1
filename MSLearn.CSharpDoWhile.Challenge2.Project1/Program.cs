string? readResult;
int numericResult = 0;
bool isNumberInput = false;
bool isValidInput = false;



/*
 * This code block asks the user to input a number between 5 and 10
 * It checks if the input is a number and between 5 and 10
 * Displays an error message if the input is invalid
 * The loop will only exit upon valid input, and print a successful message
*/
Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();

    if (readResult == null)
        continue;
    else
        isNumberInput = int.TryParse(readResult, out numericResult);

    if (!isNumberInput)
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    else if (isNumberInput && numericResult >= 5 && numericResult <= 10)
        isValidInput = true;
    else
        Console.WriteLine($"You entered {numericResult}. Please enter a number between 5 and 10.");


} while (isValidInput == false);

Console.WriteLine($"Your input value ({numericResult}) has been accepted.");