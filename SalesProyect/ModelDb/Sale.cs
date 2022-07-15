using System;
using System.Collections.Generic;

namespace SalesProyect.ModelDb
{
    public partial class Sale
    {
        public Sale()
        {
            SalesDetails = new HashSet<SalesDetail>();
        }

        public int? SaleId { get; set; } = null!;
        public string? Total { get; set; }
        public int UserId { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
