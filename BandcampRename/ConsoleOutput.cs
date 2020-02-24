using System;
using System.Collections.Generic;
using System.Text;

namespace BandcampRename
{
    public class ConsoleOutput
    {
        public void PrintToConsole(Folder[] folders)
        {
            foreach (var folder in folders)
            {
                if (folder.Files.Count > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine(folder.Name);
                    Console.WriteLine("------------------------------------");
                    foreach (var file in folder.Files)
                    {
                        Console.WriteLine($"From: {file.CurrentName}");
                        Console.WriteLine($"To: {file.NewName}");
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
