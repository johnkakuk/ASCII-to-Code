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
            Settings Settings = null;

            /* Languages:
             * 1 = C# (default)
             * 2 = C
             * 3 = C++
             * 4 = Java
             * 5 = Python */
            Settings.SetLanguage(1);
            string activeLanguageDisplay = Settings.GetLanguage();

            /* Text borders:
             * 1 = None (default)
             * 2 = Top only
             * 3 = Bottom only
             * 4 = Left only
             * 5 = Right only
             * 6 = Top and bottom
             * 7 = Left and right
             * 8 = All */
            Settings.SetBorders(1);
            string activeBordersDisplay = Settings.GetBorders();

            /* Alignment:
             * 1 = Left (default)
             * 2 = Center
             * 3 = Right */
            Settings.SetAlign(1);
            string activeAlignDisplay = Settings.GetAlign();

            /* Character width:
             * */
            Settings.SetWidth(80);

        Start:
            Console.Clear();
            Console.WriteLine(@"   _   ___  ___ ___ ___   _          ___         _     ");
            Console.WriteLine(@"  /_\ / __|/ __|_ _|_ _| | |_ ___   / __|___  __| |___ ");
            Console.WriteLine(@" / _ \\__ \ (__ | | | |  |  _/ _ \ | (__/ _ \/ _` / -_)");
            Console.WriteLine(@"/_/ \_\___/\___|___|___|  \__\___/  \___\___/\__,_\___|");
            Console.WriteLine(@"                                                       ");
            Console.WriteLine("Welcome to the ASCII to Code generator.");
            Console.WriteLine("\r\nWhat would you like to do?");
            Console.WriteLine("1. Choose program language [{0}]", activeLanguageDisplay);
            Console.WriteLine("2. Set text borders: [{0}]", activeBordersDisplay);
            Console.WriteLine("3. Change alignment: [{0}]", activeAlignDisplay);
            Console.WriteLine("4. Change character width: [{0}]", Settings.GetWidth());
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
                    Console.WriteLine("Option unavailable.");
                    Thread.Sleep(750);
                    break;
                case 2:
                    Console.WriteLine("Option unavailable.");
                    Thread.Sleep(750);
                    break;
                case 3:
                    Console.WriteLine("Option unavailable.");
                    Thread.Sleep(750);
                    break;
                case 4:
                    Console.WriteLine("Option unavailable.");
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
	}
}
