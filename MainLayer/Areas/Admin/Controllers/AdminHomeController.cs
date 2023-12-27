using Microsoft.AspNetCore.Mvc;

namespace MainLayer.Areas.Admin.Controllers;

public class AdminHomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}