using Bogus;
using Core_Api_5175_31052022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Api_5175_31052022.DummyData
{
    public class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int count)
        {
            if (_users==null)
            {
                _users = new Faker<User>().RuleFor(a => a.ID, faker => faker.IndexFaker + 1).RuleFor(a => a.FirstName, faker => faker.Name.FirstName()).RuleFor(a => a.LastName, faker => faker.Name.LastName()).RuleFor(a => a.Address, faker => faker.Address.FullAddress()).Generate(count);
            }

            return _users;
        }
    }
}
