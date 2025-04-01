using FluentValidation;
using System.Xml;

namespace PharmacyManager_Application.UseCase.Medicines.Command.CreateMedicine;

public class CreateMedicineCommandValidator : AbstractValidator<CreateMedicineCommand>
{
    public CreateMedicineCommandValidator()
    {
        RuleFor(dto => dto.Name)
          .Length(2, 40)
          .WithMessage("Medicine name must contain from 2 to 40 characters");

        RuleFor(dto => dto.Manufacturer)
            .Length(2, 40)
          .WithMessage("Medicine manufacturer must contain from 2 to 40 characters");

        RuleFor(dto => dto.Price)
            .GreaterThan(0)
            .WithMessage("Price must by greater than 0");

        RuleFor(dto => dto.StockQuantity)
           .GreaterThanOrEqualTo(0)
           .WithMessage("Price must by greater or equal to 0");

    }
}
