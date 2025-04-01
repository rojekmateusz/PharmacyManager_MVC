using MediatR;
using Microsoft.AspNetCore.Mvc;
using PharmacyManager_Application.UseCase.Medicines.Command.CreateMedicine;
using PharmacyManager_Domain.Entities;

namespace PharmacyManager_MVC.Controllers
{
    public class MedicineController(IMediator mediator) : Controller
    {
        public ActionResult CreateMedicine()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMedicine(CreateMedicineCommand command)
        {
            await mediator.Send(command);
            return RedirectToAction(nameof(CreateMedicine));
        }
    }
}
