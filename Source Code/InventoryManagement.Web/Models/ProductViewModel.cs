using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal CurrentQty { get; set; }
        public string Validate()
        {
            var error = "";

            if (string.IsNullOrEmpty(Code))
                error += "\n" + "Code cannot be empty";
            if (string.IsNullOrEmpty(Name))
                error += "\n" + "Name cannot be empty";

            return error;
        }
    }
}
