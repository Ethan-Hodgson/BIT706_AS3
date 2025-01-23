using NationalMicrochipRegistry.Models;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Business
{
    public interface IAnimalService
    {
        Task AddAnimalToChipAsync(Animal animal, int microchipId);
        Task<Animal?> GetAnimalAsync(int animalId);
        Task RemoveAnimalAsync(int animalId);
    }
}
