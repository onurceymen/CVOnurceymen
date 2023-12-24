using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;

namespace MainLayer.Controllers
{
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;

        public EducationController(IEducationService educationService)
        {
            this._educationService = educationService;
        }

        public IActionResult Index()
        {
            var values = _educationService.TGetList();
            return View(values);
        }
    }
}
