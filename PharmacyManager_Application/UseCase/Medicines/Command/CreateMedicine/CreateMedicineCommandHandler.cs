using AutoMapper;
using MediatR;
using PharmacyManager_Domain.Entities;
using PharmacyManager_Domain.Interfaces;

namespace PharmacyManager_Application.UseCase.Medicines.Command.CreateMedicine;

public class CreateMedicineCommandHandler(IMapper mapper, IMedicineRepository medicineRepository) : IRequestHandler<CreateMedicineCommand>
{
    public async Task Handle(CreateMedicineCommand request, CancellationToken cancellationToken)
    {
        var medicine = mapper.Map<Medicine>(request);
        await medicineRepository.CreateMedicine(medicine);
    }
}
