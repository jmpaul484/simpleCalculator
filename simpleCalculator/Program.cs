//Jonathan Paul
//RCET2265
//Fall 2026
//Simple Calculator
//https://github.com/jmpaul484/simpleCalculator.git

namespace simpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userInput = "";
            String UserPrompt = "Choose one of the following options: " +
                                "\n 1. Add " +
                                "\n 2. Subtract " +
                                "\n 3. Multiply " +
                                "\n 4. Divide " +
                                " (If you divide it will round to the lower whole number)";
            int firstNumber;
            int secondNumber;

            // Tells the user to input a number and stores it in the variable userInput
            Console.WriteLine("Choose a Number:");
            // Reads the user input and stores it in the variable userInput
            userInput = Console.ReadLine();
            // Converts the user input from a string to an integer and stores it in the variable firstNumber
            firstNumber = int.Parse(userInput);

            // Tells the user to input a number and stores it in the variable userInput
            Console.WriteLine("Choose a Number:");
            // Reads the user input and stores it in the variable userInput
            userInput = Console.ReadLine();
            // Converts the user input from a string to an integer and stores it in the variable firstNumber
            secondNumber = int.Parse(userInput);

            // Tells the user to choose an option and stores it in the variable userInput
            Console.WriteLine(UserPrompt);
            // Reads the user input and stores it in the variable userInput
            userInput = Console.ReadLine();
            // If the user input is "1", then add the two numbers and display the result
            if (userInput == "1")
            {
                // Adds the two numbers and displays the result
                Console.WriteLine($"The result is: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            }
             else if (userInput == "2")
            {
                // Subtracts the two numbers and displays the result
                Console.WriteLine($"The result is: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            }
            else if (userInput == "3")
            {
                // Multiplies the two numbers and displays the result
                Console.WriteLine($"The result is: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            }
            else if (userInput == "4")
            {
                // Divides the two numbers and displays the result
                Console.WriteLine($"The result is: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            }

            //pause
            Console.ReadLine();
        }
    }
}
