// See https://aka.ms/new-console-template for more information

/*
void OldSchoolLogString(string? theString)
{
    if (theString == null)
    {
        Console.WriteLine("No string given");
    }
    else
    {
        Console.WriteLine(theString);
    }
}
*/

//OldSchoolLogString("Test String");
//OldSchoolLogString(null);

/*
void LogString(string? theString)
{
    Console.WriteLine(theString ?? "No string given");
}
*/

//LogString("Test String 1");
//LogString(null);

/*
void ThrowableLogString(string? theString)
{
    Console.WriteLine(theString ?? throw new ArgumentNullException("theString", "No string given"));
}
*/

//ThrowableLogString("Test String 1");
//ThrowableLogString(null);


string str = "null String ";
str ??= "Default value";
Console.WriteLine(str);
