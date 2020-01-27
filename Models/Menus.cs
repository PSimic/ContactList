using System;
using System.Collections.Generic;

namespace ContactList.Models
{
    public partial class Menus
    {
        public Menus()
        {
            LinkRolesMenus = new HashSet<LinkRolesMenus>();
        }

        public int Pkey { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public int ParentPkey { get; set; }

        public virtual ICollection<LinkRolesMenus> LinkRolesMenus { get; set; }
    }
}
