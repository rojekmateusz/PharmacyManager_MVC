using PharmacyManager_Domain.Entities;

namespace PharmacyManager_Application.UseCase.Medicines.Dto;

public class MedicineDto
{
    public int MedicineId { get; set; }
    public string Name { get; set; } = default!;
    public string Manufacturer { get; set; } = default!;
    public decimal Price { get; set; }
    public bool RequiresPrescription { get; set; }
    public DateTime ExpiryDate { get; set; }
    public int StockQuantity { get; set; }

 }
