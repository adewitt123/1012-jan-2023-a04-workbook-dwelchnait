// See https://aka.ms/new-console-template for more information

//the \n is call an escape character
//there are several excape characters in C#
// the \n forces your output to add another blank line to the writing
// the Writeline will
//   output a blank line
//   output the text
//   output a blank line
//   move automatically to the next line

Console.WriteLine("\nInvestigate Built-in Math Functions\n");

double aNumber = 49;
double result;

//find the square root of a number
result = Math.Sqrt(aNumber);
Console.WriteLine($"the square root of {aNumber} is {result}\n");
//using PI
Console.WriteLine($"the value of {aNumber} * PI is {aNumber * Math.PI}\n");
//Ceiling returns the intergal portion of a double or decimal raise to the next highest value
Console.WriteLine($"the ceiling value of the double value 5.68 is {Math.Ceiling(5.68)}");
Console.WriteLine($"the ceiling value of the decimal value 5.68 is {Math.Ceiling(5.68m)}\n");
//Floor returns the intergal portion of a double or decimal lowered to the next loweest value
Console.WriteLine($"the floor value of the double value 5.68 is {Math.Floor(5.68)}");
Console.WriteLine($"the floor value of the decimal value 5.68 is {Math.Floor(5.68m)}\n");
//Min and Max results the result of a comparision between two number (either the mimimum or maximum)
Console.WriteLine($"the minimum between 3 and 6 is {Math.Min(6,3)}");
Console.WriteLine($"the maximum between 3 and 6 is {Math.Max(6, 3)}\n");
//raising a value to a power such as 2 to the 3 power (2 X 2 X 2)
Console.WriteLine($"the value of base 2 rasied to the power of 3 (2X2X2) is {Math.Pow(2,3)}\n");
//Truncate will remove the decimals from a double or decimal
Console.WriteLine($"the truncated value of the double 3.1476248 is {Math.Truncate(3.1276248)}");
Console.WriteLine($"the truncated value of the decimal 3.1476248 is {Math.Truncate(3.1276248m)}\n");
//Rounding rounds up a value to the indicate decimal places (value,rounding places)
Console.WriteLine($"the rounded value of 3.1476248 to 2 decimal places is {Math.Round(3.1276248,2)}");
Console.WriteLine($"the rounded value of 3.1476248 to 0 decimal places is {Math.Round(3.1276248, 0)}\n");


//to generate random numbers for your program there there exists a class called Random
//to be able to use this class you must create an instance (occurance, object) of the class
Random rdn = new Random();

// to generate your next random number you will use the method call .Next()

//version 1: no argument supplied to .Next()
//generates a number between 0 and the MaxValue of the number type
Console.WriteLine($"the next random number of an integer without a supplied argument is {rdn.Next()}");
Console.WriteLine($"the next random number of an integer without a supplied argument is {rdn.Next()}");
Console.WriteLine($"the next random number of an integer without a supplied argument is {rdn.Next()}");

//version 2: one argument supplied to .Next(xxx) where xxx is a number
//generates a number between 0 and the argument value - 1 of the number type
Console.WriteLine($"the next random number of an integer with one supplied argument (100) is {rdn.Next(100)}");
Console.WriteLine($"the next random number of an integer with one supplied argument (100) is {rdn.Next(100)}");
Console.WriteLine($"the next random number of an integer with one supplied argument (100) is {rdn.Next(100)}");

//version 3: two arguments supplied to .Next(xxx, xxxx) where xxx is a number
//generates a number between the lower first argument and the higher second argument value - 1 of the number type
//this version specifies a range of values
Console.WriteLine($"the next random number of an integer within a supplied range (1-50) is {rdn.Next(1,50)}");
Console.WriteLine($"the next random number of an integer within a supplied range (1-50) is {rdn.Next(1,50)}");
Console.WriteLine($"the next random number of an integer within a supplied range (1-50) is {rdn.Next(1,50)}");
