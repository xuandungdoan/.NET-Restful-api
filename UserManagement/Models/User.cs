using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    public class User
    {
        public Guid Id { get; init; }
        public string Username { get; init; }
        public string Password { get; init; }
        public int Age { get; init; }
        public DateTimeOffset CreateAt { get; init; }
    }
}
