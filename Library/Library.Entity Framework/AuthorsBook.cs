using System;
using System.Collections.Generic;

namespace Library.Entity_Framework
{
    public partial class AuthorsBook
    {
        public int AuthorsBookId { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}
