using Mersus.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersus.WebUI.Models
{
    public class BasketViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
