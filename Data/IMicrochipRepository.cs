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
        /// <example>
        /// <code>
        /// var microchip = await microchipRepository.GetByCodeAsync("12345ABC");
        /// if (microchip != null)
        /// {
        ///     Console.WriteLine($"Microchip Code: {microchip.Code}");
        /// }
        /// else
        /// {
        ///     Console.WriteLine("Microchip not found.");
        /// }
        /// </code>
        /// </example>
        Task<Microchip?> GetByCodeAsync(string code);
    }
}
