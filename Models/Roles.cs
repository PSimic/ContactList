using System;
using System.Collections.Generic;

namespace ContactList.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Users = new HashSet<Users>();
        }

        public int Pkey { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
