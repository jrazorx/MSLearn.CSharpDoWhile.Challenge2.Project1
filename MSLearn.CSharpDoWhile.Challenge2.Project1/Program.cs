string? readResult;
int numericResult = 0;
bool isNumberInput = false;
bool isValidInput = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();

    if (readResult == null)
        continue;
    else
    {
        isNumberInput = int.TryParse(readResult, out numericResult);
        Console.WriteLine(isNumberInput ? "C'est un numérique !" : "C'est pas un numérique ! :(");
    }

} while (isValidInput == false);

//Console.WriteLine($"Your input value ({numericResult}) has been accepted.");