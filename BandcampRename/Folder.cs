using System;
using System.Collections.Generic;
using System.Text;

namespace BandcampRename
{
    public class Folder
    {
        public Folder()
        {
            Files = new HashSet<FolderFile>();
        }

        public string FullPath { get; set; }
        public string Name { get; set; }
        public ICollection<FolderFile> Files { get; set; }
    }
}
