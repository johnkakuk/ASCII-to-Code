﻿using System;
using System.Collections.Generic;

namespace ASCII_to_Code
{
    class Art
    {
        public static void Create(Settings Config)
        {
            // Setup
            bool topBorderToggle = false;
            bool bottomBorderToggle = false;
            string topBorder = null;
            string bottomBorder = null;
            List<string> UserInput = new List<string>();
            List<string> Output = new List<string>();
            string currentLine;

            // Print borders if applicable
            if ((Config.GetBorders() == 2) || (Config.GetBorders() == 4))
            {
                topBorder = BuildBorder(Config.GetBorderType(), Config.GetWidth());
                topBorderToggle = true;
            }
            if ((Config.GetBorders() == 3) || (Config.GetBorders() == 4))
            {
                bottomBorder = BuildBorder(Config.GetBorderType(), Config.GetWidth());
                bottomBorderToggle = true;
            }

        Start:
            Console.Clear();
            Console.WriteLine(@"################################################################################");
            Console.WriteLine(@"                _   ___  ___ ___ ___   _          ___         _                 ");
            Console.WriteLine(@"               /_\ / __|/ __|_ _|_ _| | |_ ___   / __|___  __| |___             ");
            Console.WriteLine(@"              / _ \\__ \ (__ | | | |  |  _/ _ \ | (__/ _ \/ _` / -_)            ");
            Console.WriteLine(@"             /_/ \_\___/\___|___|___|  \__\___/  \___\___/\__,_\___|            ");
            Console.WriteLine(@"                                                                                ");
            Console.WriteLine(@"################################################################################");
            Console.WriteLine("Paste your ASCII art. Type \"done\" on a newline when finished.");
            Console.WriteLine("Type \"clear\" on a newline to start over.");
            Console.WriteLine("Type \"exit\" on a newline to return to the main menu.");


        Capture:
            // Capture user input, line-by-line, until the user types an escape statement on a new line
            currentLine = Console.ReadLine();
            if
                (
                currentLine != "clear" &&               // Escape statements:   Clear (start over)
                currentLine != "done" &&                //                      Done (process into code)
                currentLine != "exit"                   //                      Exit (return to Main())
                )
            {
                UserInput.Add(currentLine);
            }

            switch (currentLine)
            {
                case "clear":
                    UserInput.Clear();
                    goto Start;
                case "done":
                    goto Operate;
                case "exit":
                    goto End;
            }

            goto Capture;

        Operate:
            Console.Clear();

            // Add borders to list if applicable
            if (topBorderToggle == true)
            {
                currentLine = GenerateCode(topBorder, Config);
                Output.Add(currentLine);
                topBorderToggle = false;
            }

            // FOR each list item of user input,
            // CREATE a new list item FOR output,
            // RUN the input THROUGH GenerateCode, and
            // PLACE the new code INTO the new output item.
            for (int i = 0; i < UserInput.Count; i++)
            {
                currentLine = GenerateCode(UserInput[i], Config);
                Output.Add(currentLine);
            }

            if (bottomBorderToggle == true)
            {
                currentLine = GenerateCode(bottomBorder, Config);
                Output.Add(currentLine);
            }


            // Print final results
            for (int i = 0; i < Output.Count; i++)
            {
                Console.WriteLine(Output[i]);
            }

            Console.WriteLine("\r\nPress enter to continue...");
            Console.ReadLine();
            goto Start;

        End:;
        }

        // Generate a line of C# code based on input from the user
        public static string GenerateCode(string input, Settings Config)
        {
            string output = null;

            // Apply the alignment
            switch (Config.GetAlign())
            {
                case 1: // Align Left
                    while (input.Length < Config.GetWidth())
                    {
                        input = string.Format("{0}{1}", input, " ");
                    }
                    break;
                case 2: // Align Center
                    while (input.Length < Config.GetWidth())
                    {
                        input = string.Format("{0}{1}{2}", " ", input, " ");
                    }
                    break;
                case 3: // Align Right
                    while (input.Length < Config.GetWidth())
                    {
                        input = string.Format("{0}{1}", " ", input);
                    }
                    break;
            }

            // Apply the Code
            switch (Config.GetLanguage())
            {
                case 1:
                    output = string.Format("Console.WriteLine(@\"{0}\");", input);
                    break;
                case 2:
                    output = string.Format("printf(\"{0}\"); *NOT FUNCTIONAL YET*", input);
                    break;
                case 3:
                    output = string.Format("cout << \"{0}\"; **NOT FUNCTIONAL YET*", input);
                    break;
                case 4:
                    output = string.Format("System.out.println(\"{0}\"); **NOT FUNCTIONAL YET**", input);
                    break;
                case 5:
                    output = string.Format("print(\"{0}\") **NOT FUNCTIONAL YET**", input);
                    break;
            }
            return output;
        }

        public static string BuildBorder(string pattern, int width)
        {
            string output = "";

            while (output.Length < width)
            {
                output = string.Format("{0}{1}", output, pattern);
            }

            output = Truncate(output, width);

            return output;
        }

        public static string Truncate(string input, int maxLength)
        {
            if (!string.IsNullOrEmpty(input) && input.Length > maxLength)
            {
                return input.Substring(0, maxLength);
            }

            return input;
        }
    }
}
