# C# Console Calculator

A menu-driven console calculator built in C# as a learning project, covering variables, user input, type conversion, operators, conditionals, switch logic, loops, and input validation.

## Features

### Core Operations
- Addition
- Subtraction
- Multiplication
- Division
- Modulus

### Extended Operations
- Power (exponentiation)
- Square Root
- Percentage
- Calculation History — view a log of every calculation performed this session
- Calculation Counter — displays the total number of calculations completed on exit

### Validation & UX
- Menu selection is validated (must be a real number matching a menu option)
- Numeric input is validated using `TryParse`, with re-prompting on invalid entries
- Square Root only prompts for a single number, since it only needs one
- History and Exit skip number entry entirely, since neither requires it
- Screen clears between each calculation for a clean, readable interface
- Returns to the main menu automatically after each calculation

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/DocRo93/ConsoleCalculator.git
   ```
2. Open `ConsoleCalculatorApp.slnx` in Visual Studio.
3. Run the project using **Ctrl+F5** (Start Without Debugging) — this ensures the console clearing behaves correctly in a standalone window.

## Project Structure

```
ConsoleCalculatorApp/
├── Program.cs        # Main application logic and calculator methods
.gitignore             # Excludes build artifacts and IDE files from version control
```

## Development Approach

This project was built incrementally using Git feature branches, with each stage of functionality committed separately:

| Branch | Contents |
|---|---|
| `step1-heading-menu` | Menu display, input handling, operation selection, modulus |
| `extension-methods` | Power, square root, calculation history |
| `extension-counter-percentage` | Percentage operation, calculation counter |

All branches were merged into `main` once tested and working.

## Concepts Practiced

- Variables, constants, and type inference (`var`)
- Nullable reference types (`string?`) and null-coalescing (`??`)
- Value types vs. reference types
- `while` loops, `break`, and `continue`
- Input validation using `TryParse`
- String interpolation (`$"..."`)
- Methods and return values
- Type casting (`decimal` ↔ `double`)
- Collections (`List<string>`)
- `foreach` iteration
- Ternary operator

## Author

Built as part of an SDET onboarding learning path.
