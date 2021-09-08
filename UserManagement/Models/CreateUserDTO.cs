using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    public class CreateUserDTO
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
