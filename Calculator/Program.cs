using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args) // Entry Point for the Program
        {
            while (true)
            {
                string inp = Console.ReadLine(); // Reads the calculation from the console
                if(inp == "exit")
                {
                    Environment.Exit(0);
                }
                string[] calculation = inp.Split(' '); // Splits the input so we can get the operator

                double output = 0; // Defined output
                try
                {
                    if (calculation[1] == "+")
                    {
                        output = Convert.ToDouble(calculation[0]) + Convert.ToDouble(calculation[2]); // Adds the first to the second double
                        Console.WriteLine("Result: " + output);
                    }
                    else if (calculation[1] == "-")
                    {
                        output = Convert.ToDouble(calculation[0]) - Convert.ToDouble(calculation[2]); // Removes the first to the second double
                        Console.WriteLine("Result: " + output);
                    }
                    else if (calculation[1] == "*")
                    {
                        output = Convert.ToDouble(calculation[0]) * Convert.ToDouble(calculation[2]); // Multiplys the first to the second double
                        Console.WriteLine("Result: " + output);
                    }
                    else if (calculation[1] == "/")
                    {
                        output = Convert.ToDouble(calculation[0]) / Convert.ToDouble(calculation[2]); // Divides the first to the second double
                        Console.WriteLine("Result: " + output);
                    }
                    else
                    {
                        Console.WriteLine("Wrong operator"); // Prints out an Error if no of the calculations where made
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid value");
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("Please leave a space between operators and values");
                }
            }
        }
    }
}