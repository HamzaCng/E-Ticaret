using Mersus.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersus.WebUI.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status UserStatus { get; set; }
    }
}
