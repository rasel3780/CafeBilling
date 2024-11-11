using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBillingSystem.DataAccessLayer.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ServedBy { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Vat { get; set; }
        public Decimal Discount { get; set; }         
        public decimal Total { get; set; }
        public int TokenNumber { get; set; }

        public virtual ICollection<OrderDetail> Items { get; set; }
    }
}
