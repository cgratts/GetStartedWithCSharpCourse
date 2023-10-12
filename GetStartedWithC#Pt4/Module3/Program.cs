// Module 3: Perform operations on arrays using helper methods in C#

// 1. Exercise - Discover Sort() and Reverse()

/*
// Create an array of pallets, then sort them

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Reverse the order of the pallets

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

// 2. Exercise - Explore Clear() and Resize()
/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6); // Resize the array to add more elements
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3); // Resize the array to remove elements
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

// 3. Exercise - Discover Split() and Join()
/*
// Use the ToCharArray() to reverse a string

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray); // Reverse, then combine the char array into a new string
// string result = new string(valueArray);
string result = String.Join(",", valueArray); // Combine all of the chars into a new comma-separated-value string using Join()
Console.WriteLine(result);

string[] items = result.Split(','); // Split() the comma-separated-value string into an array of strings
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

// 4. Exercise - Complete a challenge to reverse words in a sentence
/*
Desired Output:
ehT kciuq nworb xof spmuj revo eht yzal god
*/

/*
string pangram = "The quick brown fox jumps over the lazy dog";
string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length]; // Array to store the reversed string copy

for (int i = 0; i < message.Length; i++) // Loop through each element in the message array, reverse it and store this element in newMessage array
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);
*/

// 5. Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
/*
Desired Output:
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
*/

/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items) // Any item string whose length !=4 is an error
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}
*/
