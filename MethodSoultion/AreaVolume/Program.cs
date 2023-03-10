// See https://aka.ms/new-console-template for more information
Console.WriteLine("Method Problems 3 Question 4 Area and Volume\n\n");

int length, width;
string menuChoice = "";

length = PromptForInt("Enter your length (such as 5):");
width = PromptForInt("Enter your width (such as 32):");
do
{
    menuChoice = ShowMenu();
    switch (menuChoice.ToUpper())
    {
        case "A":
        {
                Console.WriteLine($" the area of a rectangle: length {length} and width {width} is\t" +
                                        CalculateArea(length, width));
                Console.Write("\nTry Again? Enter Y to try again.\t");
                menuChoice = Console.ReadLine();
                break;
        }
        case "B":
        {
                Console.WriteLine($" the volume of 10 unit height rectangle: length {length} and width {width} is\t" +
                                       CalculateVolume(length, width));
                Console.Write("\nTry Again? Enter Y to try again.\t");
                menuChoice = Console.ReadLine();
                break;
        }
        default:
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\t\tYour choice of {menuChoice} is invalid\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nTry Again? Enter Y to try again.\t");
            menuChoice = Console.ReadLine();
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


    bool IsPostive(int value)
{
    bool valid = false;
    if (value >= 0)
    {
        valid = true;
    }
    return valid;
}

string ShowMenu()
{
    string menuChoice = "";
    Console.WriteLine("Area or Volume\n");
    Console.WriteLine("a) Area");
    Console.WriteLine("b) Volume");
    Console.Write("Enter your calculation:\t");
    menuChoice = Console.ReadLine();
    return menuChoice;
}

int CalculateArea(int length, int width)
{
    return length * width;
}

int CalculateVolume(int length, int width)
{
    return width * length * 10;
}