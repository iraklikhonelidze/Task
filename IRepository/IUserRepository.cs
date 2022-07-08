using Task.Dtos;

namespace CRUD.API.IRepository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync();
        Task<List<User>> AddUserAsync(User newUser);
        Task<List<User>> UpdateBookAsync(User updatedUser);
        Task<List<User>> GetFilteredUsersAsync(string FirstName, string LastName, int personalId);
    }
}