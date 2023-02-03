// See https://aka.ms/new-console-template for more information
Console.WriteLine("Loop Concept");

//postfix on own line
int number = 4; // numbers starts out with 4
// Display the value in number.
Console.WriteLine($"\nnumber is {number}");
Console.WriteLine($"I will increment number.");
// Increment number
number++;
// Display the value in number again.
Console.WriteLine($"Now, number is {number}");
Console.WriteLine($"I will decrement number.");
// Decrement number
number--;
// Display the value in number once more.
Console.WriteLine($"Now, number is {number}");

//prefix on own line
number = 4; // numbers starts out with 4
// Display the value in number.
Console.WriteLine($"\nnumber is {number}");
Console.WriteLine($"I will increment number.");
// Increment number
++number;
// Display the value in number again.
Console.WriteLine($"Now, number is {number}");
Console.WriteLine($"I will decrement number.");
// Decrement number
--number;
// Display the value in number once more.
Console.WriteLine($"Now, number is {number}");

//postfix WITHIN Writeline
number = 4; // numbers starts out with 4
// Display the value in number.
Console.WriteLine($"\nnumber is {number}");
Console.WriteLine($"I will increment number.");

// Display the value in number again.
Console.WriteLine($"Now, number is {number++}");
Console.WriteLine($"I will decrement number.");

// Display the value in number once more.
Console.WriteLine($"Now, number is {number--}");

//prefix WITHIN Writeline
number = 4; // numbers starts out with 4
// Display the value in number.
Console.WriteLine($"\nnumber is {number}");
Console.WriteLine($"I will increment number.");

// Display the value in number again.
Console.WriteLine($"Now, number is {++number}");
Console.WriteLine($"I will decrement number.");

// Display the value in number once more.
Console.WriteLine($"Now, number is {--number}");

Console.WriteLine("\nSample output of while loop\n");
number = 1;
while (number <= 5)
{
    Console.WriteLine($"Hello turn number {number}");
    number++;
}