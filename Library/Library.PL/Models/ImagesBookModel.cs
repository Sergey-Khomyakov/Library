using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.PL.Models
{
    public class ImagesBookModel
    {
        public int ImagesBookId { get; set; }
        public int BookId { get; set; }
        public int ImageId { get; set; }
    }
}