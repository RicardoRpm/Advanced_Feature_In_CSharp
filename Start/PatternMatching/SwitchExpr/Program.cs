
string ChapeToString(object shape)
{
    switch (shape)
    {
        case Circle:
            return "Circle";
        case Triangle:
            return "Triangle";
        case Rectangle:
            return "Rectangle";
        default:
            return "Unknown";
    }
}

string ChapeToString2(object shape) => shape switch
{
    Circle { Radius: var r } when r > 10 => "Big Circle",
    Circle { Radius: var r } when r <= 10 => "Litle Circle",
    Rectangle { Length: var l, Width: var w } when l == w => "Squere",
    Rectangle => "Rectangle",
    Triangle => "Triangle",
    _ => "Unknnown"
};

Console.WriteLine(ChapeToString2(new Circle { Radius = 10 }));
Console.WriteLine(ChapeToString2(new Rectangle { Length = 10, Width = 10 }));

