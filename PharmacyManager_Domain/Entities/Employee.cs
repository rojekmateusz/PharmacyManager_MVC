namespace PharmacyManager_Domain.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string LicenseNumber { get; set; } = default!; 
    public string Role { get; set; } = default!;
    public ICollection<Transaction> Transactions { get; set; } = [];
}
