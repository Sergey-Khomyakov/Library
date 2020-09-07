using System;
using System.Collections.Generic;

namespace Library.Entity_Framework
{
    public partial class File
    {
        public int FileId { get; set; }
        public string FileFormat { get; set; }
        public byte[] BookFile { get; set; }
    }
}
