using Microsoft.AspNetCore.Mvc;

namespace MainProject.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminHomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}