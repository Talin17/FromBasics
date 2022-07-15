using System;
using System.Collections.Generic;

namespace SalesProyect.ModelDb
{
    public partial class InventoryEntry
    {
        public InventoryEntry()
        {
            InventoryEntryDetails = new HashSet<InventoryEntryDetail>();
        }

        public int? InventoryEntryId { get; set; } = null!;
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<InventoryEntryDetail> InventoryEntryDetails { get; set; }
    }
}
