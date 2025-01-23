using NationalMicrochipRegistry.Data;
using NationalMicrochipRegistry.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Business
{
    public class ClinicService : IClinicService
    {
        private readonly IClinicRepository _clinicRepository;

        public ClinicService(IClinicRepository clinicRepository)
        {
            _clinicRepository = clinicRepository;
        }

        public async Task AddClinicAsync(Clinic clinic)
        {
            if (string.IsNullOrWhiteSpace(clinic.Name))
                throw new ArgumentException("Clinic name cannot be empty.");

            await _clinicRepository.AddAsync(clinic);
        }

        public async Task UpdateClinicAsync(Clinic clinic)
        {
            await _clinicRepository.UpdateAsync(clinic);
        }

        public async Task DeleteClinicAsync(int clinicId)
        {
            await _clinicRepository.DeleteAsync(clinicId);
        }

        public async Task<IEnumerable<Clinic>> GetAllClinicsAsync()
        {
            return await _clinicRepository.GetAllAsync();
        }
    }
}
