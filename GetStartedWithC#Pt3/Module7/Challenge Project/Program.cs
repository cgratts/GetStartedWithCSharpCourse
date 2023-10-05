// Module 7: Challenge project - Develop branching and looping structures in C#

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

using System;
using System.IO;

// ourAnimals array elements 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// Data entry variables
int maxPets = 8;
string? readResult;
string menuSelection = "";
int petCount = 0;
string anotherPet = "y";
bool validEntry = false;
int petAge = 0;

// Array to store data during runtime
string[,] ourAnimals = new string[maxPets, 6];

// Populate ourAnimals array with starter data
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";

            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// Display menu options and get user input
do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
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
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Add new animal to ourAnimals array
            /* Array elements
            1. Animal species (cat or dog) - Required
            2. ID # - Created during runtime
            3. Pet age - Optional at initial entry
            4. Pet nickname - Optional
            5. Description of pet's phyiscal appearance - Optional
            6. Description of pet's personality - Optional
            */
            anotherPet = "y";
            petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                // Get animal species
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // Create and assign ID number 
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // Get pet's age
                do
                {
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }                        
                    }
                } while (validEntry == false);

                // Get description of pet's phyiscal appearance
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (validEntry == false);

                // Get description of pet's personality
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (validEntry == false);

                // Get pet's nickname
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (validEntry == false);

                // Store processed information in ourAnimals array
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // Increment number of pets
                petCount = petCount + 1;

                // Check pet limit
                if (petCount < maxPets)
                {   
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            // Pet limit reached
            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Complete the animal age and physical description entries 
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalAge = readResult;
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                    } while (validEntry == false);
                    ourAnimals[i, 2] = "Age: " + animalAge.ToString();
                }

                if (ourAnimals[i, 4] == "Physical description: " && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalPhysicalDescription = readResult.ToLower();
                            if (animalPhysicalDescription == "")
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }

                        }
                    } while (validEntry == false);

                    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                }
            }

            Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "4":
            // Complete the animal nickname and personality entries 
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalNickname = readResult;
                            if (animalNickname == "")
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }

                        }

                    } while (validEntry == false);

                    ourAnimals[i, 3] = "Nickname: " + animalNickname;
                }

                if (ourAnimals[i, 5] == "Personality: " && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalPersonalityDescription = readResult.ToLower();
                            if (animalPersonalityDescription == "")
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);

                    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                } 
            }

            Console.WriteLine("\n\rAge and physical description fields are complete for all of our friends. \n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "5":
            // Edit an animal’s age
            do
            {
                Console.WriteLine("Enter the nickname of the pet whose age you would like to change");
                readResult = Console.ReadLine();
                
                if (readResult != null)
                {
                    string nameEntered = "Nickname: " + readResult;

                    // Iterate through list of pets to try and find a matching name
                    for (int i = 0; i < maxPets; i++)
                    {   
                        if(nameEntered.ToLower() == (ourAnimals[i,3]).ToLower())
                        {
                            Console.WriteLine($"Enter the updated age of {ourAnimals[i,3].Substring(10)}");
                            readResult = Console.ReadLine();

                            do 
                            {   
                                if (readResult != null)
                                {
                                    animalAge = readResult;
                                    if (animalAge != "?")
                                    {
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    }
                                    if(validEntry) // If user entry is a valid number
                                    {

                                        ourAnimals[i,2] = "Age: " + animalAge; // Set new animal age
                                        
                                        Console.WriteLine("Age updated");
                                        Console.WriteLine("Press the Enter key to continue.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid new age");
                                        readResult = Console.ReadLine();
                                    }                        
                                }
                            } while (validEntry == false);
                            break;
                        }
                        else
                        {
                            if(i == maxPets - 1) // If no match was found in the entire list
                            {
                                Console.WriteLine($"An animal with the name {readResult} is not currently registered.");
                            }
                        }
                    }
                }                       
            } while (validEntry == false);

            readResult = Console.ReadLine();
            break;

        case "6":
            // Edit an animal’s personality description
            do
            {
                Console.WriteLine("Enter the nickname of the pet whose personality description you would like to change");
                readResult = Console.ReadLine();
                
                if (readResult != null)
                {
                    string nameEntered = "Nickname: " + readResult;

                    // Iterate through list of pets to try and find a matching name
                    for (int i = 0; i < maxPets; i++)
                    {   
                        if(readResult != null && nameEntered.ToLower() == (ourAnimals[i,3]).ToLower())
                        {
                            Console.WriteLine($"Enter the updated personality description (likes or dislikes, tricks, energy level) of {ourAnimals[i,3].Substring(10)}");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalPersonalityDescription = readResult.ToLower();
                                if (animalPersonalityDescription == "")
                                {
                                    validEntry = false;
                                }
                                else
                                {
                                    validEntry = true;
                                    ourAnimals[i,5] = "Personality: " + animalPersonalityDescription; // Set new animal personality description

                                    Console.WriteLine("Personality description updated");
                                }
                            }
                            break;
                        }
                        else
                        {
                            if(i == maxPets - 1) // If no match was found in the entire list
                            {
                                Console.WriteLine($"An animal with the name {readResult} is not currently registered.");
                            }
                        }
                    }
                }                       
            } while (validEntry == false);
            
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        case "7":
            // Display all cats with a specified characteristic
            Console.WriteLine("Enter a physical characteristic of a cat you would like to search for");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                for (int i = 0; i < maxPets; i++)
                {
                    if(ourAnimals[i,1] == "Species: cat" && ourAnimals[i,4].Contains(readResult)) // If Physical description contains user entry
                    {
                        Console.WriteLine();

                        for (int j = 0; j < 6; j++)
                        {
                            Console.WriteLine(ourAnimals[i, j].ToString());
                        }
                    }
                    else
                    {
                        if(i == maxPets - 1) // If no match was found in the entire list
                        {
                            Console.WriteLine("No cats match the entered physical characteristic");
                        }
                    }
                }
            }

            Console.WriteLine("\nPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // Display all dogs with a specified characteristic
            Console.WriteLine("Enter a physical characteristic of a dog you would like to search for");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                for (int i = 0; i < maxPets; i++)
                {
                    if(ourAnimals[i,1] == "Species: dog" && ourAnimals[i,4].Contains(readResult)) // If Physical description contains user entry
                    {
                        Console.WriteLine();

                        for (int j = 0; j < 6; j++)
                        {
                            Console.WriteLine(ourAnimals[i, j].ToString());
                        }
                    }
                    else
                    {
                        if(i == maxPets - 1) // If no match was found in the entire list
                        {
                            Console.WriteLine("No dogs match the entered physical characteristic");
                        }
                    }
                }
            }
            Console.WriteLine("\nPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
