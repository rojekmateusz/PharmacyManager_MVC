using MediatR;
using PharmacyManager_Application.UseCase.Medicines.Dto;

namespace PharmacyManager_Application.UseCase.Medicines.Queries.GetMedicineByEncodedName;

public class GetMedicineByEncodedNameQuery: IRequest<MedicineDto>
{
    public string? EncodedName { get; set; }

    public GetMedicineByEncodedNameQuery(string encodedName)
    {
        EncodedName = encodedName;
    }
}
