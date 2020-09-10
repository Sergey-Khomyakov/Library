using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.PL.Models
{
    public class ImageModel
    {
        public int ImageId { get; set; }
        public byte[] ImageFile { get; set; }
    }
}