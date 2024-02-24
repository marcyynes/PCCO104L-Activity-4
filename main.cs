using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        int previousNumber = 0;
        string message = "";

        Console.WriteLine("Enter 'exit' to quit the program.");

        while (true)
        {
            Console.Write("Enter a value: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the program...");
                break;
            }

            int number;
            bool isNumeric = int.TryParse(input, out number);

            if (isNumeric)
            {
                int currentNumber = int.Parse(input);
                int sum = previousNumber + currentNumber;
                Console.WriteLine($"Sum of {previousNumber} and {currentNumber} is {sum}.");
                previousNumber = currentNumber;
            }
            else
            {
                message += input + " ";
                Console.WriteLine("Message so far: " + message);
            }
        }

        Console.WriteLine("Final message: " + message);
    }
}