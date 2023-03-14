// See https://aka.ms/new-console-template for more information


using System.IO;

Console.WriteLine("File IO using Streaming Technique\n\n");

//WriteFile();
//ReadFile();

string filePath = @"../../../SampleFile.txt";
//string filePath = @"../../SampleFile.txt";
//string filePath = @"../../../Emptyfile.txt";
//string filePath = @"../../../NonExistingFile.txt";
StreamReader streamReader = null;

//empty the path name to generate an error
//filePath = null;
//setup the stream for the Reader
streamReader = new StreamReader(filePath);
try
{
    ReadFileThrowException(streamReader);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    //ex is the error
    //ex contains many properties
    //Message property contains your error message
    //to access the error message you will use the object operator . (dot)
    //  syntax   objecctinstancename.propertyname
    //                    ex        .   Message
    Console.WriteLine(ex.Message);
}
finally

{
    if (streamReader != null)
    {
        streamReader.Close();
    }
}
void WriteFile()
{
    //in this method we will write a series of lines
    //  to a text file using the StreamWriter.
    //to write to a file, you will need to known the 
    //  name of the file 
    //there are two ways to reference your file
    // a) absolute path name
    // b) a relative path name
    //
    //Absolute path name includes the drive and all folders down to the filename
    //  this requires that the path exists on the machine that the program
    //      is executing on
    //
    //Relative path name is a location that is reached from the location of the
    //  programs .exe file
    //  this relative name is done in the same fashion as relative addresing is
    //      accomplished in web site using ./---/----/filename to go lower
    //      in the file structure and ../../filename to go higher in the file
    //      structure
    string filePath = @"../../../SampleFile.txt";
    string inputValue;
    bool appendFlag = false;
    //StreamWriter allows your program to
    //  a) overwrite the contents of a file (default) (false)
    //  b) append to the contents of a file           (true)
    Console.Write("Append to the file? (Y/N) ");
    inputValue = Console.ReadLine();
    if (inputValue.ToUpper().Equals("Y"))
    {
        appendFlag = true;
    }
    //There are several forms of creating your StreamWriter
    //The StreamWriter can
    //a) create a file if it does not exist and write to the file
    //b) file exists and boolean flag is false: overwrites
    //c) file exists and boolean flag is true: appends
    StreamWriter streamWriter = new StreamWriter(filePath,appendFlag);

    //create a string to represent the content to be placed in the file
    string dummyFileContent = "Create a very long string to split up " +
        "and use each word as a line in the output file";
    //split the string into a series of strings each contains one of the
    //  words from the original string
    //to do this, use the string method .Split(character delimiter)
    //the output of this method is an array of strings
    //a delimiter is a single character used to indicate the separation of
    //  items
    //in this example, the delimiter is a space character (space between words)
    string[] wordRows = dummyFileContent.Split(' ');
    //.Length of an array returns the number of items in the array
    Console.WriteLine($"File should have {wordRows.Length} lines");

    //write the words as individual rows to the file
    //foreach is a pre-test loop that sequentially traverse a collection (array)
    //  start to end, moving automatically between items, automatically checking
    //  for the start and end of the collection (array)
    //this is an EXCELLENT loop structure if you have a collection of UNKNOWN length
    //syntax  foreach(datatype placeholdername in collectionname){.....}
    //the datatype may be  either a)actual datatype or b) the keyword var
    foreach(string itemplaceholder in wordRows)
    {
        //the statement to write to the file is streamwritervariable.WriteLine(string)
        streamWriter.WriteLine(itemplaceholder);
    }
    //you must remember to close the stream after you finish writing everything
    //  to the file
    streamWriter.Close();
    Console.WriteLine($"File should have been created. Check the file" +
        $" located at {Path.GetFullPath(filePath)}");
}

void ReadFile()
{
    string filePath = @"../../../SampleFile.txt";
    //string filePath = @"../../SampleFile.txt";
    //string filePath = @"../../../Emptyfile.txt";
    //string filePath = @"../../../NonExistingFile.txt";
    StreamReader streamReader = null;
    try
    {
        //empty the path name to generate an error
        //filePath = null;
        //setup the stream for the Reader
        streamReader = new StreamReader(filePath);
        Console.WriteLine($"\nReading from the file {filePath}");
        //used to hold the incoming line from the file
        string readLine;
        int countReadLines = 0;

        int badnumericConversion = 0;
       


        //start reading the lines
        readLine = streamReader.ReadLine(); //read a line from the file
                                            //proccess the lines read from the file
                                            //if the readLine is null then no line was return on the
                                            //  execution of .ReadLine()
                                            //the value of your string will be null
                                            //you can use this fact to determine the end of the file
        while (readLine != null)
        {
            //you have a line from the file to process
            countReadLines++;
            Console.WriteLine($"Line {countReadLines} is {readLine}");

            //this error is a typical convert string to a numeric WITHOUT
            //   first doing a .TryParse()
            badnumericConversion = int.Parse(readLine);
           
            //get the next line from the file IF it exists
            //if you have reached the end of the file
            //  your readLine will be null
            readLine = streamReader.ReadLine();
        }
        Console.WriteLine($"\nFile has been read. It contained {countReadLines} lines");
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        //ex is the error
        //ex contains many properties
        //Message property contains your error message
        //to access the error message you will use the object operator . (dot)
        //  syntax   objecctinstancename.propertyname
        //                    ex        .   Message
        Console.WriteLine(ex.Message);
    }
    finally
    
    {
        if (streamReader != null)
        {
            streamReader.Close();
        }
    }


}

void ReadFileThrowException(StreamReader streamReader)
{
    
        Console.WriteLine($"\nReading from the file {filePath}");
        //used to hold the incoming line from the file
        string readLine;
        int countReadLines = 0;

        int badnumericConversion = 0;



        //start reading the lines
        readLine = streamReader.ReadLine(); //read a line from the file
                                            //proccess the lines read from the file
                                            //if the readLine is null then no line was return on the
                                            //  execution of .ReadLine()
                                            //the value of your string will be null
                                            //you can use this fact to determine the end of the file
        while (readLine != null)
        {
            //you have a line from the file to process
            countReadLines++;
            Console.WriteLine($"Line {countReadLines} is {readLine}");

            //this error is a typical convert string to a numeric WITHOUT
            //   first doing a .TryParse()
            badnumericConversion = int.Parse(readLine);

            //get the next line from the file IF it exists
            //if you have reached the end of the file
            //  your readLine will be null
            readLine = streamReader.ReadLine();
        }
        Console.WriteLine($"\nFile has been read. It contained {countReadLines} lines");
    
    


}