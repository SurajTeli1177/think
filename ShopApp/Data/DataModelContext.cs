using Microsoft.EntityFrameworkCore;
using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ShopApp.Data
{
    public class DataModelContext : DbContext
    {
        public DataModelContext()
        {
        }
        public DataModelContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Item> Items { set; get; }

        //public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    var result = await base.SaveChangesAsync(cancellationToken);
        //    return result;
        //}
    }
}
