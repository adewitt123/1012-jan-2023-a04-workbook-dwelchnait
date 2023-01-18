// See https://aka.ms/new-console-template for more information
//line comments start with a set of slashes
/*
 * comment blocks start with a slash-asterisk and terminate with
 *     a asterisk-slash
 */

//declaring variables
// syntax datatype variable name [= value][, variablename [= value]]...
// the initial value for a variable depends on its type
// numerics (int, double, decimal,..) the system default is 0
// reference variables (string, objects) the system default is null
// bool variables the system default is false
// other specialty variables will have their own special system default

int high;   //system default of 0
int low, add, subtract, multiple, divide; //system default of 0
string myName = "Don"; //override system default by assigning your own value
int myAge = 42;  //override system default by assigning your own value
Console.WriteLine($"Hello {myName} to the World! I see you are only {myAge} years old");

//sequence programming structure
//a series of programming statement that execute one after another


//psuedo code: an set of narrative statements indicating the action of your program

//read a value from the console window
//store in the appropriate datatype variable
//read a value from the console window
//store in the appropriate datatype variable
//do a simple math calculation
//display the calculation result on the console window

//when you read a value from the console window it is brought into your program
//  as a string.
string inputValue;
//prompt to the user to enter a value
//the prompt will expect the value to be entered on the same physical console line
Console.Write("Enter a integer numeric value: ");
inputValue = Console.ReadLine(); //value is a string

//to move the value from a string to a non-string value, one needs to convert the
//  value into the receiving datatype
//this can be done using different techniques, we will use datatype.Parse(stringvalue)
high = int.Parse(inputValue);

//at this point in my logic, the value in inputValue can be replace BECAUSE I have
//  saved a copy into the variable high.
Console.Write("Enter a integer numeric value: ");
inputValue = Console.ReadLine(); //value is a string
low = int.Parse(inputValue);

//the action on the right side of the assignment operator (=) is done first
//the result of the actio on the right side is then placed in the variable on the
//  left side of the assignment operator.
add = high + low;
subtract = high - low;
multiple = high * low;
divide = high / low;

// string concatenation (the concatenation operator is the plus sign (+)
Console.WriteLine("The result of adding " + high + " and " + low + " is " + add);

// using a string.Format(" string message {index[:format]} string message {index + 1} ...",
//                          valueforindex, valueforindex+1 [,....])
// the index starts at 0
// each value is indicated in your string by a placeholder index
// each index is incremented by 1
// the list of values for the placeholder is order dependent
Console.WriteLine(string.Format("the result of subtracting {0} and {1} is {2}",
                        high, low, subtract));

Console.WriteLine($"The result of multipling {high} and {low} is {multiple}");
Console.WriteLine($"The result of dividing {high} and {low} is {divide}");



