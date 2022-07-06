using CRUD.API.Data;
using CRUD.API.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.API.Controllers
{
    [Route("api/[controller]")]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUserRepository _userRepository;


        public SuperHeroController(DataContext context, IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }

        [HttpGet("GetUsers")]
        public async Task<ActionResult<List<User>>> GetUser()
        {
            return Ok(await _userRepository.GetAllUsersAsync());

        }

        [HttpGet("GetFilteredUsers")]
        public async Task<ActionResult<List<User>>> GetFilteredUsersAsync(string FirstName, string LastName, int personalId)
        {
            return Ok(await _userRepository.GetFilteredUsersAsync(FirstName, LastName, personalId));

        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult<List<User>>> CreateUser(User User)
        {
            return Ok(await _userRepository.AddUserAsync(User));
        }

        [HttpPut("UpdateUser")]
        public async Task<ActionResult<List<User>>> UpdateUser(User updatedUser)
        {
            var oldUserDetails = await _context.Users.FindAsync(updatedUser.Id);
            if (oldUserDetails == null)
                return BadRequest("User not found.");

            return Ok(await _userRepository.UpdateBookAsync(updatedUser));
        }
    }
}
