using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ASCIIGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			// Make the window width changeable
			// Export user input to a list where each list item is one line of characters
			// Run each list item through the GenerateLine method
			// Print each list item on screen for copying and pasting


			Console.WriteLine("Enter your string. Type \"done\" on a new line when finished.");

			List<string> userInput = new List<string>();
			List<string> output = new List<string>();
			string currentLine;

			while ((currentLine = Console.ReadLine()) != "done")
			{
				// Either you do here something with each line separately or
				userInput.Add(currentLine);
			}

			Console.Clear();

			for (int i = 0; i < userInput.Count; i++)
			{
				currentLine = GenerateLine(userInput[i]);
				output.Add(currentLine);
				Console.WriteLine(output[i]);
			}
		}

		// Generate a line of C# code based on input from the user
		public static string GenerateLine(string input)
		{
			string output = string.Format("Console.WriteLine(@\"{0}\");", input);
			return output;
		}
	}
}
