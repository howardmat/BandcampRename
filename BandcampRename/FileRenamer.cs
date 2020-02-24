using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BandcampRename
{
    public class FileRenamer
    {
        public void RenameCollection(Folder[] folders)
        {
            // Iterate folder collection
            foreach (var folder in folders)
            {
                // Iterate files in each folder
                foreach (var file in folder.Files)
                {
                    // Rename to new name
                    File.Move(file.FullPath, file.NewPath);
                }
            }
        }
    }
}
