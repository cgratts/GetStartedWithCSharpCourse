// Module 1: Call methods from the .NET Class Library using C#

// 1. Exercise - Call the methods of a .NET Class
/*
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
*/

// 2. Exercise - Return values and input parameters of methods
/*
// Overloaded methods

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
*/

// 3. Exercise - Complete a challenge activity to discover and implement a method call
/*
// Implement a method of the Math class that returns the larger of two numbers

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
*/