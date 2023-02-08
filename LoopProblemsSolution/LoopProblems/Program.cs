// See https://aka.ms/new-console-template for more information
Console.WriteLine("Loop Problems");

//SumOfSquares(); //calling statement
//AverageOfListOfNumbers();
//ReverseNumber();

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