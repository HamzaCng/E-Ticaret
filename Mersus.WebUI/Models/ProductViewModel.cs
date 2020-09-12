using Mersus.Entities.Enums;
using Mersus.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersus.WebUI.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Photo { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status ProductStatus { get; set; }
    }
}
