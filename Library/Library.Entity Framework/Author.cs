using System;
using System.Collections.Generic;

namespace Library.Entity_Framework
{
    public partial class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fatherland { get; set; }
    }
}
