using BusinessLayer.Abstract;

using Microsoft.AspNetCore.Mvc;

namespace MainProject.Controllers;

public class AboutController : Controller
{
    private readonly IAboutService _aboutService;

    public AboutController(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    // GET
    public IActionResult Index()
    {
        var values = _aboutService.TGetList();
        return View(values);
    }
}