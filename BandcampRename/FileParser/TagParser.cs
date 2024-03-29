﻿using System;
using System.Collections.Generic;
using TagLib;
using System.Text;

namespace BandcampRename.FileParser
{
    public class TagParser : IFileParser
    {
        public string GetNewName(string filePath)
        {
            // Read data with TagLib Sharp
            // Open the file
            var file = File.Create(filePath);

            // Get the track number and format with leading 0 if necessary
            var trackStr = file.Tag.Track.ToString();
            if (file.Tag.Track == 0)
                trackStr = "01";
            else if (file.Tag.Track < 10)
                trackStr = "0" + trackStr;            

            // Set filename
            return $"{trackStr} {file.Tag.Title}.mp3";
        }
    }
}
