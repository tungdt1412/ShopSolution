using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
