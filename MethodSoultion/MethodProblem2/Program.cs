// See https://aka.ms/new-console-template for more information
Console.WriteLine("Method Problem 2\n\n");

//driver
DisplayMenu();
int menuChoice = PromptForInt("Enter ticket choice:");
if (menuChoice > 0 && menuChoice < 5)
{
    decimal ticketprice = TicketPrice(menuChoice);
    Console.WriteLine(ticketprice.ToString("$#0.00"));
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\n\t\tInvalid menu choice. Unable to process ticket request\n");
    Console.ForegroundColor = ConsoleColor.White;
}

//method helpers
string Prompt(string label)
{
    string inputValue = "";
    Console.Write($"{label}\t");
    inputValue = Console.ReadLine();
    return inputValue;
}
int PromptForInt(string label)
{
    string inputValue = "";
    int returnValue = 0;
    Console.Write($"{label}\t");
    inputValue = Console.ReadLine();
    if (!int.TryParse(inputValue, out returnValue))
    {
        Console.WriteLine($"Entered value {inputValue} is not a whole number");
    }
    return returnValue;

}

void DisplayMenu()
{
    Console.WriteLine("Ticket Options\n");
    Console.WriteLine("1) Children 6 and under are Free ($0.00)");
    Console.WriteLine("2) Students 7 to 17 are $9.80");
    Console.WriteLine("3) Adults 18 to 54 are $11.35");
    Console.WriteLine("4) Seniors 55+ are $10.00\n");
}

decimal TicketPrice(int option)
{
    decimal price = 0.0m;
    switch(option)
    {
        case 1:
            {
                price = 0.00m; break;
            }
        case 2:
            {
                price = 9.80m; break;
            }
        case 3:
            {
                price = 11.35m; break;
            }
        case 4:
            {
                price = 10.00m; break;
            }
        default:
            {
                price = 0.00m; break;
            }
    }
    return price;
}