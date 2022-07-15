using System;
using System.Collections.Generic;

namespace SalesProyect.ModelDb
{
    public partial class User
    {
        public User()
        {
            Products = new HashSet<Product>();
            Sales = new HashSet<Sale>();
        }

        public int? UserId { get; set; } = null!;
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? UserName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
