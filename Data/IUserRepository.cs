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
        /// <example>
        /// <code>
        /// var user = await userRepository.GetByUsernameAsync("johndoe");
        /// if (user != null)
        /// {
        ///     Console.WriteLine($"User ID: {user.UserId}, Username: {user.Username}");
        /// }
        /// else
        /// {
        ///     Console.WriteLine("User not found.");
        /// }
        /// </code>
        /// </example>
        Task<User?> GetByUsernameAsync(string username);
    }
}
