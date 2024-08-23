using CafeBillingSystem.DataAccessLayer.ApplicationDbContext;
using CafeBillingSystem.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBillingSystem.DataAccessLayer.Repositories
{
    public class SaleRepository : Repository<Order>
    {
        public SaleRepository(CafeDbContext context):base(context)
        {
            
        }

        public decimal GetTodaysSale()
        {
            var today = DateTime.Today;
            return _context.Set<Order>()
                           .Where(order => DbFunctions.TruncateTime(order.OrderDate) == today)
                           .Sum(order => (decimal?)order.Total)
                           .GetValueOrDefault();
        }

        public decimal GetMonthlySales(int year, int month)
        {
            return _context.Set<Order>()
                    .Where(order=>order.OrderDate.Year==year && 
                    order.OrderDate.Month==month)
                    .Sum(order =>(decimal?) order.Total)
                    .GetValueOrDefault();
        }

        public decimal GetYearlySales(int year)
        {
            return _context.Set<Order>()
                        .Where(order=>order.OrderDate.Year==year)
                        .Sum(order =>(decimal?) order.Total)
                        .GetValueOrDefault(); 
        }

        public List<Item> GetTopSellingItems(int topN)
        {
            return _context.Set<OrderDetail>()
                        .GroupBy(order=>order.ItemId)
                        .OrderByDescending(g=>g.Sum(order=>order.Quantity))
                        .Take(topN)
                        .Select(g=>g.FirstOrDefault().Item)
                        .ToList();
        }
    }
}
