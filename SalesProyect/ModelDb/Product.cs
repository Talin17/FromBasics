using System;
using System.Collections.Generic;

namespace SalesProyect.ModelDb
{
    public partial class Product
    {
        public Product()
        {
            InventoryEntryDetails = new HashSet<InventoryEntryDetail>();
            SalesDetails = new HashSet<SalesDetail>();
        }

        public int ProductId  { get; set; } 
        public string? ProductName { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool IsAvailable { get; set; }
        public string Code { get; set; } = null!;
        public string? Quantity { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<InventoryEntryDetail> InventoryEntryDetails { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
