using System;
using System.Collections.Generic;

namespace Library.Entity_Framework
{
    public partial class GenresBook
    {
        public int GenresBookId { get; set; }
        public int BookId { get; set; }
        public int GenreId { get; set; }

    }
}
