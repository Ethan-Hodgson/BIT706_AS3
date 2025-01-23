using NationalMicrochipRegistry.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Business
{
    public interface IUserService
    {
        Task<bool> LoginAsync(string username, string password);
        Task AddUserAsync(User user);
        Task RemoveUserAsync(int userId);
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
