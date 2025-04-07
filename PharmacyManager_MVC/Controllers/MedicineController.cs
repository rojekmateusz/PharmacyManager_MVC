using MediatR;
using Microsoft.AspNetCore.Mvc;
using PharmacyManager_Application.UseCase.Medicines.Command.CreateMedicine;
using PharmacyManager_Application.UseCase.Medicines.Queries.GetAllMedicines;
using PharmacyManager_Application.UseCase.Medicines.Queries.GetMedicineByEncodedName;
using PharmacyManager_Domain.Entities;

namespace PharmacyManager_MVC.Controllers
{
    public class MedicineController(IMediator mediator) : Controller
    {
        [Route("Medicine/CreateMedicine")]
        public ActionResult CreateMedicine()
        {
            return View();
        }
               

        [HttpPost]
        [Route("Medicine/CreateMedicine")]
        public async Task<IActionResult> CreateMedicine(CreateMedicineCommand command)
        {
            if (ModelState.IsValid)
            {
                await mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }

            return View(command);
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var medicines = await mediator.Send(new GetAllMecicinesQuery());
            return View(medicines);
        }

        [Route("Medicines/{encodedName}/Details")]
        public async Task<IActionResult> Details(string encodedName)
        {
            var dto = await mediator.Send(new GetMedicineByEncodedNameQuery(encodedName));
            return View(dto);
        }
    }
}
