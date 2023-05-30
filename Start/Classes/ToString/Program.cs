
float x = 42.0f;
string str = x.ToString();
//Console.WriteLine($"{str}");

Person per = new Person()
{
    FirstName = "Ricardo ",
    LastName = "Miguel",
    Age = 24
};

Console.WriteLine($"{per}");

public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }

    public override string ToString() => $"[Person] FirstName:{FirstName}, LastName: {LastName}, Age: {Age}";
}
