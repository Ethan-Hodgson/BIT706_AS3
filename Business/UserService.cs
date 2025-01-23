using NationalMicrochipRegistry.Data;
using NationalMicrochipRegistry.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Business
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);
            if (user == null) return false;
            return user.PasswordHash == password; 
        }

        public async Task AddUserAsync(User user)
        {
            await _userRepository.AddAsync(user);
        }

        public async Task RemoveUserAsync(int userId)
        {
            await _userRepository.DeleteAsync(userId);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }
    }
}
