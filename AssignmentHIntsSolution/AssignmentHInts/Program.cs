// See https://aka.ms/new-console-template for more information

//TestClearingConsole();
TestStringPadLeft();



void TestClearingConsole()
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");

    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("This should be the top line");
    Console.ReadLine();
}

void TestStringPadLeft()
{
    for (int i = 1; i <= 5; i++)
    {
        for (int j = 0; j < 10; j++)

        {
            Console.Write($"{j}");
        }
    }
    Console.WriteLine("");
    string myString = "thisisalotofcharacters";
    for (int i = 0; i <= 50; i = i + 5)
    {
        Console.WriteLine(myString.PadLeft(i,'*'));
    }
}
