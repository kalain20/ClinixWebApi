using System.Text.Json;
using ClinixWebApi.Context;
using ClinixWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinixWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("Authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User users)
        {
            if (users == null)
                return BadRequest();

            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == users.UserName && x.Password == users.Password);
            if (user == null)
                return NotFound(new { Message = " User not Found !" });

            string userJson = JsonSerializer.Serialize<User>(user);

            return Ok(userJson);




        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] User users)
        {
            if (users == null)
                return BadRequest();

            await _context.Users.AddAsync(users);
            await _context.SaveChangesAsync();

            return Ok(new
                {
                    Message = "User Registered !"
                });
        }


    }
}
