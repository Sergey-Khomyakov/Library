using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.PL.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}