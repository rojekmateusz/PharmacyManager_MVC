namespace PharmacyManager_Domain.Entities;

public class Prescription
{
    public int PrescriptionId { get; set; }
    public string PrescriptionNumber { get; set; } = default!;
    public DateTime IssueDate { get; set; }
    public bool IsRealized { get; set; }
    public string PatientPESEL { get; set; } = default!;


    public ICollection<PrescriptionMedicine> PrescriptionMedicines { get; set; } = [];
}
