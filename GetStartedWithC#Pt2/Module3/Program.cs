// Module 3: Store and iterate through sequences of data using Arrays and the foreach statement in C#

// 1. Exercise - Get started with array basics
/*
string[] fraudulentOrderIDs = { "A123", "B456", "C789" }; // Initialize and assign values to elements of an array

Console.WriteLine($"First: {fraudulentOrderIDs[0]}"); // Retrieve values from elements of an array
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000"; // Reassign the value of an array

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process."); // Use the Length property of an array
*/

// 2. Exercise - Implement the foreach statement
/*
int[] inventory = { 200, 450, 700, 175, 250 }; // Create and initialize an array of int
int sum = 0;
int bin = 0;

foreach (int items in inventory) // Add a foreach statement to iterate through the array
{
    sum += items; // Sum the value of each element in the array
    bin++; // Hold the current bin number and display the running total
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");
*/

// 3. Exercise - Complete a challenge activity for nested iteration and selection statements
/*
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs) // Iterate through array and output order IDs that begin with the letter B
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
*/