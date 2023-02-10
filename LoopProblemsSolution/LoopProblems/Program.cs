// See https://aka.ms/new-console-template for more information
Console.WriteLine("Loop Problems");

//SumOfSquares(); //calling statement
//AverageOfListOfNumbers();
//ReverseNumber();
GuessThatNumber();

void SumOfSquares() //the method
{
    Console.WriteLine("\nSum Of Squares\n");

    //all the variables used in this coding block
    //  are ONLY "known" to this coding block (variable scope)
    int mySquare = 0;
    string inputValue;
    int mySumOfSquares=0;   
    int counter =0;

    Console.Write("Enter an positive non zero integer from 1 to 10");
    inputValue = Console.ReadLine();
    mySquare = int.Parse(inputValue);

    //1) what do I need to repeat
    //2) surround the repeating code with a loop structure
    //3) setup your continuation condition and looping increment control
   
    Console.Write("\nSum of these squares ");

    //solution 1
    //counter = 1;
    //while (counter <= mySquare)
    //{
    //    Console.Write($" {counter}x{counter} ");
    //    mySumOfSquares += counter * counter;
    //    counter++;

    //}

    //solution 2
    for (counter = 1; counter <= mySquare; counter++)
    {
        Console.Write($" {counter}x{counter} ");
        mySumOfSquares += counter * counter;
    }
    Console.Write($" is = {mySumOfSquares}");
}

void AverageOfListOfNumbers()
{
    Console.WriteLine("\nAverage of List of Numbers\n");
    string inputValue;
    //double sumOfNumbers = 0;
    int sumOfNumbers = 0;
    int number = 0;
    int countOfNumbers = 0;
    double averageOfNumbers = 0;

    //1) what is the repeated code
    //      prompt for a number
    //      test that it is not 0
    //      count number
    //      add to running total of numbers

    //2) surround with looping structure
    //      need to do the loop logic at least once
    //      consider using a Post-Test (do/while)

    //3) create your continuation condition

    do
    {
        Console.Write("\nEnter a number to average OR 0 to exit: ");
        inputValue = Console.ReadLine();
        number = int.Parse(inputValue);
        if (number != 0)
        {
            countOfNumbers++;
            sumOfNumbers += number; // a = a + b
        }
    }while (number != 0);

    //test to see if a set of number were enter and NOT just a 0 on the first prompt

    if (countOfNumbers == 0)
    {
        averageOfNumbers = 0;
    }
    else
    {
        //calculate and display the average
        //if you divide integer by integer, you are doing integer division which means NO decimal remainder
        //division needs to be done using a decimal type number: double or decimal
        //2 solutions
        //  a) treat your sumOfNumbers as a double/decimal
        //  b) use type casting on your variable
        //averageOfNumbers = sumOfNumbers / countOfNumbers;
        averageOfNumbers = (double)sumOfNumbers / countOfNumbers; //type cast integer sumOfNumbers to a double
    }
    Console.WriteLine($"\nAverage of the {countOfNumbers} entered is {averageOfNumbers}");
}

void ReverseNumber()
{
    string inputValue;
    int lengthOfString = 0;
    string stringDigit;

    Console.WriteLine("\nPrint digit string in Reserve\n");

    Console.Write("Enter a string of digits, no spaces: ");
    inputValue= Console.ReadLine();

    //Instead of assuming that the input value is small
    //      enough to be an integer/long this solution
    //      will treat the inptut value as a string

    //determine # of times through the loop
    //the number of times through the loop is the
    //  number of digits in the string
    //the string class: Length property of strings
    lengthOfString = inputValue.Length; //natural count

    //repeatitive code
    //start the counter at the end of the string (length)
    //move in the direction of the head of the string (decrement)
    //the lenthOfString is a natural count  1,2,3,4....
    //the loop needs to use an index count  0,1,2,3 .....

    Console.WriteLine("\n For loop processing\n");
    for (int counter = lengthOfString-1;
            counter >=0; counter--)
    {
        //extract the last character of the string
        //the .Substring(indexofcharacter, length of characters)
        stringDigit = inputValue.Substring(counter, 1);
        //write that character out to the console
        Console.WriteLine(stringDigit);
        
    }

    Console.WriteLine("\n while loop processing\n");
    int counter2 = lengthOfString-1;
    while(counter2 >=0)
    {
        stringDigit = inputValue.Substring(counter2, 1);
        Console.WriteLine(stringDigit);
        counter2--;
    }
}

void GuessThatNumber()
{
    Random random = new Random();  //this is the random number generator

    Console.WriteLine("\nGuess that random number\n");

    //the random number generator can limit the range of values
    //the number generated is from the lowest value inclusive to the higest number - 1 inclusive
    // between 1 and 100 inclusive, use 1 and 101
    int targetNumber = random.Next(1, 101);

    string inputValue;
    int guessCounts = 0;
    int guessNumber = 0;

    Console.WriteLine("\nGuess a number between 1 and 100. How many times will it take you?\n");
    //since we need to do the code at least once
    //consider using a do while (post test) loop
    do
    {
        Console.Write("Enter your guess: ");
        inputValue = Console.ReadLine();
        guessNumber = int.Parse(inputValue);
        guessCounts++;

        if (guessNumber == targetNumber)
        {
            Console.WriteLine(("\n Correct that is my secret number\n"));
        }
        else
        {
            if (guessNumber < targetNumber)
            {
                Console.WriteLine("You guess was too low");
            }
            else
            {
                Console.WriteLine("You guess was too high");
            }
        }
    } while (guessNumber != targetNumber);
    Console.WriteLine($"\nYou  guess the number {targetNumber} in {guessCounts} times.");
}