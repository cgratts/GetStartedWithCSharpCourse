// Module 4: Perform basic operations on numbers in C#

// 1. Exercise - Perform addition with implicit data conversion
/*
// Mix data types to force implicit type conversions

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
*/

// 2. Exercise: Perform math operations
/*
// Perform basic math operations

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second; // Division using literal decimal data
Console.WriteLine(quotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}"); // Determine the remainder after integer division
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value1 = 3 + 4 * 5; // Order of operations
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);
*/

// 3. Exercise: Increment and decrement values
/*
// Increment and decrement

int value = 1;

value++;
value--;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));
*/

// 4. Complete the challenge to convert Fahrenheit to Celsius
/*

int fahrenheit = 94;
decimal celsius = (decimal)(fahrenheit - 32m) * (decimal)(5m/9m);

Console.WriteLine($"The temperature is {celsius} Celsius.");
*/