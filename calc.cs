using System;

namespace SimpleCalculator
{
    class Calculator
    {
        static void Main()
        {
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║   Welcome to Simple Calculator     ║");
            Console.WriteLine("╚════════════════════════════════════╝\n");

            while (true)
            {
                try
                {
                    // Display menu options
                    Console.WriteLine("Select an operation:");
                    Console.WriteLine("1. Addition (+)");
                    Console.WriteLine("2. Subtraction (-)");
                    Console.WriteLine("3. Multiplication (*)");
                    Console.WriteLine("4. Division (/)");
                    Console.WriteLine("5. Modulus (%)");
                    Console.WriteLine("6. Power (^)");
                    Console.Write("\nEnter your choice (1-6): ");

                    // Get user's operation choice
                    int choice = Convert.ToInt32(Console.ReadLine());
                    
                    // Validate choice
                    if (choice < 1 || choice > 6)
                    {
                        Console.WriteLine("\n Invalid choice. Please select a valid operation (1-6).\n");
                        continue;
                    }

                    // Get first number
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    // Get second number
                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;
                    
                    // Perform calculation based on choice
                    switch (choice)
                    {
                        case 1:
                            result = num1 + num2;
                            Console.WriteLine($"\n✓ Result: {num1} + {num2} = {result}\n");
                            break;
                        case 2:
                            result = num1 - num2;
                            Console.WriteLine($"\n✓ Result: {num1} - {num2} = {result}\n");
                            break;
                        case 3:
                            result = num1 * num2;
                            Console.WriteLine($"\n✓ Result: {num1} * {num2} = {result}\n");
                            break;
                        case 4:
                            // Check for division by zero
                            if (num2 == 0)
                            {
                                Console.WriteLine("\n Error: Division by zero is not allowed.\n");
                                continue;
                            }
                            result = num1 / num2;
                            Console.WriteLine($"\n✓ Result: {num1} / {num2} = {result}\n");
                            break;
                        case 5:
                            // Modulus operation
                            if (num2 == 0)
                            {
                                Console.WriteLine("\n Error: Modulus by zero is not allowed.\n");
                                continue;
                            }
                            result = num1 % num2;
                            Console.WriteLine($"\n✓ Result: {num1} % {num2} = {result}\n");
                            break;
                        case 6:
                            // Power operation
                            result = Math.Pow(num1, num2);
                            Console.WriteLine($"\n✓ Result: {num1} ^ {num2} = {result}\n");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n Invalid input. Please enter numeric values.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n An error occurred: {ex.Message}\n");
                }

                // Ask if user wants to continue
                Console.WriteLine("─────────────────────────────────────");
                Console.Write("Do you want to perform another calculation? (y/n): ");
                string choiceContinue = Console.ReadLine()?.ToLower() ?? "n";
                
                if (choiceContinue != "y")
                {
                    Console.WriteLine("\n╔════════════════════════════════════╗");
                    Console.WriteLine("║  Thank you for using Calculator!   ║");
                    Console.WriteLine("║           Goodbye!               ║");
                    Console.WriteLine("╚════════════════════════════════════╝");
                    break;
                }
                
                Console.WriteLine(); // Add blank line for readability
            }
        }
    }
}