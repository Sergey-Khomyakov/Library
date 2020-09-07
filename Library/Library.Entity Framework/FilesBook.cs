using System;
using System.Collections.Generic;

namespace Library.Entity_Framework
{
    public partial class FilesBook
    {
        public int FilesBookId { get; set; }
        public int BookId { get; set; }
        public int FileId { get; set; }
    }
}
