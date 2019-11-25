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
Console.WriteLine(@"             /_/ \_\___/\___|___|___|  \__\___/  \___\___/\__,_\___|           ");
Console.WriteLine(@"                                                                                 ");```
<br><br><br>
## Files
### ASCIIGenerator
Current C# source files for the program.
> * Challenges: Contains specs for different aspects of the main challenge program. 
> * Research: Contains various assets compiled and reports produced for this class.

### Docs
> * Contains reference material for development.