using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceCreator.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int NetValue { get; set; }
        public int Tax { get; set; }
        public int Quantity { get; set; }
        public int OrdinalNumber { get; set; }
    }
}
