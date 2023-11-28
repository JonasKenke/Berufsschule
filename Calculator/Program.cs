namespace Calculator
{
    using System;

    class Calculator
    {
        private readonly double _num1;
        private readonly double _num2;

        public Calculator(double num1, double num2)
        {
            this._num1 = num1;
            this._num2 = num2;
        }

        public double Add() => _num1 + _num2;
        public double Subtract() => _num1 - _num2;
        public double Multiply() => _num1 * _num2;
        public double Divide()
        {
            if (_num2 != 0)
            {
                return _num1 / _num2;
            }
            else
            {
                throw new InvalidOperationException("Cannot divide by zero.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    break;
                }

                if (int.TryParse(choice, out int operation) && operation >= 1 && operation <= 4)
                {
                    Console.Write("Enter the first number: ");
                    if (!double.TryParse(Console.ReadLine(), out double num1))
                    {
                        Console.WriteLine("Invalid input for the first number. Please enter a valid number.\n");
                        continue;
                    }

                    Console.Write("Enter the second number: ");
                    if (!double.TryParse(Console.ReadLine(), out double num2))
                    {
                        Console.WriteLine("Invalid input for the second number. Please enter a valid number.\n");
                        continue;
                    }

                    Calculator calculator = new Calculator(num1, num2);
                    double result = 0;

                    switch (operation)
                    {
                        case 1:
                            result = calculator.Add();
                            break;
                        case 2:
                            result = calculator.Subtract();
                            break;
                        case 3:
                            result = calculator.Multiply();
                            break;
                        case 4:
                            try
                            {
                                result = calculator.Divide();
                            }
                            catch (InvalidOperationException e)
                            {
                                Console.WriteLine($"Error: {e.Message}\n");
                                continue;
                            }
                            break;
                    }

                    Console.WriteLine($"Result: {result}\n");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.\n");
                }
            }
        }
    }

}