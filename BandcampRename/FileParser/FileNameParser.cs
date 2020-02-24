using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace BandcampRename.FileParser
{
    public class FileNameParser : IFileParser
    {
        public string GetNewName(string filePath)
        {
            var filename = Path.GetFileName(filePath);
            var newfilename = filename;

            var match = Regex.Match(filename, " - \\d\\d ");
            if (match.Success)
            {
                var index = match.Index;
                newfilename = filename.Substring(index + 3);
            }
            return newfilename;
        }
    }
}
