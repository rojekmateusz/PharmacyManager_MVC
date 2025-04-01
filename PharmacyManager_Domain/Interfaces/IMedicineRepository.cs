using PharmacyManager_Domain.Entities;

namespace PharmacyManager_Domain.Interfaces;

public interface IMedicineRepository
{
    Task CreateMedicine(Medicine medicine);
}
