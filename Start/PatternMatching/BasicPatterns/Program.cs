
/*
string? str = null;

if (str is not null)
{
    Console.WriteLine($"The value of str is '{str}'");
}
else
{
    Console.WriteLine($"str is null");
}
*/

void dashedline(object o)
{
    /*
    int l = 0;
    if (o.GetType() == typeof(int))
    {
        l = (int)o;
    }

    string s = o.ToString();
    if (o.GetType() == typeof(string))
    {
        s = (string)o;
        if (!int.TryParse(s, out l))
        {
            l = 0;
        }
    }

    if (l > 0)
    {
        string str = new string('-', l);
        Console.WriteLine(str);
    }
    */

    if (o is int l || (o is string s && int.TryParse(s, out l)))
    {
        string str = new string('-', l);
        Console.WriteLine(str);
    }
}

//dashedline(25);
//dashedline("50");
//dashedline(20.5);

bool IsTheIdesOfMach(DateTime date)
{
    return (date is { Month: 3, Day: 14 or 15 });
}

Console.WriteLine(IsTheIdesOfMach(new DateTime(DateTime.Today.Year, 1, 13)));
Console.WriteLine(IsTheIdesOfMach(new DateTime(DateTime.Today.Year, 3, 14)));
Console.WriteLine(IsTheIdesOfMach(new DateTime(DateTime.Today.Year, 3, 15)));
Console.WriteLine(IsTheIdesOfMach(new DateTime(DateTime.Today.Year, 3, 16)));


