using AutoMapper;
using MediatR;
using PharmacyManager_Application.UseCase.Medicines.Dto;
using PharmacyManager_Domain.Interfaces;

namespace PharmacyManager_Application.UseCase.Medicines.Queries.GetMedicineByEncodedName;

public class GetMedicineByEncodedNameQueryHandler(IMapper mapper, IMedicineRepository medicineRepository) :
    IRequestHandler<GetMedicineByEncodedNameQuery, MedicineDto>
{
    public async Task<MedicineDto> Handle(GetMedicineByEncodedNameQuery request, CancellationToken cancellationToken)
    {
        var medicine = await medicineRepository.GetByEncodedName(request.EncodedName);
        var medicineDto = mapper.Map<MedicineDto>(medicine);
        return medicineDto;
    }
}
