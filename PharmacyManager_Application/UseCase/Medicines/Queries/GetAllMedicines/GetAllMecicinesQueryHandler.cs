using AutoMapper;
using MediatR;
using PharmacyManager_Application.UseCase.Medicines.Dto;
using PharmacyManager_Domain.Interfaces;

namespace PharmacyManager_Application.UseCase.Medicines.Queries.GetAllMedicines;

public class GetAllMecicinesQueryHandler(IMapper mapper, IMedicineRepository medicineRepository) : IRequestHandler<GetAllMecicinesQuery, IEnumerable<MedicineDto>>
{
    public async Task<IEnumerable<MedicineDto>> Handle(GetAllMecicinesQuery request, CancellationToken cancellationToken)
    {
        var medicines = await medicineRepository.GetAllMedicines();
        var medicinesDto = mapper.Map<IEnumerable<MedicineDto>>(medicines);
        return medicinesDto;
    }
}
