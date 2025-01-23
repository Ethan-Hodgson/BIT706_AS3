using NationalMicrochipRegistry.Data;
using NationalMicrochipRegistry.Models;
using System;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Business
{
    public class MicrochipService : IMicrochipService
    {
        private readonly IMicrochipRepository _microchipRepository;
        private readonly IAnimalRepository _animalRepository;

        public MicrochipService(IMicrochipRepository microchipRepository, IAnimalRepository animalRepository)
        {
            _microchipRepository = microchipRepository;
            _animalRepository = animalRepository;
        }

        public async Task AssignAnimalToMicrochipAsync(int animalId, string microchipCode)
        {
            var microchip = await _microchipRepository.GetByCodeAsync(microchipCode);
            if (microchip == null)
                throw new ArgumentException("Microchip not found.");

            var animal = await _animalRepository.GetByIdAsync(animalId);
            if (animal == null)
                throw new ArgumentException("Animal not found.");

            animal.MicrochipId = microchip.MicrochipId;
            await _animalRepository.UpdateAsync(animal);
        }

        public async Task DeleteMicrochipAsync(int microchipId)
        {
            await _microchipRepository.DeleteAsync(microchipId);
        }

        public async Task<Animal?> FindAnimalByChipCodeAsync(string microchipCode)
        {
            var microchip = await _microchipRepository.GetByCodeAsync(microchipCode);
            return microchip?.Animal;
        }

        public async Task GenerateMicrochipsAsync(int start, int quantity, int clinicId)
        {
            for (int i = 0; i < quantity; i++)
            {
                var code = $"MICROCHIP{start + i:D4}";
                var chip = new Microchip
                {
                    Code = code,
                    ClinicId = clinicId,
                    RegistrationDate = DateTime.UtcNow,
                    IsActive = true
                };
                await _microchipRepository.AddAsync(chip);
            }
        }
    }
}
