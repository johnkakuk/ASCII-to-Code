# ASCII to Code
John Kakuk
<br>
<br>
Welcome to my ASCII to Code repository! Thanks for visiting.

**Here's what's what.**<br><br>

## About the Program

This program is a small utility that allows the user to paste ASCII text art (or anything else, for that matter) into the console window. After typing "done" on a new line and pressing enter, the program will process the code and output it as a series of lines of C# code that can be copied and pasted into a user's program. It takes a lot of the repetitive tabbing, copying and pasting out of the process for users who want to use ASCII art in their console applications.

### Example
```
    _   ___  ___ ___ ___   _          ___         _     
   /_\ / __|/ __|_ _|_ _| | |_ ___   / __|___  __| |___ 
  / _ \\__ \ (__ | | | |  |  _/ _ \ | (__/ _ \/ _` / -_)
 /_/ \_\___/\___|___|___|  \__\___/  \___\___/\__,_\___|
 
 done
```
Becomes:<br>
```
Console.WriteLine(@"                _   ___  ___ ___ ___   _          ___         _                 ");
Console.WriteLine(@"               /_\ / __|/ __|_ _|_ _| | |_ ___   / __|___  __| |___             ");
Console.WriteLine(@"              / _ \\__ \ (__ | | | |  |  _/ _ \ | (__/ _ \/ _` / -_)            ");
Console.WriteLine(@"             /_/ \_\___/\___|___|___|  \__\___/  \___\___/\__,_\___|            ");
Console.WriteLine(@"                                                                                ");
```
### Options
Available options include:

 * Support for different programming languages
> * C#
> * C (Pending testing)
> * C++ (Pending testing)
> * Java (Pending testing)
> * Python (Pending testing)

 * Text borders (top, bottom or both)
 * Custom text border pattern (single character or two-character patterns)
 * Text alignment (left, center, right)
 * Custom character width (default 80)

<br><br><br>
## Files
### ASCIIGenerator
Current C# source files for the program.

### Docs
 * Contains reference material for development.