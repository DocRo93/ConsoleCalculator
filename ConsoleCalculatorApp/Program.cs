using System;
class Program
{
    static void Main(string[] args)
    {

        bool validInput = false;
        int option = 0;
        decimal number1 = 0;
        decimal number2 = 0;
        bool systemExit = false;

        List<string> history = new List<string>();

        while (!systemExit)
        {

            Console.Clear();

            //Display
            Console.WriteLine("================================");
            Console.WriteLine(" ");
            Console.WriteLine("C# CONSOLE CALCULATOR");
            Console.WriteLine(" ");
            Console.WriteLine("================================");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            //menu
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulus");
            Console.WriteLine("6. Exit");
            Console.WriteLine("================================");
            Console.WriteLine("Extra Functions:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("7. Power");
            Console.WriteLine("8. Square Root");
            Console.WriteLine("9. HISTORY");


            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------");
            //Input instructions
            Console.WriteLine(" ");

            //select option
            Console.WriteLine("Select an option:");
            string? inputSelection = Console.ReadLine();
            validInput = false;

            while (!validInput)
            {
                if (int.TryParse(inputSelection, out option))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error, try again!");
                    inputSelection = Console.ReadLine();
                    validInput = false;
                }
            }

            //check for exit
            if (option == 6)
            {
                systemExit = true;
                Console.WriteLine("================================");
                Console.WriteLine(" ");
                Console.WriteLine("------Thank you for using-------");
                Console.WriteLine(" ");
                Console.WriteLine("-----C# CONSOLE CALCULATOR------");
                Console.WriteLine(" ");
                Console.WriteLine("================================");
                continue;
            }

            Console.WriteLine(" ");

            //User input - number 1
            Console.WriteLine("Enter first number");
            string? inputNumber1 = Console.ReadLine();
            validInput = false;

            while (!validInput)
            {
                if (decimal.TryParse(inputNumber1, out number1))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error, try again!");
                    inputNumber1 = Console.ReadLine();
                    validInput = false;
                }
            }

            //User input - number 2
            Console.WriteLine("Enter second number");
            string? inputNumber2 = Console.ReadLine();
            validInput = false;

            while (!validInput)
            {
                if (decimal.TryParse(inputNumber2, out number2))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error, try again!");
                    inputNumber2 = Console.ReadLine();
                    validInput = false;
                }
            }

            // Output
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" ");

            //Operation selection
            if (option == 1)
            {
                decimal result = add(number1, number2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{number1} + {number2} = {result}");
                history.Add($"{number1} + {number2} = {result}");
            } else if (option == 2){
                decimal result = subtract(number1, number2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{number1} - {number2} = {result}");
                history.Add($"{number1} - {number2} = {result}");
            } else if (option == 3)
            {
                decimal result = multiply(number1, number2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{number1} x {number2} = {result}");
                history.Add($"{number1} x {number2} = {result}");
            } else if (option == 4)
            {
                decimal result = divide(number1, number2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{number1} / {number2} = {result}");
                history.Add($"{number1} / {number2} = {result}");
            } else if (option == 5)
            {
                decimal result = modulus(number1, number2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{number1} % {number2} = {result}");
                history.Add($"{number1} % {number2} = {result}");
            } else if (option == 7)
            {
                decimal result = power(number1, number2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{number1} to the power of {number2} = {result}");
                history.Add($"{number1} to the power of {number2} = {result}");
            } else if (option == 8)
            {
                decimal result = root(number1, number2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"Square root of {number1} = {result}");
                history.Add($"Square root of {number1} = {result}");
            }
            else if (option == 9)
            {
                Console.WriteLine("Calculation history:");
                foreach (string calculation in history)
                {
                    Console.WriteLine(calculation);
                }
            }
            else if (option == 6) {
                systemExit = true;
                break;
            } else
            {
                Console.WriteLine("Please only choose an option between 1-6");
                continue;
            }

            Console.WriteLine(" ");
            Console.WriteLine("================================");
            Console.WriteLine("================================");
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();

        }

        //Methods

        //Addition
        decimal add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        //Subtraction
        decimal subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        //multiplication
        decimal multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        //Division
        decimal divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        //Division
        decimal modulus(decimal num1, decimal num2)
        {
            return num1 % num2;
        }

        //Power
        decimal power(decimal num1, decimal num2)
        {
            double power = Math.Pow((double)num1, (double)num2);
            return (decimal)power;
        }

        //Square Root
        decimal root(decimal num1, decimal num2)
        {
            double root = Math.Sqrt((double)num1);
            return (decimal)root;
        }

    }
}
