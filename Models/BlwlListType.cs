using System;
using System.Collections.Generic;

namespace ContactList.Models
{
    public partial class BlwlListType
    {
        public BlwlListType()
        {
            BlwlContactListGroup = new HashSet<BlwlContactListGroup>();
        }

        public int Pkey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BlwlContactListGroup> BlwlContactListGroup { get; set; }
    }
}
