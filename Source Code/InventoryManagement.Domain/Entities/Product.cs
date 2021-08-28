using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryManagement.Domain.Entities
{
    [Table("products")]
    public class Product : EntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal CurrentQty { get; set; }
    }
}
