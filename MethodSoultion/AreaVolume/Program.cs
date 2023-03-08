// See https://aka.ms/new-console-template for more information
Console.WriteLine("Method Problems 3 Question 4 Area and Volume\n\n");

int length, width;
string menuChoice = "";

length = PromptForInt("Enter your length (such as 5):");
width = PromptForInt("Enter your width (such as 32):");
do
{
    menuChoice = ShowMenu();
    switch (menuChoice)
    {
        case "A":
        {
            break;
        }
        case "B":
        {
            break;
        }
        default:
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\t\tYour choice of {menuChoice} is invalid\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Try Again? Enter Y to try again.");
            break;
        }
    }
} while (menuChoice.ToUpper().Equals("Y"));
Console.WriteLine("Bye Bye");

//methods
int PromptForInt(string label)
{
    string inputValue = "";
    int returnValue = 0;
    bool isNumber = true;
    do
    {
        isNumber = true;
        Console.Write($"{label}\t");
        inputValue = Console.ReadLine();
        if (!int.TryParse(inputValue, out returnValue))
        {
            isNumber = false;
            Console.WriteLine($"Entered value {inputValue} is not a number");
        }
        else if(!IsPostive(returnValue))
        {
            isNumber = false;
            Console.WriteLine($"Entered value {inputValue} is not a positive value");
        }
    }while (!isNumber);
    return returnValue;

}


    bool IsPostive(decimal value)
{
    bool valid = false;
    if (value >= 0.0m)
    {
        valid = true;
    }
    return valid;
}

decimal CalculatePay(decimal hours, decimal wage)
{
    decimal grosspay = 0.00m;
    if (hours <= 40.0m)
    {
        grosspay = hours * wage;
    }
    else if (hours <= 50.0m)
    {
        grosspay = (40 * wage) + ((hours - 40) * (wage * 1.5m));
    }
    else
    {
        grosspay = (40 * wage) + (10.0m * (wage * 1.5m)) + ((hours - 50) * (wage * 2.0m));
    }
    return grosspay;
}