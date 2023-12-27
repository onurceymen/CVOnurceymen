using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MainLayer.Controllers;
[Authorize]
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