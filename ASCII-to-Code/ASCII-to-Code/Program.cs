using System;
using System.Threading;

namespace ASCII_to_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuSelectionString = null;
            int menuSelection = 0;
            Settings Config = new Settings(0, 0, 0, 0);
            Config.SetLanguage(1);
            Config.SetBorders(1);
            Config.SetAlign(1);
            Config.SetWidth(80);

        /* Languages:
         * 1 = C# (default)
         * 2 = C
         * 3 = C++
         * 4 = Java
         * 5 = Python */

        /* Text borders:
         * 1 = None (default)
         * 2 = Top only
         * 3 = Bottom only
         * 4 = Left only
         * 5 = Right only
         * 6 = Top and bottom
         * 7 = Left and right
         * 8 = All */

        /* Alignment:
         * 1 = Left (default)
         * 2 = Center
         * 3 = Right */


        Start:
            Console.Clear();
            Console.WriteLine(@"   _   ___  ___ ___ ___   _          ___         _     ");
            Console.WriteLine(@"  /_\ / __|/ __|_ _|_ _| | |_ ___   / __|___  __| |___ ");
            Console.WriteLine(@" / _ \\__ \ (__ | | | |  |  _/ _ \ | (__/ _ \/ _` / -_)");
            Console.WriteLine(@"/_/ \_\___/\___|___|___|  \__\___/  \___\___/\__,_\___|");
            Console.WriteLine(@"                                                       ");
            Console.WriteLine("Welcome to the ASCII to Code generator.");
            Console.WriteLine("\r\nWhat would you like to do?");
            Console.WriteLine("1. Choose program language    [{0}]", Config.DisplayLanguage());
            Console.WriteLine("2. Set text borders:          [{0}]", Config.DisplayBorders());
            Console.WriteLine("3. Change alignment:          [{0}]", Config.DisplayAlign());
            Console.WriteLine("4. Change character width:    [{0} characters]", Config.GetWidth());
            Console.WriteLine("5. Process ASCII text art");
            Console.WriteLine("\r\n0. Exit");
            menuSelectionString = Console.ReadLine();

            if (Validate.Menu(menuSelectionString, 5))
            {
                menuSelection = int.Parse(menuSelectionString);
            }
            else
            {
                menuSelection = -1;
            }

            switch (menuSelection)
            {
                case 1:
                    int language = SetLanguage();
                    Config.SetLanguage(language);
                    Console.WriteLine("Language set to {0}.", Config.DisplayLanguage());
                    Thread.Sleep(750);
                    break;
                case 2:
                    int borders = SetBorders();
                    Config.SetBorders(borders);
                    Console.WriteLine("Borders set to {0}.", Config.DisplayBorders());
                    Thread.Sleep(750);
                    break;
                case 3:
                    int align = SetAlign();
                    Config.SetAlign(align);
                    Console.WriteLine("Alignment set to align {0}.", Config.DisplayAlign());
                    Thread.Sleep(750);
                    break;
                case 4:
                    int width = SetWidth();
                    Config.SetWidth(width);
                    Console.WriteLine("Character width set to {0} characters.", Config.GetWidth());
                    Thread.Sleep(750);
                    break;
                case 5:
                    Art.Create();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                case -1:
                    break;
            }
            goto Start;
        }

        public static int SetLanguage()
        {
            bool inputIsBad = true;
            int userSelection = 1;
            string userSelectionString;

            while (inputIsBad)
            {
                Console.Clear();
                Console.WriteLine("Which language would you like to use?");
                Console.WriteLine("1. C#");
                Console.WriteLine("2. C");
                Console.WriteLine("3. C++");
                Console.WriteLine("4. Java");
                Console.WriteLine("5. Python");
                userSelectionString = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userSelectionString) || (!int.TryParse(userSelectionString, out userSelection)) || userSelection > 5 || userSelection < 1)
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                } else
                {
                    inputIsBad = false;
                }
            }

            return userSelection;
        }

        public static int SetBorders()
        {
            bool inputIsBad = true;
            int userSelection = 1;
            string userSelectionString;

            while (inputIsBad)
            {
                Console.Clear();
                Console.WriteLine("Which borders would you like to use?");
                Console.WriteLine("1. None");
                Console.WriteLine("2. Top Only");
                Console.WriteLine("3. Bottom Only");
                Console.WriteLine("4. Left Only");
                Console.WriteLine("5. Right Only");
                Console.WriteLine("6. Top and Bottom");
                Console.WriteLine("7. Left and Right");
                Console.WriteLine("8. All");
                
                userSelectionString = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userSelectionString) || (!int.TryParse(userSelectionString, out userSelection)) || userSelection > 8 || userSelection < 1)
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
                else
                {
                    inputIsBad = false;
                }
            }

            return userSelection;
        }

        public static int SetAlign()
        {
            bool inputIsBad = true;
            int userSelection = 1;
            string userSelectionString;

            while (inputIsBad)
            {
                Console.Clear();
                Console.WriteLine("Which alignment would you like to use?");
                Console.WriteLine("1. Left");
                Console.WriteLine("2. Center");
                Console.WriteLine("3. Right");

                userSelectionString = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userSelectionString) || (!int.TryParse(userSelectionString, out userSelection)) || userSelection > 3 || userSelection < 1)
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
                else
                {
                    inputIsBad = false;
                }
            }

            return userSelection;
        }

        public static int SetWidth()
        {
            bool inputIsBad = true;
            int userSelection = 1;
            string userSelectionString;

            while (inputIsBad)
            {
                Console.Clear();
                Console.WriteLine("Enter desired character width:");

                userSelectionString = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userSelectionString) || (!int.TryParse(userSelectionString, out userSelection)) || userSelection < 1)
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
                else
                {
                    inputIsBad = false;
                }
            }

            return userSelection;
        }
	}
}
