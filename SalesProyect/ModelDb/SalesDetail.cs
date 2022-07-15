using System;
using System.Collections.Generic;

namespace SalesProyect.ModelDb
{
    public partial class SalesDetail
    {
        public int? SalesDetailsId { get; set; } = null!;
        public int? ProductId { get; set; }
        public string? Quantity { get; set; }
        public DateTime? CreationDate { get; set; }
        public int SalesId { get; set; }
        public string? Price { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Sale? Sales { get; set; }
    }
}
