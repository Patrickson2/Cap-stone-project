# Simple C# Calculator

A beginner-friendly console calculator application built with C# that performs basic arithmetic operations with an intuitive menu-driven interface.

## Description

This calculator provides a clean, interactive console interface for performing mathematical calculations. The application runs in a continuous loop, allowing users to perform multiple calculations without restarting the program.

## Features

- **Six Mathematical Operations:**
  - Addition (+)
  - Subtraction (-)
  - Multiplication (*)
  - Division (/)
  - Modulus (%)
  - Power/Exponentiation (^)

- **Robust Error Handling:**
  - Division by zero protection
  - Invalid input validation
  - Format exception handling

- **User Experience:**
  - Clean, bordered interface with Unicode characters
  - Menu-driven operation selection
  - Continuous operation mode
  - Graceful exit option

## Prerequisites

- .NET SDK 6.0 or later
- Any terminal/command prompt

## How to Run

### Method 1: Using .NET CLI
```bash
# Clone the repository
git clone <repository-url>

# Navigate to the project directory
cd miCapstone-projo/SimpleCalculator

# Run the application
dotnet run
```

### Method 2: Build and Execute
```bash
# Build the project
dotnet build

# Run the executable
dotnet bin/Debug/net6.0/SimpleCalculator.dll
```

### Method 3: Direct Compilation
```bash
# Compile the source file
csc Program.cs

# Run the executable
./Program.exe  # Windows
mono Program.exe  # Linux/macOS
```

## Usage

1. **Start the Application:** Run the program using any of the methods above
2. **Select Operation:** Choose from the menu (1-6)
3. **Enter Numbers:** Input your first and second numbers when prompted
4. **View Result:** The calculation result will be displayed
5. **Continue or Exit:** Choose 'y' to perform another calculation or 'n' to exit

## Example Session

```
╔════════════════════════════════════╗
║   Welcome to Simple Calculator     ║
╚════════════════════════════════════╝

Select an operation:
1. Addition (+)
2. Subtraction (-)
3. Multiplication (*)
4. Division (/)
5. Modulus (%)
6. Power (^)

Enter your choice (1-6): 1
Enter the first number: 15
Enter the second number: 25

✓ Result: 15 + 25 = 40

─────────────────────────────────────
Do you want to perform another calculation? (y/n): n

╔════════════════════════════════════╗
║  Thank you for using Calculator!   ║
║           Goodbye!               ║
╚════════════════════════════════════╝
```

## Project Structure

```
miCapstone-projo/
├── SimpleCalculator/
│   ├── Program.cs          # Main calculator logic
│   ├── SimpleCalculator.csproj  # Project configuration
│   ├── bin/               # Compiled binaries
│   └── obj/               # Build artifacts
└── README.MD              # This documentation
```