// See https://aka.ms/new-console-template for more information
Console.WriteLine("Method Problems 3 Question 3 Calculate Pay\n\n");

decimal wage, hours, grosspay;
wage = PromptForDecimal("Enter your hourly wage (25.35):");
if (IsPostive(wage))
{
    hours = PromptForDecimal("Enter your hours worked (32.5):");
    if (IsPostive(hours))
    {
        Console.WriteLine($"Your gross pay is " +
                       $" ${CalculatePay(hours,wage).ToString()}");
    }
    else
    {
        Console.WriteLine("Entered value is not valid");
        Console.WriteLine("Due to error(s), unable to continue. Start again");
    }
}
else
{
    Console.WriteLine("Entered value is not valid");
    Console.WriteLine("Due to error(s), unable to continue. Start again");
}

//methods
decimal PromptForDecimal(string label)
{
    string inputValue = "";
    decimal returnValue = 0;
    Console.Write($"{label}\t");
    inputValue = Console.ReadLine();
    if (!decimal.TryParse(inputValue, out returnValue))
    {
        Console.WriteLine($"Entered value {inputValue} is not a number");
        returnValue = -1.0m;
    }
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