using System;
using System.Collections.Generic;

namespace ContactList.Models
{
    public partial class Users
    {
        public int Pkey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? RolesPkey { get; set; }

        public virtual Roles RolesPkeyNavigation { get; set; }
    }
}
