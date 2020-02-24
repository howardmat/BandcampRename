using System;

namespace BandcampRename
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get all files in all folders
            var parser = new FolderParser();
            var files = parser.Parse();

            // Display all files to the user
            var consoleOutput = new ConsoleOutput();
            consoleOutput.PrintToConsole(files);

            // Prompt the user to indicate if they want to proceed with renaming
            Console.WriteLine("Do you want to rename the files? [y/n]");

            // Get a valid user response
            var userResponse = Console.ReadLine().ToLower();
            while (userResponse != "y" && userResponse != "n")
            {
                Console.WriteLine("Invalid response. Please enter 'y' for Yes or 'n' for No (without the quotes)");
                userResponse = Console.ReadLine();
            }
            
            // Check the user response and act accordingly
            if (userResponse == "y")
            {
                var renamer = new FileRenamer();
                renamer.RenameCollection(files);
            }
        }
    }
}
