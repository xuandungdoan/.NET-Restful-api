using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; init; }
        public string username { get; init; }
        public int Age { get; init; }
        public DateTimeOffset CreateAt { get; init; }
    }
}
