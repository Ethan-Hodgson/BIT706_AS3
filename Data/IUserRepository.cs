using NationalMicrochipRegistry.Models;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Data
{
    /// <summary>
    /// Interface for managing user-related data operations.
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Retrieves a user by their username.
        /// </summary>
        /// <param name="username">The username of the user to retrieve.</param>
        /// <returns>The user, or <c>null</c> if not found.</returns>
        Task<User?> GetByUsernameAsync(string username);
    }
}
