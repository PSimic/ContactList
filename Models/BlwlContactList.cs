using System;
using System.Collections.Generic;

namespace ContactList.Models
{
    public partial class BlwlContactList
    {
        public int Pkey { get; set; }
        public int ContactListGroupPkey { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Comment { get; set; }

        public virtual BlwlContactListGroup ContactListGroupPkeyNavigation { get; set; }
    }
}
