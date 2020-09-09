using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.PL.Models
{
    public class GenresBookModel
    {
        public int GenresBookId { get; set; }
        public int BookId { get; set; }
        public int GenreId { get; set; }
    }
}