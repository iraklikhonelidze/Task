using AutoMapper;
using CRUD.API.Data;
using CRUD.API.IRepository;
using Microsoft.AspNetCore.Mvc;
using Task.Dtos;

namespace CRUD.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserController(DataContext context, IUserRepository userRepository, IMapper mapper)
        {
            _context = context;
            _userRepository = userRepository;
            _mapper = mapper;
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
        public async Task<ActionResult<List<User>>> CreateUser(AddUserDto User)
        {
            return Ok(await _userRepository.AddUserAsync(_mapper.Map<User>(User)));
        }

        [HttpPut("UpdateUser")]
        public async Task<ActionResult<List<User>>> UpdateUser(UpdateUserDto updatedUser)
        {
            var oldUserDetails = await _context.Users.FindAsync(updatedUser.Id);
            if (oldUserDetails == null)
                return BadRequest("User not found.");

            return Ok(await _userRepository.UpdateBookAsync(_mapper.Map<User>(updatedUser)));
        }
    }
}
