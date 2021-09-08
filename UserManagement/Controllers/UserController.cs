using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.DTOs;
using UserManagement.Models;
using UserManagement.Repositories;

namespace UserManagement.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

      

      [HttpGet]
      public IEnumerable<UserDTO> GetUsers()
        {
            return userRepository.GetUsers().Select(user => user.AsDto());
        }   
        [HttpGet("{id}")]
      public ActionResult<UserDTO> GetUser(Guid id)
        {
            var user = userRepository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return user.AsDto();
        }
      [HttpPost]
      public ActionResult<UserDTO> Create(CreateUserDTO createUserDTO)
        {
            var user = new User { Id = new Guid(), Age = 1, CreateAt = DateTime.UtcNow, Username = createUserDTO.Username, Password = createUserDTO.Password };
             userRepository.CreateUser(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user.AsDto());
        }
        [HttpPut("{id}")]
      public ActionResult<UserDTO> Update(Guid id,CreateUserDTO createUserDTO)
        {
            var user = new User { Id = new Guid(), Age = 1, CreateAt = DateTime.UtcNow, Username = createUserDTO.Username, Password = createUserDTO.Password };
             userRepository.CreateUser(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user.AsDto());
        }
    }
}
