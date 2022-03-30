using Microsoft.AspNetCore.Mvc;
using SplitR.ExServices.interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using User.Data.getUser;

namespace SplitR.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class userController : ControllerBase
    {
        public readonly iexservices _services;
        public userController(iexservices iexservices)
        {
            _services = iexservices;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var userlist = await _services.GetAllUsers();
            return Ok(userlist);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _services.GetUserById(id);
            if (user != null)
                return Ok(user);
            else
                return BadRequest("invalid entry");
        }
        [HttpPost]
        public async Task<IActionResult> Post(addUser add)
        {
            var useradd = await _services.createUser(add);
            if (useradd)
                return Ok("User Added!");
            else
                return BadRequest("Unable the entry");
        }


    }
}

