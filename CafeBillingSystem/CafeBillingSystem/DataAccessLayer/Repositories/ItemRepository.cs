using CafeBillingSystem.DataAccessLayer.ApplicationDbContext;
using CafeBillingSystem.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBillingSystem.DataAccessLayer.Repositories
{
    public class ItemRepository: Repository<Item>
    {
        public ItemRepository(CafeDbContext context):base(context)
        {
            
        }

        public List<string> GetDistinctCategories()
        {
            return _context.Set<Item>().Select(item=>item.Category).Distinct().ToList();
        }
    }
}
