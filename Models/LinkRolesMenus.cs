using System;
using System.Collections.Generic;

namespace ContactList.Models
{
    public partial class LinkRolesMenus
    {
        public int Pkey { get; set; }
        public int RolesPkey { get; set; }
        public int MenusPkey { get; set; }

        public virtual Menus MenusPkeyNavigation { get; set; }
        public virtual Roles RolesPkeyNavigation { get; set; }
    }
}
