using System;
using System.Collections.Generic;
using System.Text;

namespace BandcampRename.FileParser
{
    public interface IFileParser
    {
        string GetNewName(string filePath);
    }
}
