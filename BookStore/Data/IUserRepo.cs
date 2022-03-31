using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    interface IUserRepo
    {
        IEnumerable<User> GetAllUser();
    }
}
