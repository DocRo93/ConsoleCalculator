using System;
class Program
{
    static void Main(string[] args)
    {

        bool validInput = false;
        int option = 0;
        decimal number1 = 0;
        decimal number2 = 0;

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


        if (option == 1)
        {
            Console.WriteLine("Answer:");
            Console.WriteLine($"{number1} + {number2} = {add(number1,number2)}");
        }
     
        Console.WriteLine(" ");
        Console.WriteLine("================================");
        Console.WriteLine("================================");



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

    }
}
