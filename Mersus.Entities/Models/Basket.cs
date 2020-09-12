using System;
using System.Collections.Generic;
using System.Text;

namespace Mersus.Entities.Models
{
    public class Basket : IEntityBase
    {        
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
