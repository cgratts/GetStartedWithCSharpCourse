// Module 3: Perform basic string formatting in C#

// 1. Exercise - Combine strings using character escape sequences
/*
// Format literal strings in C#

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");

// Format output using character escape sequences

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Verbatim string literal

Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
Console.Write(@"c:\invoices");

// Unicode escape characters

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // Kon'nichiwa World

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// Format output using unicode escape characters

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

/*
Generating invoices for customer "Contoso Corp" ...

Invoice: 1021            Complete!
Invoice: 1022            Complete!

Output Directory:
c:\invoices

日本の請求書を生成するには：
    c:\invoices\app.exe -j
*/

// 2. Exercise - Combine strings using string concatenation
/*
// Concatenate multiple variables and literal strings

string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");
*/

// 3. Exercise - Combine strings using string interpolation
/*
// Use string interpolation with multiple variables and literal strings

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

// Combine verbatim literals and string interpolation
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
*/

// 4. Complete the challenge
/*
// Format and display instructions

string projName = "ACME";
string engPath = $@"c:\Exercise\{projName}\data.txt"; 
Console.WriteLine($"View English output:\n\t\t{engPath}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string rusPath = $@"c:\Exercise\{projName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{rusPath}\n");
*/
