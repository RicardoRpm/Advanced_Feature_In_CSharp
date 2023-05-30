
string GetQuarterFromDate(DateTime date) => date.Month switch
{
    >= 1 and <= 3 => "Q1",
    >= 4 and <= 6 => "Q2",
    >= 6 and <= 9 => "Q3",
    >= 10 and <= 12 => "Q4",
    _ => throw new ArgumentOutOfRangeException(nameof(date), $"Unexpected month given: {date}"),
};

void FirstSecondHalf(object dt)
{
    if (dt is DateTime { Month: > 6 })
    {
        Console.WriteLine("Date is in second half");
    }
    else if (dt is DateTime { Month: <= 6 })
    {
        Console.WriteLine("Date is in first half");
    }
}
FirstSecondHalf(new DateTime(2022, 2, 14));
//Console.WriteLine(GetQuarterFromDate(new DateTime(2022, 2, 14)));
