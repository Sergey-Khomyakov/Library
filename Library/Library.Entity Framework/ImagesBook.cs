using System;
using System.Collections.Generic;

namespace Library.Entity_Framework
{
    public partial class ImagesBook
    {
        public int ImagesBookId { get; set; }
        public int BookId { get; set; }
        public int ImageId { get; set; }

    }
}
