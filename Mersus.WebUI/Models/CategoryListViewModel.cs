using Mersus.Entities.Enums;
using Mersus.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersus.WebUI.Models
{
    public class CategoryListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status CategoryStatus { get; set; }
        public List<Category> Categories { get; internal set; }
    }
}
