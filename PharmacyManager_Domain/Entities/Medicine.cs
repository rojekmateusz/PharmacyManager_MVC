namespace PharmacyManager_Domain.Entities;

public class Medicine
{
    public int MedicineId { get; set; }
    public string Name { get; set; } = default!;
    public string Manufacturer { get; set; } = default!;
    public decimal Price { get; set; }
    public bool RequiresPrescription { get; set; }
    public DateTime ExpiryDate { get; set; }
    public int StockQuantity { get; set; }

    public ICollection<PrescriptionMedicine> PrescriptionMedicines { get; set; } = [];
    public ICollection<TransactionItem> TransactionItems { get; set; } = [];
}
