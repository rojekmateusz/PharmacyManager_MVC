using PharmacyManager_Domain.Entities;
using PharmacyManager_Domain.Interfaces;
using PharmacyManager_Infrastructure.Persistance;

namespace PharmacyManager_Infrastructure.Repositories;

internal class MedicineRepository(PMDbContext dbContext) : IMedicineRepository
{
    public async Task CreateMedicine(Medicine medicine)
    {
        dbContext.Add(medicine);
        await dbContext.SaveChangesAsync();
    }
}
