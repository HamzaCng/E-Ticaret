using Mersus.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mersus.Entities.Models
{
    public class Product : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Photo{ get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }       
        public Status ProductStatus { get; set; }

    }

}
