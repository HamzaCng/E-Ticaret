using System;
using System.Collections.Generic;
using System.Text;

namespace Mersus.Entities.Models
{
    public class Order : IEntityBase
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
