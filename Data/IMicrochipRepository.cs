using NationalMicrochipRegistry.Models;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Data
{
    /// <summary>
    /// Interface for managing microchip-related data operations.
    /// </summary>
    public interface IMicrochipRepository : IRepository<Microchip>
    {
        /// <summary>
        /// Retrieves a microchip by its unique code.
        /// </summary>
        /// <param name="code">The unique microchip code.</param>
        /// <returns>The microchip, or <c>null</c> if not found.</returns>
        Task<Microchip?> GetByCodeAsync(string code);
    }
}
