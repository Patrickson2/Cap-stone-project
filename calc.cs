using System;

namespace SimpleCalculator
{
    /// <summary>
    /// A simple console calculator that performs basic arithmetic operations
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// Main entry point of the calculator application
        /// </summary>
        static void Main()
        {
            // Display welcome banner
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║   Welcome to Simple Calculator     ║");
            Console.WriteLine("╚════════════════════════════════════╝\n");

            // Main application loop - continues until user chooses to exit
            while (true)
            {
                try
                {
                    // Display operation menu to user
                    Console.WriteLine("Select an operation:");
                    Console.WriteLine("1. Addition (+)");
                    Console.WriteLine("2. Subtraction (-)");
                    Console.WriteLine("3. Multiplication (*)");
                    Console.WriteLine("4. Division (/)");
                    Console.WriteLine("5. Modulus (%)");
                    Console.WriteLine("6. Power (^)");
                    Console.Write("\nEnter your choice (1-6): ");

                    // Parse user's operation choice
                    int choice = Convert.ToInt32(Console.ReadLine());
                    
                    // Validate that choice is within acceptable range
                    if (choice < 1 || choice > 6)
                    {
                        Console.WriteLine("\n Invalid choice. Please select a valid operation (1-6).\n");
                        continue;
                    }

                    // Get operands from user
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    // Initialize result variable
                    double result = 0;
                    
                    // Execute the selected operation
                    switch (choice)
                    {
                        case 1: // Addition
                            result = num1 + num2;
                            Console.WriteLine($"\n✓ Result: {num1} + {num2} = {result}\n");
                            break;
                        case 2: // Subtraction
                            result = num1 - num2;
                            Console.WriteLine($"\n✓ Result: {num1} - {num2} = {result}\n");
                            break;
                        case 3: // Multiplication
                            result = num1 * num2;
                            Console.WriteLine($"\n✓ Result: {num1} * {num2} = {result}\n");
                            break;
                        case 4: // Division
                            // Prevent division by zero error
                            if (num2 == 0)
                            {
                                Console.WriteLine("\n Error: Division by zero is not allowed.\n");
                                continue;
                            }
                            result = num1 / num2;
                            Console.WriteLine($"\n✓ Result: {num1} / {num2} = {result}\n");
                            break;
                        case 5: // Modulus
                            // Prevent modulus by zero error
                            if (num2 == 0)
                            {
                                Console.WriteLine("\n Error: Modulus by zero is not allowed.\n");
                                continue;
                            }
                            result = num1 % num2;
                            Console.WriteLine($"\n✓ Result: {num1} % {num2} = {result}\n");
                            break;
                        case 6: // Exponentiation
                            result = Math.Pow(num1, num2);
                            Console.WriteLine($"\n✓ Result: {num1} ^ {num2} = {result}\n");
                            break;
                    }
                }
                catch (FormatException)
                {
                    // Handle invalid number format input
                    Console.WriteLine("\n Invalid input. Please enter numeric values.\n");
                }
                catch (Exception ex)
                {
                    // Handle any other unexpected errors
                    Console.WriteLine($"\n An error occurred: {ex.Message}\n");
                }

                // Prompt user to continue or exit
                Console.WriteLine("─────────────────────────────────────");
                Console.Write("Do you want to perform another calculation? (y/n): ");
                string choiceContinue = Console.ReadLine()?.ToLower() ?? "n";
                
                // Exit if user doesn't want to continue
                if (choiceContinue != "y")
                {
                    // Display goodbye message
                    Console.WriteLine("\n╔════════════════════════════════════╗");
                    Console.WriteLine("║  Thank you for using Calculator!   ║");
                    Console.WriteLine("║           Goodbye!               ║");
                    Console.WriteLine("╚════════════════════════════════════╝");
                    break;
                }
                
                Console.WriteLine(); // Add spacing for next iteration
            }
        }
    }
}