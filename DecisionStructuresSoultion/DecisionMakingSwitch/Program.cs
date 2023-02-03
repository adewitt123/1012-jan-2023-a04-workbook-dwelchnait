// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("\nDescision Making Problems with Switch\n");

//Write a program for an Internet service provider so they can calculate how much to bill their
//customers. The provider offers customers 3 packages:
//PACKAGE COST CALCULATION
//    A $9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour
//    B $13.95 per month for up to 20 hours; additional hours are billed at $1.00 per hour
//    C $19.95 per month for unlimited hours
//The program should prompt for the letter of the service package (A, B, or C) and the number of
//hours they have used if either option A or B has been selected.

string inputValue;
string package;
double hours = 0.0;
double cost = 0.0;

Console.WriteLine("Package Options\n");
Console.WriteLine("A $9.95 per month for up to 10 hours");
Console.WriteLine("B $13.95 per month for up to 20 hours");
Console.WriteLine("C $19.95 per month for unlimited hours\n");
Console.Write("Enter the package options you wish: (A,B,C):");
package = Console.ReadLine();
Console.Write("Enter the number of hours (example for package A 5.5):");
inputValue = Console.ReadLine();
hours = double.Parse(inputValue);

//Constants 
//these are values that will not change in a program
//they are used because we assign a meaningful variable name
//if the value associated with a constant is changed in the future
//     such as the hourly shop rate
//now this one variable can be used throughout the program
//since it is declared in one location, if you do need to alter the value
//      you change only one line of code; NOT very line of code in your
//      program that used the variable.
//STANDARD: constant will be coded as CAPITALS
const double APACKAGE = 9.95;
const double APACKAGEOVERAGE = 2.00;
const double BPACKAGE = 13.95;
const double BPACKAGEOVERAGE = 1.00;
const double CPACKAGE = 19.95;
const double APACKAGEHOURLIMIT = 10.0;
const double BPACKAGEHOURLIMIT = 20.0;


//switch statement
//why?
// the test condition will be several values against a signle variable
// the test relative operator is the equal condition *****

//C# is case sensitive    c not equal to C
//there are 2 methods that can be used on strings to
//   ensure up case or lower case for the entire contents
// .ToUpper() and .ToLower()
//to use attach the method to the string variable  stringvariable.ToLower()
switch (package.ToLower())
{
    //case value:   //the test condition is an equal  package == value
    //    {
    //        ...logic ...
    //        break;
    //    }
    //case "A":  // this would be needed if no ToUpper or ToLower was used
    case "a":
        {
            if (hours <= APACKAGEHOURLIMIT)
            {
                cost = hours * APACKAGE;
            }
            else
            {
                cost = APACKAGE * APACKAGEHOURLIMIT + 
                         (hours - APACKAGEHOURLIMIT) * APACKAGEOVERAGE;
            }
            break;
        }
    case "b":
        {
            if (hours <= BPACKAGEHOURLIMIT)
            {
                cost = hours * BPACKAGE;
            }
            else
            {
                cost = BPACKAGE * BPACKAGEHOURLIMIT +
                         (hours - BPACKAGEHOURLIMIT) * BPACKAGEOVERAGE;
            }
            break;
        }
    case "c":
        {
            cost = hours * CPACKAGE;
            break;
        }
    default:  //default executes if non of the above cases are meet
        {
            Console.WriteLine($"\n\t\tPackage value {package} is invalid\n");
            break;
        }
}//eos

if (cost > 0 && hours > 0)
{
    Console.WriteLine($"Your package ({package.ToUpper()}) cost for {hours}" +
        $" hours is {cost:c}");
}












