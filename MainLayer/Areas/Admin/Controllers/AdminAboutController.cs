using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace MainLayer.Areas.Admin.Controllers;

[Area("Admin")]
public class AdminAboutController : Controller
{
    private readonly IAboutService _aboutService;
    // GET
    public AdminAboutController(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public IActionResult Index()
    {
        var values = _aboutService.TGetList();
        return View(values);
    }
    
    [HttpGet]
    public ActionResult AdAbout()
    {
        return View("AdAbout");
    }

    [HttpPost]
    public ActionResult AdAbout(About about)
    {
        if (ModelState.IsValid)
        {
            _aboutService.TAdd(about);
            return RedirectToAction("Index"); // Eğer bir listeleme sayfası varsa, ona yönlendirilebilir.
        }

        return View("AdAbout", about);
    }
    

    
}