// Module 7: Challenge project - Work with variable data in C#

/*
This program manages pets and their information entered by the user.

Within the main menu, the user is given the option to do the following:
1. Print a list of all pet information
2. Add a new animal and its information to the list
3. Fill in any animal ages/physical descriptions that were left blank
4. Fill in any animal nicknames/personality descriptions that were left blank
5. Update an animal's age
6. Update an animal's personality description
7. Print information of all cats who have a specified characteristic
8. Print information of all dogs who have a specified characteristic

When the user is done with the program, they can type Exit to close the console.
*/

// ourAnimals array elements
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// Data entry variables
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// Array used to store runtime data
string[,] ourAnimals = new string[maxPets, 7];

// Populate ourAnimals array with starter data
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "lion";
            suggestedDonation = "";

            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    
    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // If suggestedDonation NOT a number, default to 45.00
    }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// Display menu options and get user input
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
/*
    try
    {
        Console.Clear();
    }
    catch(exception e)
    {
        
    }
*/

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine(" 3. Display all cats with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();

    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // Process selected menu option
    switch (menuSelection)
    {
        case "1":
            // List all current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();

                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }

            Console.WriteLine("\r\nPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Display all dogs with multiple search characteristics
            string dogCharacteristics = "";

            while (dogCharacteristics == "")
            {
                // Have user enter multiple comma separated characteristics to search for
                Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    dogCharacteristics = readResult.ToLower();
                    Console.WriteLine();
                }
            }

            string[] dogSearches = dogCharacteristics.Split(",");
            // Trim leading and trailing spaces from each search term
            for (int i = 0; i < dogSearches.Length; i++)
            {
                dogSearches[i] = dogSearches[i].Trim();
            }

            Array.Sort(dogSearches);
            // Update to "rotating" search animation with countdown
            string[] searchingIcons = {" |", " /", "--", " \\", " *"};

            bool matchesAnyDog = false;
            string dogDescription = "";

            // Search array for matching animals
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    // Search combined descriptions and print results
                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                    bool matchesCurrentDog = false;

                    foreach (string term in dogSearches)
                    {
                        // Only search if there is a term to search for
                        if (term != null && term.Trim() != "")
                        {
                            for (int j = 2; j > -1 ; j--)
                            {
                                // Update "searching" message to show countdown
                                foreach (string icon in searchingIcons)
                                {
                                    Console.Write($"\rsearching our dog {ourAnimals[i, 3].Substring(10)} for {term.Trim()} {icon} {j.ToString()}");
                                    Thread.Sleep(100);
                                }
                                
                                Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                            }

                            // Iterate entered characteristic terms and search description for each term
                            if (dogDescription.Contains(" " + term.Trim() + " "))
                            {
                                // Update message to reflect current search term match 
                                Console.WriteLine($"\rOur dog {ourAnimals[i, 3].Substring(10)} matches your search for {term.Trim()}");

                                matchesCurrentDog = true;
                                matchesAnyDog = true;
                            }
                        }
                    }
                    
                    // If the current dog is a match, display the dog's info
                    if (matchesCurrentDog)
                    {
                        Console.WriteLine($"\n\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
                    }
                }
            }

            if (!matchesAnyDog)
            {
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
            }

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "3":
            // Display all cats with one or more search characteristics
            string catCharacteristics = "";

            while (catCharacteristics == "")
            {
                // Have user enter multiple comma separated characteristics to search for
                Console.WriteLine($"\nEnter one or more cat characteristic(s) to search for separated by commas");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    catCharacteristics = readResult.ToLower();
                    Console.WriteLine();
                }
            }

            string[] catSearches = catCharacteristics.Split(",");
            // Trim leading and trailing spaces from each search term
            for (int i = 0; i < catSearches.Length; i++)
            {
                catSearches[i] = catSearches[i].Trim();
            }

            Array.Sort(catSearches);
            // Update to "rotating" search animation with countdown
            string[] searchingIcons1 = {" |", " /", "--", " \\", " *"};

            bool matchesAnyCat = false;
            string catDescription = "";

            // Search array for matching animals
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("cat"))
                {
                    // Search combined descriptions and print results
                    catDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                    bool matchesCurrentCat = false;

                    foreach (string term in catSearches)
                    {
                        // Only search if there is a term to search for
                        if (term != null && term.Trim() != "")
                        {
                            for (int j = 2; j > -1 ; j--)
                            {
                                // Update "searching" message to show countdown
                                foreach (string icon in searchingIcons1)
                                {
                                    Console.Write($"\rsearching our cat{ourAnimals[i, 3].Substring(9)} for {term.Trim()} {icon} {j.ToString()}");
                                    Thread.Sleep(100);
                                }
                                
                                Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                            }

                            // Iterate entered characteristic terms and search description for each term
                            if (catDescription.Contains(" " + term.Trim()))
                            {
                                // Update message to reflect current search term match 
                                Console.WriteLine($"\rOur cat{ourAnimals[i, 3].Substring(9)} matches your search for {term.Trim()}");

                                matchesCurrentCat = true;
                                matchesAnyCat = true;
                            }
                        }
                    }
                    // If the current cat is a match, display the cat's info
                    if (matchesCurrentCat)
                    {
                        Console.WriteLine($"\n\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{catDescription}\n");
                    }
                }
                // If there are no matches in the entire list
                if(!matchesAnyCat && i == maxPets - 1)
                {
                    Console.WriteLine($"None of our cats match your search for {readResult}");
                }
            }

            Console.WriteLine("\nPress the Enter key to continue.");
            readResult = Console.ReadLine();

            break;

        default:
            break;
    }
} 
while (menuSelection != "exit");
