// See https://aka.ms/new-console-template for more information
Console.WriteLine("A Structure World");

//Investigate Methods
//
//purpose
//a) structure code for easier maintenance
//b) compress overall code by modularizing common code

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
        RollDice();                 //calling statement
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

void RollDice()
{
    Random rnd = new Random();
    int dieFace = 1; //chose 1 as the valid value over the numeric default of 0
    dieFace = rnd.Next(1, 7);
    Console.WriteLine($"The die face says {dieFace}");
}