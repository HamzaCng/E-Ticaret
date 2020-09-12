using System;
using System.Collections.Generic;
using System.Text;

namespace Mersus.Entities
{
    public interface IEntityBase
    {
        int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
