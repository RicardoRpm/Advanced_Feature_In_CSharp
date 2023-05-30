
public class Planet
{
    public string Name { get; set; }
    public int Radius { get; set; }
    public int MoonCount { get; set; }
    public int DistanceFromSunKm { get; set; }

    public Planet(string name, int radius, int moonCount, int distanceFromSunKm)
    {
        Name = name;
        Radius = radius;
        MoonCount = moonCount;
        DistanceFromSunKm = distanceFromSunKm;
    }

    public void Deconstruct(out string name, out int moons)
    {
        name = Name;
        moons = MoonCount;
    }

    public void Deconstruct(out string name, out int moons, out int radius)
    {
        name = Name;
        moons = MoonCount;
        radius = Radius;
    }
}
