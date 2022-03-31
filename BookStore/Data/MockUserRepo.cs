using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class MockUserRepo : IUserRepo
    {
        public IEnumerable<User> GetAllUser()
        {
            var users = new List<User>
            {
                new User {Id=1,Username="tung",Password="123",Token="123"},
                new User {Id=2,Username="tung",Password="123",Token="123"},
                new User {Id=3,Username="tung",Password="123",Token="123"}
            };
            return users;
        }
    }
}
