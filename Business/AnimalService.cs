using NationalMicrochipRegistry.Data;
using NationalMicrochipRegistry.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Business
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public async Task AddAnimalToChipAsync(Animal animal, int microchipId)
        {
            animal.MicrochipId = microchipId;
            await _animalRepository.AddAsync(animal);
        }

        public async Task<Animal?> GetAnimalAsync(int animalId)
        {
            return await _animalRepository.GetByIdAsync(animalId);
        }

        public async Task RemoveAnimalAsync(int animalId)
        {
            await _animalRepository.DeleteAsync(animalId);
        }
    }
}
