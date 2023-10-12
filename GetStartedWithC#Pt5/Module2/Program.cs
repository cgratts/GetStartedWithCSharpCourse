// Module 2: Create C# methods with parameters

// 1. Exercise - Use parameters in methods
/*
// Create a method with parameters

int[] schedule = {800, 1200, 1600, 2000};

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {   
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    } 
    else 
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++) 
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
*/

// 2. Exercise - Understand method scope
/*
// Test variable scope

string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students); // Method parameter 'student' takes precedence over the global 'student' array
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}
*/

/*
// Both methods can reference the same value of pi without needing to define it

double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}
*/

// 3. Exercise - Use value and reference type parameters
/*
// Parameters passed by value 

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c) 
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

// Output
// inside Multiply method: 3 x 4 = 12
// global statement: 3 x 4 = 0
*/

/*
// Parameters passed by reference

int[] array = {1, 2, 3, 4, 5};

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array) 
{
    foreach (int a in array) 
    {
        Console.Write($"{a} ");
    }
}

void Clear(int[] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = 0;
    }
}

// Output
// 1 2 3 4 5
// 0 0 0 0 0
*/

// Test with strings
/*
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy) 
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}

// Output
// Start: Healthy
// Middle: Unhealthy
// End: Unhealthy
*/

// 4. Exercise - Methods with optional parameters
/*
// Create an RSVP application

string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false); // Use named arguments (these specifically can be used out of order)
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name)) {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

// Output
// Sorry, Tony is not on the guest list
//
// Total RSVPs:
// Name: Rebecca,  Party Size: 1,  Allergies: none
// Name: Nadia,    Party Size: 2,  Allergies: Nuts
// Name: Linh,     Party Size: 2,  Allergies: none
// Name: Noor,     Party Size: 4,  Allergies: none
// Name: Jonte,    Party Size: 2,  Allergies: Stone fruit
*/

// 5. Exercise - Complete the challenge to display email addresses

// Desired Output
// robavin@contoso.com
// sibright@contoso.com
// kisinclair@contoso.com
// aakamath@contoso.com
// sadelucchi@contoso.com
// siali@contoso.com
// iashton@hayworth.com
// codysart@hayworth.com
// shlawrence@hayworth.com
// davaldes@hayworth.com

/*
// Code challenge: Add a method to display email addresses

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayEmail(first: corporate[i,0], last: corporate[i,1]); // Display internal email addresses
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain); // Display external email addresses
}

void DisplayEmail(string first, string last, string domain = "contoso.com") 
{
	string email = first.Substring(0, 2) + last;
	email = email.ToLower();
	Console.WriteLine($"{email}@{domain}");
}
*/