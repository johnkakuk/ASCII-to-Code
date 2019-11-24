using System;
using System.Collections.Generic;

namespace ASCII_to_Code
{
    class Art
    {
        public static void Create()
        {
        Start:
            Console.Clear();
            Console.WriteLine(@"   _   ___  ___ ___ ___   _          ___         _     ");
            Console.WriteLine(@"  /_\ / __|/ __|_ _|_ _| | |_ ___   / __|___  __| |___ ");
            Console.WriteLine(@" / _ \\__ \ (__ | | | |  |  _/ _ \ | (__/ _ \/ _` / -_)");
            Console.WriteLine(@"/_/ \_\___/\___|___|___|  \__\___/  \___\___/\__,_\___|");
            Console.WriteLine(@"                                                       ");
            Console.WriteLine("Enter your ASCII art. Type \"done\" on a newline when finished.");
            Console.WriteLine("Type \"clear\" on a newline to start over.");
            Console.WriteLine("Type \"exit\" on a newline to return to the main menu.");

            List<string> UserInput = new List<string>();
            List<string> Output = new List<string>();
            string currentLine;

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
                    goto Start;
                case "done":
                    goto Operate;
                case "exit":
                    goto End;
            }

            goto Capture;

        Operate:
            Console.Clear();

            // FOR each list item of user input,
            // CREATE a new list item FOR output,
            // RUN the input THROUGH GenerateCode, and
            // PLACE the new code INTO the new output item.
            for (int i = 0; i < UserInput.Count; i++)
            {
                currentLine = GenerateCode(UserInput[i]);
                Output.Add(currentLine);
                Console.WriteLine(Output[i]);
            }

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            goto Start;

        End:;
        }

        // Generate a line of C# code based on input from the user
        public static string GenerateCode(string input)
        {
            string output = string.Format("Console.WriteLine(@\"{0}\");", input);
            return output;
        }
    }
}
