using AutoMapper;
using PharmacyManager_Application.UseCase.Medicines.Command.CreateMedicine;
using PharmacyManager_Domain.Entities;

namespace PharmacyManager_Application.UseCase.Medicines.Dto;

public class MedicineProfile : Profile
{
    public MedicineProfile()
    {
        CreateMap<Medicine, MedicineDto>();
        CreateMap<CreateMedicineCommand, Medicine>();
    }
}
