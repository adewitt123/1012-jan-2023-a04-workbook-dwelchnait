// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Total Change\n\n");
//Driver
int nickels, dimes, quarters, loonies, toonies;
nickels = PromptForInt("Enter your number of nickels");
if (IsPostive(nickels))
{
    dimes = PromptForInt("Enter your number of dimes");
    if (IsPostive(dimes))
    {
        quarters = PromptForInt("Enter your number of quarters");
        if (IsPostive(quarters))
        {
            loonies = PromptForInt("Enter your number of loonies");
            if (IsPostive(loonies))
            {
                toonies = PromptForInt("Enter your number of toonies");
                if (IsPostive(toonies))
                {
                    
                    Console.WriteLine($"Your total change is " +
                        $" ${GetTotal(nickels,dimes,quarters,loonies,toonies).ToString()}");
                }
                else
                {
                    Console.WriteLine("Number for coins entered is not valid");
                    Console.WriteLine("Due to error(s), unable to continue. Start again");
                }
            }
            else
            {
                Console.WriteLine("Number for coins entered is not valid");
                Console.WriteLine("Due to error(s), unable to continue. Start again");
            }
        }
        else
        {
            Console.WriteLine("Number for coins entered is not valid");
            Console.WriteLine("Due to error(s), unable to continue. Start again");
        }
    }
    else
    {
        Console.WriteLine("Number for coins entered is not valid");
        Console.WriteLine("Due to error(s), unable to continue. Start again");
    }
}
else
{
    Console.WriteLine("Number for coins entered is not valid");
    Console.WriteLine("Due to error(s), unable to continue. Start again");
}

//Methods

int PromptForInt(string label)
{
    string inputValue = "";
    int returnValue = 0;
    Console.Write($"{label}\t");
    inputValue = Console.ReadLine();
    if (!int.TryParse(inputValue, out returnValue))
    {
        Console.WriteLine($"Entered value {inputValue} is not a whole number");
        returnValue = -1;
    }
    return returnValue;

}

bool IsPostive(int value)
{
    bool valid = false;
    if (value >= 0)
    {
        valid = true;
    }
    return valid;
}

decimal GetTotal(int nickels,int dimes,int quarters,int loonies,int toonies)
{
    decimal total = 0;
    total = nickels * 0.05m + dimes * 0.10m + quarters * 0.25m
                + loonies * 1.00m + toonies * 2.00m;
    return total;
}