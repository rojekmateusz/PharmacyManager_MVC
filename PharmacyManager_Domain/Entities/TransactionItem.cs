namespace PharmacyManager_Domain.Entities;

public class TransactionItem
{
    public int TransactionItemId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public int MedicineId { get; set; }
    public Medicine? Medicine { get; set; } 

    public int TransactionId { get; set; } 
}
