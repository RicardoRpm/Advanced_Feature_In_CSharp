
DayTemperature temp1 = new DayTemperature(29.6m, 24.1m);
DayTemperature temp2 = new DayTemperature(30.1m, 22.7m);
DayTemperature temp3 = new DayTemperature(29.6m, 24.1m);

Console.WriteLine($"{temp1}");

Console.WriteLine($"{temp1 == temp2}");
Console.WriteLine($"{temp1 == temp3}");


Console.WriteLine($"Averege: {temp1.Averege}");

public record DayTemperature(decimal high, decimal low)
{
    public decimal Averege
    {
        get => (high + low) / 2;
    }
}
