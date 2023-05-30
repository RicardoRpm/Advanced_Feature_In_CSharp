// See https://aka.ms/new-console-template for more information

string[] words = new string[] {
    "Ricaro", "azul", "vermelho", "branco", "verde", "rosa", "preto", "branco"
};

//Console.WriteLine(words[1]);

Console.WriteLine(" ::::::::::::::::: APPLING ADVANCED CONCEPTS :::::::::::::::::");
//Console.WriteLine(words[^2]);
// TODO: The Range operator (..) defines range
string[] wordRange; //= //words[2..5];
//Console.WriteLine($"{String.Join(",", wordRange)}");
//wordRange = words[..];
//Console.WriteLine($"{String.Join(",", wordRange)}");
//wordRange = words[2..];
//Console.WriteLine($"{String.Join(",", wordRange)}");
//wordRange = words[..5];
//Console.WriteLine($"{String.Join(",", wordRange)}");

// TODO: Indexes and Range Can be variables too
Index idx = ^4;
Console.WriteLine(words[idx]);

Range rng = 2..6;
wordRange = words[rng];
Console.WriteLine($"{String.Join(",", wordRange)}");