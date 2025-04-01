using MediatR;
using PharmacyManager_Application.UseCase.Medicines.Dto;

namespace PharmacyManager_Application.UseCase.Medicines.Queries.GetAllMedicines;

public class GetAllMecicinesQuery: IRequest<IEnumerable<MedicineDto>>
{
}
