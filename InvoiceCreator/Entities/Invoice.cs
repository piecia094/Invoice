using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceCreator.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int InvoiceNumber { get; set; }
        public int CreateDate { get; set; }
        public int InvoiceDate { get; set; }
        public virtual Client Client { get; set; }
        public virtual Item Item { get; set; }
    }
}
