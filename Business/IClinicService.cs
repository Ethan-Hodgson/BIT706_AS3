using NationalMicrochipRegistry.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NationalMicrochipRegistry.Business
{
    public interface IClinicService
    {
        Task AddClinicAsync(Clinic clinic);
        Task UpdateClinicAsync(Clinic clinic);
        Task DeleteClinicAsync(int clinicId);
        Task<IEnumerable<Clinic>> GetAllClinicsAsync();
    }
}
