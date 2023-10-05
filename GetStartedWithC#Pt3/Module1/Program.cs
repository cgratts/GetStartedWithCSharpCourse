// Module 1: Evaluate Boolean expressions to make decisions in C#

// 1. Exercise - Evaluate an expression
/*
// Use the equality operator 

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
*/

/*
// Improve the check for string equality using the string's built-in helper methods

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/

/*
// Use the inequality operator

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
*/

/*
// Use the Comparison operators

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
*/

/*
// Use a method that returns a Boolean

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
*/

/*
// Use the Logical Negation operator

Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
*/

// 2. Exercise - Implement the conditional operator
/*
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}"); // Use the conditional operator inline
*/

// 3. Exercise - Complete a challenge activity using conditional operators
/*
// Display the result of a coin flip

Random coin = new Random();
int flip = coin.Next(0,2);
Console.WriteLine((flip == 0) ? "Heads" : "Tails");
*/

// 4. Exercise - Complete a challenge activity using Boolean expressions
/*
If the user is an Admin with a level greater than 55, output the message:
Welcome, Super Admin user.

If the user is an Admin with a level less than or equal to 55, output the message:
Welcome, Admin user.

If the user is a Manager with a level 20 or greater, output the message:
Contact an Admin for access.

If the user is a Manager with a level less than 20, output the message:
You do not have sufficient privileges.

If the user is not an Admin or a Manager, output the message:
You do not have sufficient privileges.
*/

/*
string permission = "Admin|Manager";
int level = 55;

if(permission.Contains("Admin")){
    if(level > 55){
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level <= 55){
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if(permission.Contains("Manager")){
    if(level >= 20){
        Console.WriteLine("Contact an admin for access.");
    }
    else if(level < 20){
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else{
    Console.WriteLine("You do not have sufficient privileges.");
}
*/