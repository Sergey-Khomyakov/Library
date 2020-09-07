using System;
using System.Collections.Generic;

namespace Library.Entity_Framework
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Descriptionn { get; set; }
        public DateTime DateCreatedBook { get; set; }
    }
}
