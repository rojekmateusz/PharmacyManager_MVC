namespace PharmacyManager_Domain.Entities;

public class Transaction
{
    public int Id { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal TotalAmount { get; set; }

    public int? PrescriptionId { get; set; }
    public Prescription Prescription { get; set; } = default!;

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = default!;

    public ICollection<TransactionItem> Items { get; set; } = [];
}
