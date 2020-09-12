using Mersus.Entities;
using Mersus.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mersus.Entities.Models
{
    public class Category : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status CategoryStatus { get; set; }
    }
}
