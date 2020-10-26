using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
       /* public string PasswordHash { get; set; }*/
        public DateTime RegisteredDate { get; set; }
        public Role Role { get; set; }
    }
}
