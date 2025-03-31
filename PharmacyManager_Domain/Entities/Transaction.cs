namespace PharmacyManager_Domain.Entities;

public class Transaction
{
    public int TransactionId { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal TotalAmount { get; set; }

    public int? PrescriptionId { get; set; }
    public Prescription Prescription { get; set; } = default!;
    
    public ICollection<TransactionItem> TransactionItems { get; set; } = [];
}
