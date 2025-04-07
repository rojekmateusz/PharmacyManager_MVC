using PharmacyManager_Domain.Entities;

namespace PharmacyManager_Domain.Interfaces;

public interface IMedicineRepository
{
    Task CreateMedicine(Medicine medicine);
    Task<IEnumerable<Medicine>> GetAllMedicines();
    Task<Medicine> GetByEncodedName(string encodedName);
}
