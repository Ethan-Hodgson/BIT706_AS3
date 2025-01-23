using NationalMicrochipRegistry.Models;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Data
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByUsernameAsync(string username);
    }
}
