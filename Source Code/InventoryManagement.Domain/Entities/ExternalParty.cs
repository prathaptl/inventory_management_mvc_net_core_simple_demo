using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Domain.Entities
{
    public enum ExternalPartyType
    {
        Customer,
        Merchant
    }

    public class ExternalParty : EntityBase
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ExternalPartyType Type { get; set; }
    }
}
