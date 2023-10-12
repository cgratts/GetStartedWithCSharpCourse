// Module 3: Implement exception handling in C# console applications

// 1. Examine exceptions and the exception handling process
/*
// Exception handling keywords, code blocks, and patterns

try
{   
   // try code block - code that may generate an exception
}
catch
{   
   // catch code block - code to handle an exception
}
finally
{   
   // finally code block - code to clean up resources
}
*/

/*
// Exception handling process

try
{
    // Step 1: code execution begins
    try
    {
        // Step 2: an exception occurs here
    }
    finally
    {
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
    }

}
catch // Step 3: the system finds a catch clause that can handle the exception
{   
   // Step 5: the system transfers control to the first line of the catch code block
}
*/

// 2. Examine code samples for compiler-generated exceptions
/*
// ArrayTypeMismatchException

string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;

Object obj = (Object)13;
objs[2] = obj; // ArrayTypeMismatchException occurs
*/

/*
// DivideByZeroException

int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2); // DivideByZeroException occurs
*/

/*
// FormatException

int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs
*/

/*
// IndexOutOfRangeException

int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs
*/

/*
// InvalidCastException

object obj = "This is a string";
int num = (int)obj;
*/

/*
// NullReferenceException

int[] values = null;
for (int i = 0; i <= 9; i++)
    values[i] = i * 2;

string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());    
*/

/*
// OverflowException

decimal x = 400;
byte i;

i = (byte)x; // OverflowException occurs
Console.WriteLine(i);  
*/

// 3. Exercise - Implement try-catch exception handling
/*
// Implement a simple try-catch

double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;

try
{
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
catch
{
    Console.WriteLine("An exception has been caught");
}
*/

/*
// Catch exceptions thrown in called methods

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
*/

// 4. Exercise - Complete a challenge activity for try-catch
/*
// Try-Catch challenge

// Update the Process1 method to catch the exception that's thrown in the WriteMessage method.
// The Process1 method should print the following message to console when the exception is caught:
// Exception caught in Process1
// Don't change any code outside the Process1 method.
// When you run your updated application, it should generate the following output:
// ∞
// Exception caught in Process1
// Exit program
// For the purposes of this challenge, you can ignore the output messages created by the debugger. For example, you
// can ignore the following messages:
// Exception thrown: 'System.DivideByZeroException' in Exceptions101.dll
// The program '[436] Exceptions101.dll' has exited with code 0 (0x0).

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch
    {
        Console.WriteLine("Exception caught in Process1");
    }

}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
*/

// 5. Exercise - Exercise - Catch specific exception types
/*
// Access the properties of an exception object

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1() // Catch a specific exception type
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
    //  In a checked context, the conversion succeeds if the source value is within the range of the destination
    // type. Otherwise, an OverflowException is thrown.
    checked
    {
        smallNumber = (byte)number1;
    }
}
*/

/*
// Catch separate exception types in a code block

// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
*/

// 6. Exercise - Complete a challenge activity to catch specific exceptions
/*
// Catch specific exceptions challenge
// Each error message should display to the console when the specific exception type occurs.

checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}

try
{
    string? str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");
*/