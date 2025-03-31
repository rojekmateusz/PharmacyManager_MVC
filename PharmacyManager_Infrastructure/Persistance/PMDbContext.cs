using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using PharmacyManager_Domain.Entities;

namespace PharmacyManager_Infrastructure.Persistance;

internal class PMDbContext(DbContextOptions<PMDbContext> options) : DbContext(options)
{
    internal DbSet<Medicine> Medicines { get; set; }
    internal DbSet<Prescription> Prescriptions { get; set; }
    internal DbSet<PrescriptionMedicine> PrescriptionMedicines { get; set; }
    internal DbSet<Transaction> Transactions { get; set; }
    internal DbSet<TransactionItem> TransactionItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PrescriptionMedicine>()
                .HasKey(pm => new { pm.PrescriptionId, pm.MedicineId });

        modelBuilder.Entity<PrescriptionMedicine>()
            .HasOne(m => m.Medicine)
            .WithMany(pm => pm.PrescriptionMedicines)
            .HasForeignKey(m => m.MedicineId);


        modelBuilder.Entity<PrescriptionMedicine>()
            .HasOne(p => p.Prescription)
            .WithMany(pm => pm.PrescriptionMedicines)
            .HasForeignKey(p => p.PrescriptionId);

        modelBuilder.Entity<Transaction>()
            .HasMany(ti => ti.TransactionItems)
            .WithOne()
            .HasForeignKey(t => t.TransactionId);

        modelBuilder.Entity<TransactionItem>()
            .HasOne(t => t.Medicine)
            .WithMany()
            .HasForeignKey(t => t.MedicineId);
    }
}
