using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Repositories
{
   public interface IUserRepository
    {
        public IEnumerable<User> GetUsers();
        public User GetUser(Guid Id);
        public void CreateUser(User user);
        public void DeleteUser(Guid Id);

    }
}
