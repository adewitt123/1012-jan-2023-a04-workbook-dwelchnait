// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arithmetic Problem 4");

/*
 * psuedo code is using statements to specific WHAT is to be done
 * 
 * define required variables
 * prompt for input
 * read entered data (assume data is correct)
 * determine 100's digit
 * determine 10's digit
 * determine units digit
 * sum 3 digits
 * display the sum along with the initial input value
 */

string inputValue;
int originalValue, hundredsDigit, tensDigit, unitsDigit;
int totalDigitSum = 0;

// to add an a blank line to your output string
//      you can use \n special character
// you can use any number of special characters in your string
Console.Write("\nEnter a 3 digit whole number (ex: 123): ");

//all input from the console comes in as string type data
//the receiving variable is on the left side of the assignment operator (=)
inputValue = Console.ReadLine();

//convert the string data into a numerical integere value
//this action, referred to as Parsing, can be done in serverals ways
//one techniques is to use datatype.Parse(string) where
//      datatype is the datatye of the receiving variable
//      string is the data to be converted
originalValue = int.Parse(inputValue);
hundredsDigit = originalValue / 100;
//the order of math operations in C# is the same as the accepted
//  principles of operations
//so, one can order the execution of your calculations by
//  use the principle rules of math execution
tensDigit = (originalValue - (hundredsDigit * 100)) / 10;
//to get the remainder of a value in integer fashion
//  you can use an operator called modulas (%)
//this operator will divide the first value by the second returning
//  the integer remainder
unitsDigit = originalValue % 10;

totalDigitSum = hundredsDigit + tensDigit + unitsDigit;

Console.WriteLine($"The digits of {originalValue} add up to the following {totalDigitSum}");
