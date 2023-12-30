using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MainProject.Controllers;

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