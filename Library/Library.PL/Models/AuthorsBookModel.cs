using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.PL.Models
{
    public class AuthorsBookModel
    {
        public int AuthorsBookId { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}