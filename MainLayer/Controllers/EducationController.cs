using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;

namespace MainLayer.Controllers
{
    public class EducationController : Controller
    {
        private readonly IEducationService educationService;
        public IActionResult Index()
        {
            var values = educationService.TgetList();
            return View(values);
        }
    }
}
