// See https://aka.ms/new-console-template for more information
Console.WriteLine("Collect and Average numbers!");

int logicalSize = 0;
int physicalSize = 25;
int[] myArray = new int[physicalSize];
string inputvalue;
int inputNumber = 0;
do
{
    Console.Write("Enter a number or 0 to quit");
    inputvalue = Console.ReadLine();
    inputNumber = int.Parse(inputvalue);
    if (inputNumber > 0)
    {
        //logicalSize plays the part of the index for the array
        //keeps a count of how many elements are actually in the array
        myArray[logicalSize] = inputNumber;
        logicalSize++;
    }
}while (inputNumber != 0 && logicalSize < physicalSize);//not ONLY the stop value BUT
                                                        //ALSO the array size test

//Calculate average
double sum = 0.0;
Console.Write("The average of the following numbers ");
for (int i = 0; i < logicalSize; i++)
{
    sum += myArray[i];
    Console.Write($"{myArray[i]} ");
}

Console.Write($" is {sum / logicalSize}");
