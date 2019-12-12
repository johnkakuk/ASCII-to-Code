using System;
using System.Threading;

namespace ASCII_to_Code
{
    public class Validate
    {
        // Validate a string is not white space
        public static bool String(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid entry. Please try again.");
                Console.ResetColor();
                Thread.Sleep(750);
                return false;
            }
            else
            {
                return true;
            }
        }




        // Validate a menu selection
        public static bool Menu(string input, int maximum)
        {
            int output = 0;

            if (string.IsNullOrWhiteSpace(input) || (!int.TryParse(input, out output)) || output < 0 || output > maximum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid selection. Please try again.");
                Console.ResetColor();
                Thread.Sleep(750);
                return false;
            }
            else
            {
                return true;
            }
        }




        // Validate an Integer
        public static bool Integer(string input)
        {
            int output = 0;

            if (string.IsNullOrWhiteSpace(input) || (!int.TryParse(input, out output)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid entry. Please try again.");
                Console.ResetColor();
                Thread.Sleep(750);
                return false;
            }
            else
            {
                return true;
            }
        }




        // Validate a Double
        public static bool Double(string input)
        {
            double output = 0;

            if (string.IsNullOrWhiteSpace(input) || (!double.TryParse(input, out output)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid entry. Please try again.");
                Console.ResetColor();
                Thread.Sleep(750);
                return false;
            }
            else
            {
                return true;
            }
        }




        // Validate a Float
        public static bool Float(string input)
        {
            float output = 0;

            if (string.IsNullOrWhiteSpace(input) || (!float.TryParse(input, out output)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid entry. Please try again.");
                Console.ResetColor();
                Thread.Sleep(750);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
