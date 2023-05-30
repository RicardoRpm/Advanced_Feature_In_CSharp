// See https://aka.ms/new-console-template for more information

//TODO: sTARTING  in C# 7 . we use _ character to saparete numbers
int d = 123_456;
float f = 1_234.5f;
var x = 0xAB_CD_EF;
var b = 0b1101_1110_1001_0010;

Console.WriteLine($"{d}");
Console.WriteLine($"{f}");
Console.WriteLine($"{b:X}");
Console.WriteLine($"{x:X}");

