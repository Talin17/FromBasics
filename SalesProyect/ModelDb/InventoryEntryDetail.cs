using System;
using System.Collections.Generic;

namespace SalesProyect.ModelDb
{
    public partial class InventoryEntryDetail
    {
        public int? InventoryEntryDetailsId { get; set; } = null!;
        public int? InventoryEntryId { get; set; }
        public int? ProductId { get; set; }
        public string? Quantity { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual InventoryEntry? InventoryEntry { get; set; }
        public virtual Product? Product { get; set; }
    }
}
