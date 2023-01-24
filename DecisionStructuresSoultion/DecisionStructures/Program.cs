// See https://aka.ms/new-console-template for more information

//Decisions are used to allow your program to have different criterial paths
//  to follow to accomplish the task

//syntax
// the basic decision statement uses the "if" statement
// the structure contains a testing condition(s)
// which allows for two paths: true path and false path

//    if (condition)
//    {
//       true path statement(s)
//    }
//   [else
//    {
//      false path statement(s)
//    }]

//is the number even or odd
using System.Data;

Random rdn = new Random();

int aNumber = rdn.Next(100);

Console.WriteLine($"\nThe number to test is {aNumber}\n");

//Modulas is an arthmetic operator (%) will returns the remainder portion of a division
//first: the arthmetic operation will run
//second: the result of the operation will be tested against the value 0
//        the test operator (relative operator) is the equal condition
//third: the test operator will resolve to a boolean true or false
if (aNumber % 2 == 0)
{
    Console.WriteLine($"You number is even\n");
}
else
{
    Console.WriteLine($"You number is odd\n");
}

//descision without an else

string inputValue;
//char values are a single character
//the literal for a single character uses single quotes
char raining = 'n';
char snowing = 'n';
char warm ='n';
Console.Write("Is it raining out (y/n)");
inputValue = Console.ReadLine();
raining = char.Parse(inputValue);

if (raining == 'y')
{
    Console.WriteLine($"Wear a raincoat then.\n");
}

Console.Write("Is it snowing out (y/n)");
inputValue = Console.ReadLine();
snowing = char.Parse(inputValue);

if (snowing == 'y')
{
    Console.WriteLine($"Wear a winter coat then.\n");
}

Console.Write("Is it warm out (y/n)");
inputValue = Console.ReadLine();
warm = char.Parse(inputValue);

if (warm == 'y')
{
    Console.WriteLine($"Do not need to wear a coat then.\n");
}
