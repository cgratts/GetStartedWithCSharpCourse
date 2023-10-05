// Module 5: Add looping logic to your code using the do-while and while statements in C#

// 1. Exercise - Create do and while iteration loops
/*
// do-while statement that breaks when a certain random number is generated

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue; // Step directly to the Boolean expression

    Console.WriteLine(current);
} while (current != 7);
*/

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

// 2. Exercise - Complete a challenge activity using do and while iteration statements
/*
Game Rules
-----------
Rule 1: You must use either the do-while statement or the while statement as an outer game loop.
Rule 2: The hero and the monster will start with 10 health points.
Rule 3: All attacks will be a value between 1 and 10.
Rule 4: The hero will attack first.
Rule 5: Print the amount of health the monster lost and their remaining health.
Rule 6: If the monster's health is greater than 0, it can attack the hero.
Rule 7: Print the amount of health the hero lost and their remaining health.
Rule 8: Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Rule 9: Print the winner.

Output
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
*/

/*
int heroHP = 10; 
int monsterHP = 10;
Random roll = new Random();   

do{
    int dmgTaken = roll.Next(1, 11);
    monsterHP -= dmgTaken;
    Console.WriteLine($"Monster took {dmgTaken} damage! Remaining HP: {monsterHP}");

    if(monsterHP <=0) continue;

    dmgTaken = roll.Next(1, 11);
    heroHP -= dmgTaken;
    Console.WriteLine($"Hero took {dmgTaken} damage! Remaining HP: {heroHP}");

} while (heroHP > 0 && monsterHP > 0);

Console.WriteLine(monsterHP > heroHP ? "Monster wins...Game Over" : "Hero wins... You Won!");
*/

// 3. Exercise - Complete a challenge activity to differentiate between do and while iteration statements
// Manage user input 
/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);


// Capture user input in a string variable named readResult using TryParse

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
*/

// 4. Code project 1 - write code that validates integer input
/*
Your solution must include either a do-while or while iteration.
Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.


Output:
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
*/

/*
string? input;
string entry = "";
int num = 0;
bool validNum = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do{    
    input = Console.ReadLine();

    if(input != null){
        entry = input;
    }
    
    validNum = int.TryParse(entry, out num);

    if(validNum){
        if(num <= 5 || num >= 10 ){
            validNum = false;
            Console.WriteLine($"You entered {input}. Please enter a number between 5 and 10.");
        }
    }
    else{
        Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
    }
} while(!validNum);

Console.WriteLine($"Your input value ({num}) has been accepted.");

input = Console.ReadLine();
*/

// 5. Code project 2 - write code that validates string input
/*
Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and training space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

/*
string? input;
string role = "";
bool validInput = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    input = Console.ReadLine();
    if (input != null) 
    {
        role = input.Trim();
    }

    if (role.ToLower() == "administrator" || role.ToLower() == "manager" || role.ToLower() == "user") 
    {
        validInput = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{role}\" is not valid. ");
    }

} while (validInput == false);

Console.WriteLine($"Your input value ({role}) has been accepted.");
input = Console.ReadLine();
*/

// 6. Code project 3 - write code that processes the contents of a string array
/*
Your solution must use the following string array to represent the input to your coding logic:

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.
Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.
In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.
Your solution must include an inner do-while or while loop that can be used to process the myString variable.
In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
In the inner loop, your solution must not display the period character.
In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
*/

/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int numStrings = myStrings.Length;

string myString = "";
int periodIndex = 0;

for (int i = 0; i < numStrings; i++)
{
    myString = myStrings[i];
    periodIndex = myString.IndexOf(".");

    string mySentence;

    // Display sentences within string one at a time
    while (periodIndex != -1)
    {

        // First sentence = string value to the left of period index
        mySentence = myString.Remove(periodIndex);

        // Remainder of myString = string value to the right of period index
        myString = myString.Substring(periodIndex + 1);

        // Remove leading white-space 
        myString = myString.TrimStart();

        // Update location of the comma and increment the counter
        periodIndex = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}*/