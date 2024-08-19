using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBillingSystem.DataAccessLayer.Entities
{
    public class OrderItem 
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } 
        public int Quantity { get; set; }    
        public decimal Total => Price * Quantity;      
    }
}
