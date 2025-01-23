using NationalMicrochipRegistry.Models;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Data
{
    public interface IMicrochipRepository : IRepository<Microchip>
    {
        Task<Microchip?> GetByCodeAsync(string code);
    }
}
