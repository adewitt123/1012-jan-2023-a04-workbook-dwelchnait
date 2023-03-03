// See https://aka.ms/new-console-template for more information
Console.WriteLine("A Structure World");

//Investigate Methods
//
//purpose
//a) structure code for easier maintenance
//b) compress overall code by modularizing common code
//c) well designed method do one action and return

//this small snippet of code is a "driver routine"

//two component for a method to work
//a) the method code
//    contains is the logic code for the requested action
//    to be completed
//b) the call statement
//      is to request that the action be executed

string choice;
Console.WriteLine("Choice the menu option of choice");  //WriteLine is a method
Console.WriteLine("a) Get Loto Numbers");
Console.WriteLine("b) Row a dice");
Console.Write("Enter your choice: ");
choice = Console.ReadLine();                            //ReadLine is a method
switch (choice.ToUpper())                               //ToUpper is a method
    {
        case "A":
        {
            GetLotoNumbers();           //calling statement

            break;
        }
        case "B":
        {
            string faceString = "";
            int faces = 0;
            int castValue = 0;
            Console.Write("Enter the number of faces your die has: ");
            faceString = Console.ReadLine();
            if (int.TryParse(faceString, out faces))
            {
                if (faces > 1)
                {
                    //Passing a value to a method

                    //to pass data into a method you can use two mechanisms
                    //a) pass by value : passes value type data (int, double, decimal,...)
                    //                   this type of data sends a copy of the value to
                    //                          the method
                    //                   the original data remains unchanged
                    //b) pass by reference : passes reference type data (string, array, object ...)
                    //                   this type of data sends the reference address to 
                    //                          the method
                    //                   changes to reference type data is to the ORIGINAL data
                    //the term used for the values being sent to the method is: arguments
                    //syntax
                    //  methodname([list of arguments])
                    //where the list of argumments are valid C# expressions separated by a comma
                    //C# expressions:
                    //   literal, variable, a method, calculation
                    //your list of arguments MUST
                    //  a) match the number of parameters*
                    //  b) each argument data type must match the receiving method parameter
                    //  c) the order argument MUST align with the order of parameters

                    //Receiving a return value from a method
                    
                    //the return variable must exist in the same scope or above
                    //  as the method
                    //the datatype of the return variable must match that of the
                    //  method returndatatype
                    //return values DO NOT need to be captured
                    //if a method does not have a return datatype, then your call
                    //  statement cannot have return variable
                    castValue = RollDice(faces);                 //calling statement
                    Console.WriteLine($"The die face says {castValue}");
                }
                else
                {
                    Console.WriteLine($"The face coount of {faces} is invalid. Your die must have at least 2 sides");
                }
            }
            else
            {
                Console.WriteLine("The number of faces needs to be a whole number.");
            }
            break;
        }
        default:
        {
                Console.WriteLine($"You menu choice {choice} is invalid.");
            break;
        }
    }

/* ********************************************************************************* */

//Methods
//syntax structure for a method
//create the "signature" of the method
//
//  returndatatype methodname ([parameter list])
//
// returndatatype: is a valid C# data type OR the keyword void
//                 the keyword void means nothing is returned from the method
//                 in the past two names have been used to identify whether
//                      a method returns a value or not
//                      Function: a method that returns a value
//                      Subroutine: a method that does not return a value

// methodname: this is a developer defined name
//             this can be anythng the developer wishes
//             the developer MUST of aware of using methodnames that are in
//                  use by the software the developer is using

// parameter list: this is an optional item on a method
//                 the list may contain 1 or more items separated by a comma
//                 the parameter is a paired set: datatype parametername
//

void GetLotoNumbers()
{
    int numCount = 6;
    Random rnd = new Random();
    int lotoNumber = 0;
    string numbers = "";
    for(int i = 0; i < numCount; i++)
    {
        lotoNumber = rnd.Next(1, 50); //remember the upper limit is NOT inclusive
        if (i == 5)
        {
            numbers = numbers + $"{lotoNumber}";
        }
        else
        {
            numbers = numbers + $"{lotoNumber},";
        }
    }
    Console.WriteLine($"Your lucky number for today are: {numbers}");
}

//methods can receive value via parameters
//methods can receive multiple values
//the method signature parameters are a paired set: datatype localvariablename
//parameteres are NOT to be re-declared as a method variable as being on the
//  parameter list is BEING DECLARED
//all variable and parameters have a limited scope of the method

//method may return or not return a value
//methods that do NOT return a value have returndatatype value of void (keyword)
//methods that DO return a value have a valid C# datatype as the returndatatype
//methods that DO return a value return a single value (instance*
//methods that DO return a value MUST have a return statement
//the syntax of a return statment is:  return valid-C#-expression
//methods that DO return a value place the returndatatype in fron of the methodname
//      instead of the keyword void
//WELL coded methods will have a single return statement
//you MAY have any number of return statements in a method, HOWEVER, multiple return
//  statements indicate a poorly structure method
//Once return statement is executed, you "leave" the method with no further processing
//  of logic within the method
//methods that are void, execute to the end of the code.

int RollDice(int faces)
{
    //the parameter faces is receiving a COPY of the argument value
    
    Random rnd = new Random();
    int dieFace = 1; //chose 1 as the valid value over the numeric default of 0
    dieFace = rnd.Next(1, faces + 1);
    //Console.WriteLine($"The die face says {dieFace}");
    return dieFace;
}