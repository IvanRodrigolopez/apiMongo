using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Prueba.Api.Controllers
{
    [ApiController]
    [Route("Prueba")]
    public class Prueba : ControllerBase
    {

        [Route("insert-user")]
        [HttpPost]
        public IActionResult addUser([FromBody] Vw.Users.VwUser user)
        {
            try
            {
                return Ok(new Ng.Users.User().InsertUser(user));
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
        
        [Route("login-user")]
        [HttpGet]
        public IActionResult Login(string User,string Password)
        {
            try
            {
                return Ok(new Ng.Users.User().GetUserLogin<Vw.Users.VwUser>(User,Password));
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

    }
}
