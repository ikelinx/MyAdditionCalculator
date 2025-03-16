// Two-Number Addition Calculator made by Kyle Ma + ChatGPT 15/03/2025. Revised 1.0.0

// Function to get a valid number from the user
// This function takes a string prompt as input and returns a valid double number entered by the user.
double GetValidNumber(string prompt)
{
    double number;
    while (true) // The while (true) loop in your function creates an infinite loop,
                 // meaning it will keep running forever unless explicitly stopped by a return or break statement.
                 // In this case, it will keep asking for a number until a valid one is entered.
                 // The loop will only exit when a valid number is entered, and the function will return that number.
    {
        Console.WriteLine(prompt);
        string userInput = Console.ReadLine();

        //Check to see if userInput is a number
        if (double.TryParse(userInput.Trim(), out number))
        {
            return number; // ✅ Return valid number
        }
        Console.WriteLine("Invalid input! Please enter a valid number.");
    }
}

// Get the first and second numbers from the user
// The GetValidNumber function is used to get a valid number from the user.
double firstNumber = GetValidNumber("Please enter your first number:");
double secondNumber = GetValidNumber("Please enter your second number:");

// Perform addition
double sum = firstNumber + secondNumber;
sum = Math.Round(sum, 2);

// Display result
Console.WriteLine($"Calculation complete: {firstNumber} + {secondNumber} = {sum}");
Console.WriteLine("Thank you for using the calculator!");
