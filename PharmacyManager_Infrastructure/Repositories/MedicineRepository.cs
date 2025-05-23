﻿using Microsoft.EntityFrameworkCore;
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

    public async Task<IEnumerable<Medicine>> GetAllMedicines()
    {
        var medicines = await dbContext.Medicines.ToListAsync();
        return medicines;
    }

    public async Task<Medicine> GetByEncodedName(string encodedName)
    {
        var medicine = await dbContext.Medicines.FirstAsync(m => m.EncodedName == encodedName);
        return medicine;
    }
}
