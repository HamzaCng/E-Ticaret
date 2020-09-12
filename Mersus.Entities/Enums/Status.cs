using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mersus.Entities.Enums
{
    [Serializable]
    public enum Status
    {       
        [Display(Name = "Active")]
        Active = 1,
        [Display(Name = "Passive")]
        Passive = 2,
        [Display(Name = "Deleted")]
        Deleted = 3
    }
}
