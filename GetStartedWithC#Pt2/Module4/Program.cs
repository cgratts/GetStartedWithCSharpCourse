// Module 4: Create readable code with conventions, whitespace, and comments in C#

// 1. Choose variable names that follow rules and conventions
/*
char userOption;
int gameScore;
float particlesPerMillion;
bool processedCustomer;
*/

// 2. Exercise - Create effective code comments
/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
/*
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
*/

// 3. Exercise - Use whitespace to make your code easier to read
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
*/

// 4. Exercise - Complete a challenge activity to improve code readability 

// Apply style guidelines to improve readability

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */
/*
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray(); // Convert string to char array
Array.Reverse(message); // Reverse array of chars

int letterCount = 0;

foreach (char letter in message) // Count number of o's in char array
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message); // Convert char array to string

Console.WriteLine(newMessage); 
Console.WriteLine($"'o' appears {letterCount} times."); // Display count
*/