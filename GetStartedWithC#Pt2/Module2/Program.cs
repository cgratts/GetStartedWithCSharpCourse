// Module 2: Add decicsion logic to your code using 'if', 'else', and 'else if' statements in C#

// 1. Exercise - Create decision logic with if statements

/*
// Generate three random numbers and displays them in output
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Display different messages based on the value of the total variable

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) // Rolled doubles
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
if ((roll1 == roll2) && (roll2 == roll3)) // Rolled triples
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}
if (total >= 15)
{
    Console.WriteLine("You win!");
}
if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
*/

// 2. Exercise - Create nested decision logic with if, else if, and else
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
*/

// 3. Exercise - Complete a challenge activity to apply business rules
/*
Your code should only display one message.

If the user's subscription will expire in 10 days or less, display the message:
Your subscription will expire soon. Renew now!

If the user's subscription will expire in five days or less, display the messages:
Your subscription expires in _ days.
Renew now and save 10%!

If the user's subscription will expire in one day, display the messages:
Your subscription expires within a day!
Renew now and save 20%!

If the user's subscription has expired, display the message:
Your subscription has expired.

If the user's subscription doesn't expire in 10 days or less, display nothing.
*/
/*
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
*/