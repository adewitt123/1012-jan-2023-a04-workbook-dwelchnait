// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nInvestigate Variable Scope and Ternary Operator\n\n");

//Scope
//scope refers to the visibility of a variable within your program
//scope of a variable depends on where the variable is declared

//if a variable is declared at the top level of your program then
//      the variable is "known" to all the code in your program
//if a variable is declared WITHIN a lower coding block ({ ..... }) then
//      the variable is "known" ONLY within that coding block

int topLevelVariable = 76;
int topLevelSum = 0;

if (topLevelVariable > 0)
{
    //the "life" of any variable is within the level of "known" visibility
    //  where the variable is declared

    //this this example 
    //  topLevelVariable and topLevelSum were declared at the upper most
    //          level of this program, therefore, these variable are 
    //          "known/alive" to all code in the program
    //
    // HOWEVER
    //  withnCodingBlockVariable has been declared within the lower level
    //          coding block.
    //  this variable is ONLY "known/alive" to this coding block AND any
    //          lower level coding block WITHIN this coding block.
    //  IT IS NOT "known/alive" to ANY code ABOVE this coding block
    //
    int withinCodingBlockVariable = 3;
    topLevelSum = topLevelVariable - withinCodingBlockVariable;
    Console.WriteLine($"topLevelVariable {topLevelVariable}" +
        $" - withinCodingBlockVaraible {withinCodingBlockVariable}" +
        $" = topLevelSum {topLevelSum}");

}

//
// the concern with the withinCodingBlockvariable on the following statement
//      is the fact that the variable is "OUT OF SCOPE"
// the variable was coded at a lower coding block level
//
//Console.WriteLine($"topLevelVariable {topLevelVariable}" +
//       $" - withinCodingBlockVaraible {withinCodingBlockVariable}" +
//       $" = topLevelSum {topLevelSum}");


//Ternary Operator

string evenOrOdd = "unknown";
Random random = new Random();
int randomNumber = 0;
randomNumber = random.Next(0, 101); //a number between 0 and 100

//coded with an if structure
//why is there NO {...} around the coding blocks for true and false path
//Remember, IF you have a single statement in your coding block
//      you CAN omit of {... } braces around your coding block
//HOWEVER: you MAY decide to be consistent with your { } braces
//          so that you do NOT need to remember all of the technique
//          options for when to use {..} braces
if (randomNumber % 2 == 0)
    evenOrOdd = "even";
else
    evenOrOdd = "odd";

Console.WriteLine($"\n\n Ternary Operator results\n");
Console.WriteLine($"\n Using if structure number ({randomNumber}) is {evenOrOdd}\n");

//coded using the ternary operator
evenOrOdd = randomNumber % 2 == 0 ? "even" : "odd";
Console.WriteLine($"\n Using ternary operator number ({randomNumber}) is {evenOrOdd}\n");
