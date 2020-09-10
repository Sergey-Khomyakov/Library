using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.PL.Models
{
    public class AuthorModel
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fatherland { get; set; }
    }
}