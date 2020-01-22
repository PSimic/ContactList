using System;
using System.Collections.Generic;

namespace ContactList.Models
{
    public partial class BlwlContactListGroup
    {
        public BlwlContactListGroup()
        {
            BlwlContactList = new HashSet<BlwlContactList>();
        }

        public int Pkey { get; set; }
        public string Name { get; set; }
        public int? ListTypePkey { get; set; }

        public virtual BlwlListType ListTypePkeyNavigation { get; set; }
        public virtual ICollection<BlwlContactList> BlwlContactList { get; set; }
    }
}
