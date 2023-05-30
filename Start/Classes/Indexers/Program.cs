
StockRecords stock1 = new StockRecords();

Console.WriteLine($"Avarege: {stock1.Average:C}");
Console.WriteLine($"Hight: {stock1.Hight:C}");
Console.WriteLine($"Low: {stock1.Low:C}");

Console.WriteLine($"Days: {stock1.Lenght}");

for (int i = 0; i < stock1.Lenght; i++)
{
    decimal val = stock1[i];
    Console.WriteLine($"Val: {val}");
}

Console.WriteLine("");

Console.WriteLine($"{stock1["mon"]:C}");
Console.WriteLine($"{stock1["tue"]:C}");
Console.WriteLine($"{stock1["wed"]:C}");
Console.WriteLine($"{stock1["thu"]:C}");
Console.WriteLine($"{stock1["fri"]:C}");
