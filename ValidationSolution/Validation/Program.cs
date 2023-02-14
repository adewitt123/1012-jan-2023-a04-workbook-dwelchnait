// See https://aka.ms/new-console-template for more information
//MenuChoice();
ValidNumber();

void MenuChoice()
{
    string inputValue;
    do
    {
        Console.WriteLine("Sample menu control validation");
        Console.WriteLine("Choice A,B or X to quit");
        Console.Write("enter your menu choice: ");
        inputValue = Console.ReadLine();
        //.ToUpper() changes all characters to upper case
        //.ToLower() changes all caharacters to lower case
        switch (inputValue.ToUpper())
        {
            case "A":
                {
                    Console.WriteLine("You chose option A");
                    break; //prevents your execution proceeding into the next case
                }
            case "B":
                {
                    Console.WriteLine("You chose option B");
                    break;
                }
            case "X":
                {
                    Console.WriteLine("thank you good bye");
                    break;
                }
            default:
                {
                    //if you switch test does NOT match a given case
                    //   the value entered is invalid
                    Console.WriteLine($"Your entry of {inputValue} is invalid. Try Again");
                    break;
                }
        }
    } while (!inputValue.ToUpper().Equals("X"));
}

void ValidNumber()
{
    string inputValue;
    int aNumber = 0;
    Console.WriteLine("this is a generic number validation");
    do
    {
        Console.Write("\n\nEnter a string of either all numbers or an alphanumeric string: ");
        //reading an input value directly into a number
        //  is very dangerous
        //your program could abort
        //if a aphlanumeric string is entered the following will abort
        inputValue = Console.ReadLine();

        //using the .Parse expects ONLY valid data to be in the string
        //it is NOT good code to convert a string to a numeric BEFORE
        //  checking if the string value is REALLY a numeric
        //aNumber = int.Parse(inputValue);

        //To check your string for the correct datatype
        //  BEFORE converting use the .TryParse() method
        //.TryParse takes 2 arguments
        //     the string to be converted
        //     an output variable to hold the actual true conversion
        //.TryParse returns a boolean value (true or False)
        if (int.TryParse(inputValue, out aNumber)) 
        {
            //the conversion was successful
            Console.WriteLine($"Your string is a number: {aNumber}");
           
        }
        else 
        {
            //the conversion was not successful
            Console.WriteLine($"Your string is not a number: {inputValue}");
            aNumber = 1;
        }
    } while (!(aNumber == 0));
}
