using CRUD.API.Data;
using CRUD.API.IRepository;
using Microsoft.EntityFrameworkCore;

namespace CRUD.API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>> AddUserAsync(User newUser)
        {
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }



        public async Task<List<User>> UpdateBookAsync(User updatedUser)
        {
            var user = await _context.Users.FindAsync(updatedUser.Id);

            user.FirstName = updatedUser.FirstName;
            user.LastName = updatedUser.LastName;
            user.personalId = updatedUser.personalId;
            user.YearOfBirth = updatedUser.YearOfBirth;
            user.Gender = updatedUser.Gender;
            user.IsActive = updatedUser.IsActive;

            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }






        public async Task<List<User>> GetFilteredUsersAsync(string FirstName, string LastName, int personalId)
        {
            List<User> records = new List<User>();

            records = await _context.Users.ToListAsync();

            if (FirstName != null)
                records = records.Where(o => o.FirstName == FirstName).ToList();

            if (LastName != null)
                records = records.Where(o => o.LastName == LastName).ToList();

            if (personalId != 0)
                records = records.Where(o => o.personalId == personalId).ToList();



            return records.OrderByDescending(i => i.Id).ToList();
        }
    }
}