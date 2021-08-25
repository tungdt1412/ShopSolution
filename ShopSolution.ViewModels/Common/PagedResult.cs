using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.ViewModels.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}
