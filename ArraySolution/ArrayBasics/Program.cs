// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Array World!\n");
int physicalSize = 5;
int logicalsize = 0;
//Declaring an array can be done by specifying the physical size
int[] myPhysicalSizeDeclared = new int[5];

for (int index = 0; index < physicalSize; index++)
{
    Console.WriteLine($"The value at index {index} is {myPhysicalSizeDeclared[index]}");
}

//Declaring an array can be done by specifying a number of values to the stored
//  in the array
//The phyiscal size is the number of values
//datatype of the supplied values MUST match the datatype for the array

//int[] myElementDeclared = new int[] {1, 2, 3, 4, 5 };
int[] myElementDeclared = { 1, 2, 3, 4, 5 }; //common way one see this type of declaration
//int[] myElementDeclared = { "a", "b", "c" }; //this example causes a compile error due to
                                             //different datatypes
for (int index = 0; index < physicalSize; index++)
{
    Console.WriteLine($"The value at index {index} is {myElementDeclared[index]}");
}

//Program loaded of an array

int[] myProgramLoaded = new int[5];
Random random = new Random();
for (int index = 0; index < physicalSize; index++)
{
    myProgramLoaded[index] = random.Next(0,101);
}
for (int index = 0; index < physicalSize; index++)
{
    Console.WriteLine($"The value at index {index} is {myProgramLoaded[index]}");
}

//Multi-dimensional arrays 2-D array
// Declare a two dimensional array
int[,] multiDimensionalArray1 = new int[2, 3];
for (int indexRow = 0; indexRow < 2; indexRow++)
{
    
    for (int indexColumn = 0; indexColumn < 3; indexColumn++)
    {
        Console.Write($"The value at index {indexRow},{indexColumn} is" +
            $" {multiDimensionalArray1[indexRow,indexColumn]}");
    }
    Console.WriteLine("");
}
// Declare and set array element values
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
for (int indexRow = 0; indexRow < 2; indexRow++)
{

    for (int indexColumn = 0; indexColumn < 3; indexColumn++)
    {
        Console.Write($"The value at index {indexRow},{indexColumn} is" +
            $" {multiDimensionalArray2[indexRow, indexColumn]}");
    }
    Console.WriteLine("");
}