using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Data
{
    public class DbContextStoreOptions
    {
        public string DefaultSchema { get; set; } = "dbo";

        //public TableConfiguration Item { get; set; } = new TableConfiguration("Item", "dbo");
    }
}
