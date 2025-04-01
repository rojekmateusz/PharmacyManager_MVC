using MediatR;
using PharmacyManager_Application.UseCase.Medicines.Dto;

namespace PharmacyManager_Application.UseCase.Medicines.Command.CreateMedicine;

public class CreateMedicineCommand: MedicineDto, IRequest
{
}
