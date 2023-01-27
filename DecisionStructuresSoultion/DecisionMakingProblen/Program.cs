// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Problem 1\n\n");

//Write a program that will prompt for a number and display “positive” if 
//    it is greater than zero,
//“negative” if it is less than zero, and “zero” if it is equal to zero.

//declare variables: integer and input string
//declare variable: result message string
//prompt for number
//read and convert
//test if zero
//  set message
//else
//   test if positive
//     set messsage
//   else
//     set message
//display message

int aNumber = 0;
string inputvalue, message;
Console.Write("Enter a whole number: ");
inputvalue = Console.ReadLine();
aNumber = int.Parse(inputvalue);

if(aNumber == 0)
{
    message = "Zero";
}
else
{
    //what is required if the number is not zero
    //this false path will have the next question structure
    //this is called a Nested Descision Structure "nested if"
    if (aNumber > 0)
    {
        message = "positive";
    }
    else
    {
        message = "negative";
    }
}
Console.Write($"You input value of {aNumber} is {message}");

Console.WriteLine("\n\nProblem 2\n\n");

//Write a program that will determine the cost of admission for a theatre. The price of admission
//is based on the age of the customer. Your program should prompt the user for their age and
//then display the correct admission amount.
//• Children 6 and under = FREE ($0.00)
//• Students 7 to 17 = $9.80
//• Adults 18 to 54 = $11.35
//• Seniors 55 + = $10.00

int Age;
double Amount;
string inputValue;
Console.Write("Enter the customer age: ");
inputValue = Console.ReadLine();
Age = int.Parse(inputValue);
//example of single branch ifs
//a coding if style referred to as if/elseif
if (Age <= 6)
{
    Amount = 0.0;
}
else if (Age <= 17)  //7 to 17
{
    Amount = 9.80;
}
else if (Age < 54)
{
    Amount = 11.35;
}
else
{
    Amount = 10.00;
}

Console.WriteLine($"Your ticket costs {Amount.ToString("$#,##0.00")}");
Console.WriteLine($"Your ticket costs {Amount:c}");