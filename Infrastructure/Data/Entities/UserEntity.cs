using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    /*    public string PasswordHash { get; set; }*/
        public DateTime RegisteredDate { get; set; }
        /*public Role Role { get; set; }*/
    }
}
