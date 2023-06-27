using System.Text.Json;
using ClinixWebApi.Context;
using ClinixWebApi.Helpers;
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
        /// <summary>
        /// Fonction permettant de faire l'authentification
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPost("Authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User users)
        {
            if (users == null)
                return BadRequest();
            users.Password = Helper.HashingString(users.Password);
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == users.UserName && x.Password == users.Password);
            if (user == null)
                return NotFound(new { Message = " User not Found !" });

            string userJson = JsonSerializer.Serialize<User>(user);

            return Ok(userJson);
        }
        /// <summary>
        /// Fonction permettant d'enroller un utilisateur
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] User user)
        {
            if (user == null)
                return BadRequest();
            user.Password = Helper.HashingString(user.Password);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            
            return Ok(new
                {
                    Message = "User Registered !"
                });
        }


    }
}
