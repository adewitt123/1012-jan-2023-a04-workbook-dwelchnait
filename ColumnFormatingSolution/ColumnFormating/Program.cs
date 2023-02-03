// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nColumn Composite Formatting on WriteLine\n");

// https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting


//the syntax for column formatting is easiest used in the format layout
//      structure of the WriteLine statement

//format layout
//    Console.WriteLine("{0} next field {1} another field {2}",
//                    valueFor0,valueFor1,valueFor2);

//how does one do column formating
//this is used to ENSURE value properly align in your output
//this CANNOT be guarantteed using escape tab \t

//syntax: place the column formating with your placeholder index
//
//  use 10 spaces for the first value, left aligned
//   {0, -10}
//
//  use 15 spaces for the second value, right aligned
//   {1, 15}
//
//  place any detail format structure for the column after
//      the column size
//   {2, 8:c}          c is a currency display including the $ sign
//   {2, 8:#,##0.00}   custom pattern for number # optional digit, 0 non-optional digit
//   {2, 15:MMM dd, yyyy}

//syntax pattern is  {index, [-]columnwidth [:custom display pattern]}
//                   {0, 10:c}
string myName = "Don";
string theCourse = "CPSC1012";
double myHourlyWage = 108.52;
DateTime myDate = DateTime.Today;

Console.WriteLine("{0} {1} {2}", myName, theCourse, myHourlyWage);

Console.WriteLine("{0, -10} {1, 15} {2,-15:c}",myName,theCourse,myHourlyWage);
Console.WriteLine("{0, -10} {1, -15} {2,15:#,##0.00}", myName, theCourse, myHourlyWage);
Console.WriteLine("{0, -10} {1, 15} {2,15:c}", myName, theCourse, myHourlyWage);
Console.WriteLine("{0, -10} {1, 15} {2,-15:#,##0.00}", myName, theCourse, myHourlyWage);

Console.WriteLine("{0, -10} {1, -15} {2,-15:MMM dd, yyyy}", myName, theCourse, myDate);