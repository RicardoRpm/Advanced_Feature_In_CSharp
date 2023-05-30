// See https://aka.ms/new-console-template for more information

Planet Earth = new Planet("Earth", 6_371, 1, 1_150_980_000);
Planet Venus = new Planet("Venus", 6_052, 0, 1_150_980_000);

//TODO: check
var (name, moons) = Earth;
Console.WriteLine($"{name}, {moons}");

//TODO: check
(name, moons, var radius) = Venus;
Console.WriteLine($"{name}, {moons}, {radius}");
