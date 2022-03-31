using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        private readonly MockUserRepo _repo = new MockUserRepo();

        public UsersController()
        {

        }

        [HttpGet]
        public ActionResult <IEnumerable<User>> GetAllUsers()
        {
            return Ok(_repo.GetAllUser());
        }
    }
}
