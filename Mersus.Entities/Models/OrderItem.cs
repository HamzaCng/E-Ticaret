using System;
using System.Collections.Generic;
using System.Text;

namespace Mersus.Entities.Models
{
    public class OrderItem : IEntityBase
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
