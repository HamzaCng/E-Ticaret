using Mersus.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersus.WebUI.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }       
        public decimal TotalPrice { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
