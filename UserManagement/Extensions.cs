using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.DTOs;
using UserManagement.Models;

namespace UserManagement
{
    public static class Extensions
    {
        public static UserDTO AsDto(this User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                Age = user.Age,
                CreateAt = user.CreateAt,
                username = user.Username
            };
        }
    }
}
