// See https://aka.ms/new-console-template for more information
Console.WriteLine("Loop Concept");

//IncrementDecrement();
//WhileWithIncrement();
//WhilePreTestSample();
//WhilePassFailExercise(); //calling statement
//DoWhilePostTestSample();
//ForPreTestSample();
MenuSample();

void IncrementDecrement()
{
    //postfix on own line
    int number = 4; // numbers starts out with 4
                    // Display the value in number.
    Console.WriteLine($"\nnumber is {number}");
    Console.WriteLine($"I will increment number.");
    // Increment number
    number++;
    // Display the value in number again.
    Console.WriteLine($"Now, number is {number}");
    Console.WriteLine($"I will decrement number.");
    // Decrement number
    number--;
    // Display the value in number once more.
    Console.WriteLine($"Now, number is {number}");

    //prefix on own line
    number = 4; // numbers starts out with 4
                // Display the value in number.
    Console.WriteLine($"\nnumber is {number}");
    Console.WriteLine($"I will increment number.");
    // Increment number
    ++number;
    // Display the value in number again.
    Console.WriteLine($"Now, number is {number}");
    Console.WriteLine($"I will decrement number.");
    // Decrement number
    --number;
    // Display the value in number once more.
    Console.WriteLine($"Now, number is {number}");

    //postfix WITHIN Writeline
    number = 4; // numbers starts out with 4
                // Display the value in number.
    Console.WriteLine($"\nnumber is {number}");
    Console.WriteLine($"I will increment number.");

    // Display the value in number again.
    Console.WriteLine($"Now, number is {number++}");
    Console.WriteLine($"I will decrement number.");

    // Display the value in number once more.
    Console.WriteLine($"Now, number is {number--}");

    //prefix WITHIN Writeline
    number = 4; // numbers starts out with 4
                // Display the value in number.
    Console.WriteLine($"\nnumber is {number}");
    Console.WriteLine($"I will increment number.");

    // Display the value in number again.
    Console.WriteLine($"Now, number is {++number}");
    Console.WriteLine($"I will decrement number.");

    // Display the value in number once more.
    Console.WriteLine($"Now, number is {--number}");
}

void WhileWithIncrement()
{
    Console.WriteLine("\nSample output of while loop\n");
    int number = 1;
    while (number <= 5)
    {
        Console.WriteLine($"Hello turn number {number}");
        number++;
    }
}

void WhilePreTestSample()
{
    Random keygen = new Random();
    int number1 = keygen.Next(1, 10);
    int number2 = keygen.Next(1, 10);
    int correctAnswer = number1 + number2;
    Console.Write($"What is {number1} + {number2} = ? ");
    int userAnswer = int.Parse(Console.ReadLine());
    while (userAnswer != correctAnswer)
    {
        Console.WriteLine("Wrong answer. Try again.");
        Console.Write($"What is {number1} + {number2} = ? ");
        userAnswer = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("You got it.");
}

void WhilePassFailExercise()
{
    int Pass = 0, Fail = 0, counter = 0, answer = 0;
    string inputValue;
    while (counter < 10) //condition for continuing: true continue false stop
    {
        Console.Write("Enter result: Pass=1,Fail=2");
        inputValue = Console.ReadLine();
        answer = int.Parse(inputValue);
        if (answer == 1)
            //Pass = Pass + anothervalue;
            //Pass += anothervalue;
            Pass++; //increment of 1
        else
            Fail++;
        //since you are taking care of the number of times thru
        //  the loop, you must incremenet the loop counter
        counter++;
    }
    Console.WriteLine($"Pass: {Pass}");
    Console.WriteLine($"Fail: {Fail}");
}

void DoWhilePostTestSample()
{
    int data;
    int sum = 0;
    // Keep reading data until the input is 0
    do
    {
        Console.Write("Enter an integer (the input ends if it is 0): ");
        data = int.Parse(Console.ReadLine());
        sum += data;
    } while (data != 0);
    Console.WriteLine($"The sum is {sum}");
}

void ForPreTestSample()
{
    int number; // Loop control variable
    Console.WriteLine($"{"Number",-10} {"Number Squared",15}");
    Console.WriteLine($"-------------------------");

    //NOte the declaration of number could have been done within
    //  the for statement itself
    // for (int number = 1; ....;....)
    for (number = 1; number <= 10; number++)
    {
        Console.WriteLine($"{number,-10} {number * number,15}");
    }
}

void MenuSample()
{
    //using a sentinel value
    string choice = "";
    string meal = "";
    do //this is a post test loop
    {
        Console.WriteLine("\nChoose your favourite meal:");
        Console.WriteLine("B for Breakfast");
        Console.WriteLine("L for Lunch");
        Console.WriteLine("D for Dinner");
        Console.Write("Enter your choice: ");
        meal = Console.ReadLine();
        switch (meal.ToUpper())
        {
            case "B":
                {
                    Console.WriteLine("You like Breakfast");
                    break;
                }
            case "L":
                {
                    Console.WriteLine("You like Lunch");
                    break;
                }
            case "D":
                {
                    Console.WriteLine("You like Dinner");
                    break;
                }
            default:
                {
                    Console.WriteLine("Your choice is invalid");
                    break;
                }
                //sentinel value is obtained
               
        }
        Console.Write("\nWould your like to try again Y or N");
        choice = Console.ReadLine();

    } while (choice == "Y" || choice == "y");
}