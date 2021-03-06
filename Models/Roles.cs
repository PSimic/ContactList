﻿using System;
using System.Collections.Generic;

namespace ContactList.Models
{
    public partial class Roles
    {
        public Roles()
        {
            LinkRolesMenus = new HashSet<LinkRolesMenus>();
            Users = new HashSet<Users>();
        }

        public int Pkey { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LinkRolesMenus> LinkRolesMenus { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
