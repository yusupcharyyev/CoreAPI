using Core_Api_5175_31052022.DummyData;
using Core_Api_5175_31052022.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Api_5175_31052022.Controllers
{
    [Route("api/[Controller]")]
    public class UsersController : ControllerBase
    {
        private List<User> _userList = FakeData.GetUsers(200);


        [HttpGet]
        public List<User> Get()
        {
            return _userList;
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = _userList.FirstOrDefault(a => a.ID == id);
            return user;
        }

        [HttpPost]
        public User Post([FromBody] User user) 
        {
            _userList.Add(user);
            return user;
        }


        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            var deletedUser = _userList.FirstOrDefault(a => a.ID == id);
            _userList.Remove(deletedUser);
        }


        [HttpPut]
        public User Put([FromBody]User user)
        {
            var updatedUser = _userList.FirstOrDefault(a => a.ID == user.ID);
            updatedUser.LastName = user.LastName;
            updatedUser.FirstName = user.FirstName;
            updatedUser.Address = user.Address;
            return user;
        }


        [HttpPut("{id}")]
        public User Put([FromBody] User user,int id)
        {
            var updatedUser = _userList.FirstOrDefault(a => a.ID == id);
            updatedUser.LastName = user.LastName;
            updatedUser.FirstName = user.FirstName;
            updatedUser.Address = user.Address;
            return user;
        }


    }
}
