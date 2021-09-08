using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Repositories
{
    public class UserRepository : IUserRepository
    {
        void IUserRepository.CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.DeleteUser(Guid Id)
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetUser(Guid Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            List<User> list = new()
            {
                new User { Id = new Guid(), Age = 2, CreateAt = DateTime.UtcNow, Password = "password", Username = "username" }
            };

            return list;
        }
    } }
