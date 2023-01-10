using Microsoft.AspNetCore.Mvc;
using Infrastructure;
using Application.Interfaces;

namespace EntityWithDapper.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
       
        private readonly ILogger<UserController> _logger;
        private readonly IUser _user;

        public UserController(ILogger<UserController> logger,IUser user)
        {
            _logger = logger;
            _user=user;
        }

        [HttpGet]
        [Route("getusers")]
        public async Task<IActionResult> GetUsers()
        {
            var u =await _user.GetUsers();
            return Ok(u);
            
        }
    }
}