using System;

namespace MethodClassAssignment
{
    // This class is responsible for performing math operations
    class MathOperations
    {
        // Void method that receives two integers as parameters
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer
            int result = firstNumber + 10;

            // Display the result of the math operation
            Console.WriteLine("Result after math operation: " + result);

            // Display the second integer to the screen
            Console.WriteLine("Second number: " + secondNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations math = new MathOperations();

            // Call the method passing two numbers
            math.ProcessNumbers(5, 20);

            // Call the method using named parameters
            math.ProcessNumbers(firstNumber: 10, secondNumber: 30);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
