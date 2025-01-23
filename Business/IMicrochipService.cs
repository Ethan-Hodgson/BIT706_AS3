using NationalMicrochipRegistry.Models;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Business
{
    public interface IMicrochipService
    {
        Task GenerateMicrochipsAsync(int startCode, int count, int clinicId);
        Task AssignAnimalToMicrochipAsync(int animalId, string microchipCode);
        Task DeleteMicrochipAsync(int microchipId);
        Task<Animal?> FindAnimalByChipCodeAsync(string microchipCode);
    }
}
