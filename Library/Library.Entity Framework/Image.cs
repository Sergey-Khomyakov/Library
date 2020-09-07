using System;
using System.Collections.Generic;

namespace Library.Entity_Framework
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public byte[] ImageFile { get; set; }

    }
}
