using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.PL.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Descriptionn { get; set; }
        public DateTime DateCreatedBook { get; set; }
    }
}