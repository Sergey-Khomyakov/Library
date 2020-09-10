using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.PL.Models
{
    public class FileModel
    {
        public int FileId { get; set; }
        public string FileFormat { get; set; }
        public byte[] BookFile { get; set; }
    }
}